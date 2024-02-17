using NAudio.Wave;
using System.Timers;
using System.IO;
using Timer = System.Timers.Timer;


namespace StadtgespraecheMeerblicke
{
    internal class RecorderItem
    {
        WaveIn waveSource = null;
        WaveFileWriter waveFile = null;
        Timer RecordingTimer = null;
        Timer AudioProgressTimer = null;
        WaveOut waveOut = null;
        WaveFileReader waveReader;

        private static Random random = new Random();
        private String lastFileName = "";

        int deviceInput;
        int deviceOutput;
        int recordSeconds = 0;

        bool isRecording = false;
        bool isPlaying = false; 

        public event EventHandler<RecorderPlayerEventArgs> PlayerChanged;
        public event EventHandler<AudioProgressEventArgs> PlayerProgress;

        int currentAudioTimeTotal = 0; 
        int bitrate = 44100;

        int audioProgressInterval = 20;
        int audioTimeElapsed = 0; 


        public RecorderItem(int deviceInNumber, int deviceOutNumber, int recordSeconds)
        {
            this.deviceInput = deviceInNumber;
            this.deviceOutput = deviceOutNumber;
            this.recordSeconds = recordSeconds;

            AudioProgressTimer = new Timer();
            AudioProgressTimer.Enabled = true;
            
            AudioProgressTimer.Interval = audioProgressInterval;
            AudioProgressTimer.AutoReset = true;
            AudioProgressTimer.Elapsed += InvokeAudioProgressEvent;
            AudioProgressTimer.Start();


        }

        private void InvokeAudioProgressEvent(object? sender, ElapsedEventArgs e)
        {
            if (isPlaying || isRecording)
            {
                audioTimeElapsed += audioProgressInterval;
                AudioProgressEventArgs apea = new AudioProgressEventArgs();
                apea.Progress = audioTimeElapsed;
                apea.Total = currentAudioTimeTotal;
                PlayerProgress.Invoke(this, apea);
            }
        }

        public void setInputNumber(int number)
        {
            this.deviceInput = number;
            InvokeEventWithMessage("Changed Input to " +  number, "Idle");
            
            
        }

        public void setOutputNumber(int number)
        {
            this.deviceOutput = number;
           InvokeEventWithMessage("Changed Output to " + number, "Idle");
        }

        public void record()
        {
            try
            {
                if (isRecording == false && isPlaying == false)
                {

                    

                    waveSource = new WaveIn();
                    waveSource.WaveFormat = new WaveFormat(bitrate, 1);
                    waveSource.DeviceNumber = deviceInput;

                    waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
                    waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);
                    String toWrite = GenerateRandomString() + ".wav";
                    lastFileName = toWrite;
                    waveFile = new WaveFileWriter(toWrite, waveSource.WaveFormat);

                    RecordingTimer = new Timer(recordSeconds * 1000);


                    RecordingTimer.AutoReset = false;


                    RecordingTimer.Elapsed += StopRecording;

                    currentAudioTimeTotal = recordSeconds * 1000;
                    Console.WriteLine("Recording, " + currentAudioTimeTotal);

                    waveSource.StartRecording();
                    isRecording = true;

                    RecordingTimer.Start();
                    AudioProgressTimer.Enabled = true;

                    InvokeEventWithMessage("Started Recording " + lastFileName, "Recording");
                }
                else if (isRecording == true)
                {
                  
                    InvokeEventWithMessage("Duplicate Recording Stopped", "Recording");
                }
                else if (isPlaying == true)
                {
                    
                    InvokeEventWithMessage("Recording while Playing Stopped", "Playing");
                }
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage("Record Error" + ex.Message, "Error");
            }

        }

        private void StopRecording(object sender, ElapsedEventArgs e)
        {
           
            RecordingTimer.Stop();
            RecordingTimer.Dispose();
            waveSource.StopRecording();
            Console.WriteLine("Recording stopped on device " + deviceInput);
            InvokeEventWithMessage("Stopped Recording " +lastFileName, "Idle");
            //AudioProgressTimer.Enabled = false;
            isRecording = false;
            currentAudioTimeTotal = 0;
            audioTimeElapsed = 0;
        }


       public void playLast()
        {
            try
            {
                if (isPlaying == false && isRecording == false && lastFileName != "")
                {
                    
                    InvokeEventWithMessage("Started Playback " + lastFileName, "Playing");
                  
                    waveReader = new NAudio.Wave.WaveFileReader(lastFileName);
                    waveOut = new NAudio.Wave.WaveOut();
                    waveOut.DeviceNumber = this.deviceOutput;
                    waveOut.Init(waveReader);
                    currentAudioTimeTotal = recordSeconds * 1000;
                    Console.WriteLine("Playing, " + currentAudioTimeTotal);
                    waveOut.Play();
                    isPlaying = true;
                    waveOut.PlaybackStopped += waveOut_PlaybackStopped;
                }
                else if (isRecording == true)
                {
                   InvokeEventWithMessage("Playing while Recording Stopped", "Recording");
                }
                else if (isPlaying == true)
                {
                    InvokeEventWithMessage("Already Playing", "Playing");
                }
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage("Error Playing " + ex.Message, "Error");
            }

        }

        private void waveOut_PlaybackStopped(object? sender, StoppedEventArgs e)
        {
          
            InvokeEventWithMessage("Stopped playing", "Idle");
            waveOut.Dispose();
            waveReader.Dispose();
            isPlaying = false;
            currentAudioTimeTotal = 0;
            audioTimeElapsed = 0;
        }



        public void playRandom()
        {
            String fileName = getRandomWav();

            try
            {
                if (isPlaying == false && isRecording == false && fileName != "" )
                {

                    InvokeEventWithMessage("Started Random Playback " + fileName, "Playing");

                    waveReader = new NAudio.Wave.WaveFileReader(fileName);
                    waveOut = new NAudio.Wave.WaveOut();
                    waveOut.DeviceNumber = this.deviceOutput;
                    waveOut.Init(waveReader);
                    currentAudioTimeTotal = recordSeconds * 1000;
                    // currentAudioTimeTotal = (int)(currentAudioTimeTotal * 0.8);
                    Console.WriteLine("Playing, " + currentAudioTimeTotal);
                    waveOut.Play();
                    isPlaying = true;
                    waveOut.PlaybackStopped += waveOut_PlaybackStopped;
                }
                else if (isRecording == true)
                {
                    InvokeEventWithMessage("Duplicate Playback Stopped", "Idle");
                }
                else if (isPlaying == true)
                {
                    InvokeEventWithMessage("Playing while Recording Stopped", "Idle");
                }
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage("Error Random Playing " + ex.Message, "Error");
                playRandom();
            }
        }

        private List<String> getAllWavFiles()
        {
            List<String> files = new List<String>();
            try
            {
                // Check if the directory exists
            
                    string[] wavFiles = Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.wav");
                    Console.WriteLine("WAV: "+ wavFiles.Length);
                    foreach (string file in wavFiles)
                    {
                        files.Add(file);
                    }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return files;

            }
            Console.WriteLine("Files count: " + files.Count);
            return files;
        }

        private String getRandomWav()
        {
            try
            {
                List<String> playableFiles = getAllWavFiles();
                int count = playableFiles.Count;
                int randomIndex = random.Next(count);
                return playableFiles[randomIndex];
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage(ex.Message, "Error");
                return "";
            }

        }


        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }


        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }

          
        }

        public void InvokeEventWithMessage(String message, String state)
        {
            RecorderPlayerEventArgs toPass = new RecorderPlayerEventArgs();
            toPass.Message = message;
            toPass.isPlaying = isPlaying;
            toPass.isRecording = isRecording;
            toPass.state = state;

            PlayerChanged.Invoke(this, toPass);

        }


        public string GenerateRandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
    class RecorderPlayerEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string state { get; set; }
        public bool isPlaying { get; set; }
        public bool isRecording { get; set; }  
    }
    class AudioProgressEventArgs : EventArgs
    {
        public int Progress { get; set; }
        public int Total { get; set; }
    }
}
