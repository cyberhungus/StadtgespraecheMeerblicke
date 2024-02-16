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
        Timer timer = null;
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


        public RecorderItem(int deviceInNumber, int deviceOutNumber, int recordSeconds)
        {
            this.deviceInput = deviceInNumber;
            this.deviceOutput = deviceOutNumber;
            this.recordSeconds = recordSeconds;


        }

        public void setInputNumber(int number)
        {
            this.deviceInput = number;
            InvokeEventWithMessage("Changed Input to " +  number);
            
            
        }

        public void setOutputNumber(int number)
        {
            this.deviceOutput = number;
           InvokeEventWithMessage("Changed Output to " + number);
        }

        public void record()
        {
            try
            {
                if (isRecording == false && isPlaying == false)
                {

                    

                    waveSource = new WaveIn();
                    waveSource.WaveFormat = new WaveFormat(44100, 1);
                    waveSource.DeviceNumber = deviceInput;

                    waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
                    waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);
                    String toWrite = GenerateRandomString() + ".wav";
                    lastFileName = toWrite;
                    waveFile = new WaveFileWriter(toWrite, waveSource.WaveFormat);

                    timer = new Timer(recordSeconds * 1000);


                    timer.AutoReset = false;


                    timer.Elapsed += StopRecording;


                    waveSource.StartRecording();
                    isRecording = true;

                    timer.Start();
                 
                    InvokeEventWithMessage("Started Recording " + lastFileName);
                }
                else if (isRecording == true)
                {
                  
                    InvokeEventWithMessage("Duplicate Recording Stopped");
                }
                else if (isPlaying == true)
                {
                    
                    InvokeEventWithMessage("Recording while Playing Stopped");
                }
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage("Record Error" + ex.Message);
            }

        }

        private void StopRecording(object sender, ElapsedEventArgs e)
        {
           
            timer.Stop();
            timer.Dispose();
            waveSource.StopRecording();
            Console.WriteLine("Recording stopped on device " + deviceInput);
            InvokeEventWithMessage("Stopped Recording " +lastFileName);
            isRecording = false;
        }


       public void playLast()
        {
            try
            {
                if (isPlaying == false && isRecording == false && lastFileName != "")
                {
                    
                    InvokeEventWithMessage("Started Playback " + lastFileName);
                  
                    waveReader = new NAudio.Wave.WaveFileReader(lastFileName);
                    waveOut = new NAudio.Wave.WaveOut();
                    waveOut.DeviceNumber = this.deviceOutput;
                    waveOut.Init(waveReader);

                    waveOut.Play();
                    isPlaying = true;
                    waveOut.PlaybackStopped += waveOut_PlaybackStopped;
                }
                else if (isRecording == true)
                {
                   InvokeEventWithMessage("Duplicate Playback Stopped");
                }
                else if (isPlaying == true)
                {
                    InvokeEventWithMessage("Playing while Recording Stopped");
                }
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage("Error Playing " + ex.Message);
            }

        }

        private void waveOut_PlaybackStopped(object? sender, StoppedEventArgs e)
        {
          
            InvokeEventWithMessage("Stopped playing");
            waveOut.Dispose();
            waveReader.Dispose();
            isPlaying = false;
        }

        public void playRandom()
        {
            String fileName = getRandomWav();

            try
            {
                if (isPlaying == false && isRecording == false && fileName != "" )
                {

                    InvokeEventWithMessage("Started Random Playback " + fileName);

                    waveReader = new NAudio.Wave.WaveFileReader(fileName);
                    waveOut = new NAudio.Wave.WaveOut();
                    waveOut.DeviceNumber = this.deviceOutput;
                    waveOut.Init(waveReader);

                    waveOut.Play();
                    isPlaying = true;
                    waveOut.PlaybackStopped += waveOut_PlaybackStopped;
                }
                else if (isRecording == true)
                {
                    InvokeEventWithMessage("Duplicate Playback Stopped");
                }
                else if (isPlaying == true)
                {
                    InvokeEventWithMessage("Playing while Recording Stopped");
                }
            }
            catch (Exception ex)
            {
                InvokeEventWithMessage("Error Random Playing " + ex.Message);
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
                InvokeEventWithMessage(ex.Message);
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

        public void InvokeEventWithMessage(String message)
        {
            RecorderPlayerEventArgs toPass = new RecorderPlayerEventArgs();
            toPass.Message = message;
            toPass.isPlaying = isPlaying;
            toPass.isRecording = isRecording;

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
        public bool isPlaying { get; set; }
        public bool isRecording { get; set; }


       
    }
}
