using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace StadtgespraecheMeerblicke
{
    public partial class Form1 : Form
    {
        RecorderItem Rec1;
        RecorderItem Rec2;
        RecorderItem Rec3;
        RecorderItem Rec4;

        List<Tuple<int, String>> RecordingDevices = new List<Tuple<int, string>>();
        List<Tuple<int, String>> PlayBackDevices = new List<Tuple<int, string>>();

        List<String> Player1_Messages = new List<String>();
        List<String> Player2_Messages = new List<String>();
        List<String> Player3_Messages = new List<String>();
        List<String> Player4_Messages = new List<String>();

        int playbackTime = 7;


        public Form1()
        {



            InitializeComponent();
            DeviceScan();
            Rec1 = new RecorderItem(0, 1, playbackTime);
            Rec1.PlayerChanged += Player1_Changed;
            Rec2 = new RecorderItem(2, 0, playbackTime);
            Rec2.PlayerChanged += Player2_Changed;
            Rec3 = new RecorderItem(3, 3, playbackTime);
            Rec3.PlayerChanged += Rec3_PlayerChanged;
            Rec4 = new RecorderItem(3, 3, playbackTime);
            Rec4.PlayerChanged += Rec4_PlayerChanged;
        }

        private void Rec4_PlayerChanged(object? sender, RecorderPlayerEventArgs e)
        {
            Player4_Messages.Add(e.Message);
            if (Player4_Messages.Count > 10)
            {
                Player4_Messages.RemoveAt(0);
            }
            Console.WriteLine("4 RECEIVED: " + Player4_Messages.Count);
        }

        private void Rec3_PlayerChanged(object? sender, RecorderPlayerEventArgs e)
        {
            Player3_Messages.Add(e.Message);
            if (Player3_Messages.Count > 10)
            {
                Player3_Messages.RemoveAt(0);
            }
            Console.WriteLine("3 RECEIVED: " + Player3_Messages.Count);

        }

        private void Player2_Changed(object? sender, RecorderPlayerEventArgs e)
        {
            Player2_Messages.Add(e.Message);
            if (Player2_Messages.Count > 10)
            {
                Player2_Messages.RemoveAt(0);
            }
            Console.WriteLine("2 RECEIVED: " + Player2_Messages.Count);

        }

        private void Player1_Changed(object? sender, RecorderPlayerEventArgs e)
        {
            Player1_Messages.Add(e.Message);
            if (Player1_Messages.Count > 10)
            {
                Player1_Messages.RemoveAt(0);
            }
            Console.WriteLine("1 RECEIVED: " + Player1_Messages.Count);

        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            OutputList1.Items.Clear();
            foreach (String item in Player1_Messages)
            {
                OutputList1.Items.Add(item);
            }
            OutputList2.Items.Clear();
            foreach (String item in Player2_Messages)
            {
                OutputList2.Items.Add(item);
            }
            OutputList3.Items.Clear();
            foreach (String item in Player3_Messages)
            {
                OutputList3.Items.Add(item);
            }
            OutputList4.Items.Clear();
            foreach (String item in Player4_Messages)
            {
                OutputList4.Items.Add(item);
            }
        }

        private void DeviceScan()
        {

            var enumerator = new MMDeviceEnumerator();
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {

                String info = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)[i].ToString();
                Console.Write(i + ":OUT: " + info);
                Console.WriteLine(info);
                Tuple<int, String> toAdd = new Tuple<int, String>(i, info);
                PlayBackDevices.Add(toAdd);


            }
            enumerator.Dispose();

            enumerator = new MMDeviceEnumerator();
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                String info = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)[i].ToString();
                Console.Write(i + ":REC: " + info);
                Console.WriteLine(info);
                Tuple<int, String> toAdd = new Tuple<int, String>(i, info);
                RecordingDevices.Add(toAdd);
            }

            enumerator.Dispose();


            foreach (var device in PlayBackDevices)
            {
                OutputCombobox1.Items.Add(device);
                OutputCombobox2.Items.Add(device);
                OutputCombobox3.Items.Add(device);
                OutputCombobox4.Items.Add(device);
            }
            foreach (var device in RecordingDevices)
            {
                InputCombobox1.Items.Add(device);
                InputCombobox2.Items.Add(device);
                InputCombobox3.Items.Add(device);
                InputCombobox4.Items.Add(device);
            }

        }

        private void PreviousButton1_Click(object sender, EventArgs e)
        {
            Rec1.playLast();
        }

        private void RecordButton1_Click(object sender, EventArgs e)
        {
            Rec1.record();
        }

        private void RecordButton2_Click(object sender, EventArgs e)
        {
            Rec2.record();
        }

        private void PreviousButton2_Click(object sender, EventArgs e)
        {
            Rec2.playLast();
        }
        private void RecordButton3_Click(object sender, EventArgs e)
        {
            Rec3.record();
        }

        private void PreviousButton3_Click(object sender, EventArgs e)
        {
            Rec3.playLast();
        }

        private void RecordButton4_Click(object sender, EventArgs e)
        {
            Rec4.record();
        }

        private void PreviousButton4_Click(object sender, EventArgs e)
        {
            Rec4.playLast();
        }



        private void InputCombobox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Rec1.setInputNumber(InputCombobox1.SelectedIndex);
        }

        private void OutputCombobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec1.setOutputNumber(OutputCombobox1.SelectedIndex);
        }

        private void OutputCombobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec2.setOutputNumber(OutputCombobox2.SelectedIndex);
        }

        private void InputCombobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec2.setInputNumber(InputCombobox2.SelectedIndex);
        }

        private void InputCombobox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec3.setInputNumber(InputCombobox3.SelectedIndex);
        }

        private void OutputCombobox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec3.setOutputNumber(OutputCombobox3.SelectedIndex);
        }

        private void InputCombobox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec4.setInputNumber(InputCombobox4.SelectedIndex);
        }

        private void OutputCombobox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rec4.setOutputNumber(OutputCombobox4.SelectedIndex);
        }

        private void RandomButton1_Click(object sender, EventArgs e)
        {
            Rec1.playRandom();
        }

        private void RandomButton2_Click(object sender, EventArgs e)
        {
            Rec2.playRandom();
        }

        private void RandomButton3_Click(object sender, EventArgs e)
        {
            Rec3.playRandom();
        }

        private void RandomButton4_Click(object sender, EventArgs e)
        {
            Rec4.playRandom();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
            switch (e.KeyChar)
            {
                case 'q':
                    Rec1.record();
                    break;
                case 'w':
                    Rec1.playLast();
                    break;
                case 'e':
                    Rec1.playRandom();
                    break;
                case 'a':
                    Rec2.record();
                    break;
                case 's':
                    Rec2.playLast();
                    break;
                case 'd':
                    Rec2.playRandom();
                    break;
                case 'y':
                    Rec3.record();
                    break;
                case 'x':
                   Rec3.playLast();
                    break;
                case 'c':
                    Rec3.playRandom();
                    break;
                case 'r':
                    Rec4.record();
                    break;
                case 't':
                    Rec4.playLast();
                    break;
                case 'z':
                    Rec4.playRandom();
                    break;



                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}
