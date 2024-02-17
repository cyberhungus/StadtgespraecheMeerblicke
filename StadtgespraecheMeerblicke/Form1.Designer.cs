namespace StadtgespraecheMeerblicke
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Station1Status = new Label();
            RecordingProgressBar1 = new ProgressBar();
            PlaybackDeviceLabel1 = new Label();
            RecordLabel1 = new Label();
            OutputCombobox1 = new ComboBox();
            OutputList1 = new ListBox();
            TopLabel1 = new Label();
            RandomButton1 = new Button();
            PreviousButton1 = new Button();
            RecordButton1 = new Button();
            InputCombobox1 = new ComboBox();
            UI_Timer = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            Station2Status = new Label();
            RecordingProgressBar2 = new ProgressBar();
            label1 = new Label();
            label5 = new Label();
            OutputCombobox2 = new ComboBox();
            OutputList2 = new ListBox();
            label6 = new Label();
            RandomButton2 = new Button();
            PreviousButton2 = new Button();
            RecordButton2 = new Button();
            InputCombobox2 = new ComboBox();
            panel6 = new Panel();
            Station3Status = new Label();
            RecordingProgressBar3 = new ProgressBar();
            label7 = new Label();
            label8 = new Label();
            OutputCombobox3 = new ComboBox();
            OutputList3 = new ListBox();
            label9 = new Label();
            RandomButton3 = new Button();
            PreviousButton3 = new Button();
            RecordButton3 = new Button();
            InputCombobox3 = new ComboBox();
            panel2 = new Panel();
            Station4Status = new Label();
            RecordingProgressBar4 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            OutputCombobox4 = new ComboBox();
            OutputList4 = new ListBox();
            label4 = new Label();
            RandomButton4 = new Button();
            PreviousButton4 = new Button();
            RecordButton4 = new Button();
            InputCombobox4 = new ComboBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Station1Status);
            panel1.Controls.Add(RecordingProgressBar1);
            panel1.Controls.Add(PlaybackDeviceLabel1);
            panel1.Controls.Add(RecordLabel1);
            panel1.Controls.Add(OutputCombobox1);
            panel1.Controls.Add(OutputList1);
            panel1.Controls.Add(TopLabel1);
            panel1.Controls.Add(RandomButton1);
            panel1.Controls.Add(PreviousButton1);
            panel1.Controls.Add(RecordButton1);
            panel1.Controls.Add(InputCombobox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 426);
            panel1.TabIndex = 0;
            // 
            // Station1Status
            // 
            Station1Status.AutoSize = true;
            Station1Status.Location = new Point(3, 113);
            Station1Status.Name = "Station1Status";
            Station1Status.Size = new Size(39, 15);
            Station1Status.TabIndex = 9;
            Station1Status.Text = "Status";
            // 
            // RecordingProgressBar1
            // 
            RecordingProgressBar1.Location = new Point(3, 159);
            RecordingProgressBar1.Name = "RecordingProgressBar1";
            RecordingProgressBar1.Size = new Size(192, 23);
            RecordingProgressBar1.TabIndex = 1;
            // 
            // PlaybackDeviceLabel1
            // 
            PlaybackDeviceLabel1.AutoSize = true;
            PlaybackDeviceLabel1.Location = new Point(4, 71);
            PlaybackDeviceLabel1.Name = "PlaybackDeviceLabel1";
            PlaybackDeviceLabel1.Size = new Size(83, 15);
            PlaybackDeviceLabel1.TabIndex = 8;
            PlaybackDeviceLabel1.Text = "Output Device";
            // 
            // RecordLabel1
            // 
            RecordLabel1.AutoSize = true;
            RecordLabel1.Location = new Point(4, 24);
            RecordLabel1.Name = "RecordLabel1";
            RecordLabel1.Size = new Size(99, 15);
            RecordLabel1.TabIndex = 7;
            RecordLabel1.Text = "Recording Device";
            // 
            // OutputCombobox1
            // 
            OutputCombobox1.DropDownStyle = ComboBoxStyle.DropDownList;
            OutputCombobox1.FormattingEnabled = true;
            OutputCombobox1.Location = new Point(4, 89);
            OutputCombobox1.Name = "OutputCombobox1";
            OutputCombobox1.Size = new Size(192, 23);
            OutputCombobox1.TabIndex = 6;
            OutputCombobox1.SelectedIndexChanged += OutputCombobox1_SelectedIndexChanged;
            // 
            // OutputList1
            // 
            OutputList1.FormattingEnabled = true;
            OutputList1.ItemHeight = 15;
            OutputList1.Location = new Point(4, 247);
            OutputList1.Name = "OutputList1";
            OutputList1.Size = new Size(191, 169);
            OutputList1.TabIndex = 5;
            // 
            // TopLabel1
            // 
            TopLabel1.AutoSize = true;
            TopLabel1.Location = new Point(3, 0);
            TopLabel1.Name = "TopLabel1";
            TopLabel1.Size = new Size(53, 15);
            TopLabel1.TabIndex = 4;
            TopLabel1.Text = "Station 1";
            // 
            // RandomButton1
            // 
            RandomButton1.BackColor = SystemColors.ControlLightLight;
            RandomButton1.ForeColor = SystemColors.ControlText;
            RandomButton1.Location = new Point(4, 217);
            RandomButton1.Name = "RandomButton1";
            RandomButton1.Size = new Size(191, 23);
            RandomButton1.TabIndex = 3;
            RandomButton1.Text = "Playback Random";
            RandomButton1.UseVisualStyleBackColor = false;
            RandomButton1.Click += RandomButton1_Click;
            // 
            // PreviousButton1
            // 
            PreviousButton1.ForeColor = SystemColors.ControlText;
            PreviousButton1.Location = new Point(4, 188);
            PreviousButton1.Name = "PreviousButton1";
            PreviousButton1.Size = new Size(191, 23);
            PreviousButton1.TabIndex = 2;
            PreviousButton1.Text = "Playback Previous";
            PreviousButton1.UseVisualStyleBackColor = true;
            PreviousButton1.Click += PreviousButton1_Click;
            // 
            // RecordButton1
            // 
            RecordButton1.ForeColor = SystemColors.ControlText;
            RecordButton1.Location = new Point(3, 131);
            RecordButton1.Name = "RecordButton1";
            RecordButton1.Size = new Size(191, 23);
            RecordButton1.TabIndex = 1;
            RecordButton1.Text = "Record";
            RecordButton1.UseVisualStyleBackColor = true;
            RecordButton1.Click += RecordButton1_Click;
            // 
            // InputCombobox1
            // 
            InputCombobox1.DropDownStyle = ComboBoxStyle.DropDownList;
            InputCombobox1.FormattingEnabled = true;
            InputCombobox1.Location = new Point(3, 42);
            InputCombobox1.Name = "InputCombobox1";
            InputCombobox1.Size = new Size(192, 23);
            InputCombobox1.TabIndex = 0;
            InputCombobox1.SelectedIndexChanged += InputCombobox1_SelectedIndexChanged;
            // 
            // UI_Timer
            // 
            UI_Timer.Enabled = true;
            UI_Timer.Tick += UI_Timer_Tick;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(Station2Status);
            panel5.Controls.Add(RecordingProgressBar2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(OutputCombobox2);
            panel5.Controls.Add(OutputList2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(RandomButton2);
            panel5.Controls.Add(PreviousButton2);
            panel5.Controls.Add(RecordButton2);
            panel5.Controls.Add(InputCombobox2);
            panel5.Location = new Point(218, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 426);
            panel5.TabIndex = 9;
            // 
            // Station2Status
            // 
            Station2Status.AutoSize = true;
            Station2Status.Location = new Point(4, 115);
            Station2Status.Name = "Station2Status";
            Station2Status.Size = new Size(39, 15);
            Station2Status.TabIndex = 9;
            Station2Status.Text = "Status";
            // 
            // RecordingProgressBar2
            // 
            RecordingProgressBar2.Location = new Point(3, 159);
            RecordingProgressBar2.Name = "RecordingProgressBar2";
            RecordingProgressBar2.Size = new Size(192, 23);
            RecordingProgressBar2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 71);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 8;
            label1.Text = "Output Device";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 24);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 7;
            label5.Text = "Recording Device";
            // 
            // OutputCombobox2
            // 
            OutputCombobox2.DropDownStyle = ComboBoxStyle.DropDownList;
            OutputCombobox2.FormattingEnabled = true;
            OutputCombobox2.Location = new Point(4, 89);
            OutputCombobox2.Name = "OutputCombobox2";
            OutputCombobox2.Size = new Size(192, 23);
            OutputCombobox2.TabIndex = 6;
            OutputCombobox2.SelectedIndexChanged += OutputCombobox2_SelectedIndexChanged;
            // 
            // OutputList2
            // 
            OutputList2.FormattingEnabled = true;
            OutputList2.ItemHeight = 15;
            OutputList2.Location = new Point(4, 247);
            OutputList2.Name = "OutputList2";
            OutputList2.Size = new Size(191, 169);
            OutputList2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 4;
            label6.Text = "Station 2";
            // 
            // RandomButton2
            // 
            RandomButton2.BackColor = SystemColors.ControlLightLight;
            RandomButton2.ForeColor = SystemColors.ControlText;
            RandomButton2.Location = new Point(4, 217);
            RandomButton2.Name = "RandomButton2";
            RandomButton2.Size = new Size(191, 23);
            RandomButton2.TabIndex = 3;
            RandomButton2.Text = "Playback Random";
            RandomButton2.UseVisualStyleBackColor = false;
            RandomButton2.Click += RandomButton2_Click;
            // 
            // PreviousButton2
            // 
            PreviousButton2.ForeColor = SystemColors.ControlText;
            PreviousButton2.Location = new Point(4, 188);
            PreviousButton2.Name = "PreviousButton2";
            PreviousButton2.Size = new Size(191, 23);
            PreviousButton2.TabIndex = 2;
            PreviousButton2.Text = "Playback Previous";
            PreviousButton2.UseVisualStyleBackColor = true;
            PreviousButton2.Click += PreviousButton2_Click;
            // 
            // RecordButton2
            // 
            RecordButton2.ForeColor = SystemColors.ControlText;
            RecordButton2.Location = new Point(3, 131);
            RecordButton2.Name = "RecordButton2";
            RecordButton2.Size = new Size(191, 23);
            RecordButton2.TabIndex = 1;
            RecordButton2.Text = "Record";
            RecordButton2.UseVisualStyleBackColor = true;
            RecordButton2.Click += RecordButton2_Click;
            // 
            // InputCombobox2
            // 
            InputCombobox2.DropDownStyle = ComboBoxStyle.DropDownList;
            InputCombobox2.FormattingEnabled = true;
            InputCombobox2.Location = new Point(3, 42);
            InputCombobox2.Name = "InputCombobox2";
            InputCombobox2.Size = new Size(192, 23);
            InputCombobox2.TabIndex = 0;
            InputCombobox2.SelectedIndexChanged += InputCombobox2_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(Station3Status);
            panel6.Controls.Add(RecordingProgressBar3);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(OutputCombobox3);
            panel6.Controls.Add(OutputList3);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(RandomButton3);
            panel6.Controls.Add(PreviousButton3);
            panel6.Controls.Add(RecordButton3);
            panel6.Controls.Add(InputCombobox3);
            panel6.Location = new Point(424, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 426);
            panel6.TabIndex = 10;
            // 
            // Station3Status
            // 
            Station3Status.AutoSize = true;
            Station3Status.Location = new Point(4, 113);
            Station3Status.Name = "Station3Status";
            Station3Status.Size = new Size(39, 15);
            Station3Status.TabIndex = 9;
            Station3Status.Text = "Status";
            // 
            // RecordingProgressBar3
            // 
            RecordingProgressBar3.Location = new Point(3, 159);
            RecordingProgressBar3.Name = "RecordingProgressBar3";
            RecordingProgressBar3.Size = new Size(192, 23);
            RecordingProgressBar3.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 71);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 8;
            label7.Text = "Output Device";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 24);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 7;
            label8.Text = "Recording Device";
            // 
            // OutputCombobox3
            // 
            OutputCombobox3.DropDownStyle = ComboBoxStyle.DropDownList;
            OutputCombobox3.FormattingEnabled = true;
            OutputCombobox3.Location = new Point(4, 89);
            OutputCombobox3.Name = "OutputCombobox3";
            OutputCombobox3.Size = new Size(192, 23);
            OutputCombobox3.TabIndex = 6;
            OutputCombobox3.SelectedIndexChanged += OutputCombobox3_SelectedIndexChanged;
            // 
            // OutputList3
            // 
            OutputList3.FormattingEnabled = true;
            OutputList3.ItemHeight = 15;
            OutputList3.Location = new Point(4, 247);
            OutputList3.Name = "OutputList3";
            OutputList3.Size = new Size(191, 169);
            OutputList3.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 4;
            label9.Text = "Station 3";
            // 
            // RandomButton3
            // 
            RandomButton3.BackColor = SystemColors.ControlLightLight;
            RandomButton3.ForeColor = SystemColors.ControlText;
            RandomButton3.Location = new Point(4, 217);
            RandomButton3.Name = "RandomButton3";
            RandomButton3.Size = new Size(191, 23);
            RandomButton3.TabIndex = 3;
            RandomButton3.Text = "Playback Random";
            RandomButton3.UseVisualStyleBackColor = false;
            RandomButton3.Click += RandomButton3_Click;
            // 
            // PreviousButton3
            // 
            PreviousButton3.ForeColor = SystemColors.ControlText;
            PreviousButton3.Location = new Point(4, 188);
            PreviousButton3.Name = "PreviousButton3";
            PreviousButton3.Size = new Size(191, 23);
            PreviousButton3.TabIndex = 2;
            PreviousButton3.Text = "Playback Previous";
            PreviousButton3.UseVisualStyleBackColor = true;
            PreviousButton3.Click += PreviousButton3_Click;
            // 
            // RecordButton3
            // 
            RecordButton3.ForeColor = SystemColors.ControlText;
            RecordButton3.Location = new Point(4, 131);
            RecordButton3.Name = "RecordButton3";
            RecordButton3.Size = new Size(191, 23);
            RecordButton3.TabIndex = 1;
            RecordButton3.Text = "Record";
            RecordButton3.UseVisualStyleBackColor = true;
            RecordButton3.Click += RecordButton3_Click;
            // 
            // InputCombobox3
            // 
            InputCombobox3.DropDownStyle = ComboBoxStyle.DropDownList;
            InputCombobox3.FormattingEnabled = true;
            InputCombobox3.Location = new Point(3, 42);
            InputCombobox3.Name = "InputCombobox3";
            InputCombobox3.Size = new Size(192, 23);
            InputCombobox3.TabIndex = 0;
            InputCombobox3.SelectedIndexChanged += InputCombobox3_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Station4Status);
            panel2.Controls.Add(RecordingProgressBar4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(OutputCombobox4);
            panel2.Controls.Add(OutputList4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(RandomButton4);
            panel2.Controls.Add(PreviousButton4);
            panel2.Controls.Add(RecordButton4);
            panel2.Controls.Add(InputCombobox4);
            panel2.Location = new Point(630, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 426);
            panel2.TabIndex = 11;
            // 
            // Station4Status
            // 
            Station4Status.AutoSize = true;
            Station4Status.Location = new Point(4, 112);
            Station4Status.Name = "Station4Status";
            Station4Status.Size = new Size(39, 15);
            Station4Status.TabIndex = 9;
            Station4Status.Text = "Status";
            // 
            // RecordingProgressBar4
            // 
            RecordingProgressBar4.Location = new Point(3, 159);
            RecordingProgressBar4.Name = "RecordingProgressBar4";
            RecordingProgressBar4.Size = new Size(192, 23);
            RecordingProgressBar4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 71);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Output Device";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 24);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Recording Device";
            // 
            // OutputCombobox4
            // 
            OutputCombobox4.DropDownStyle = ComboBoxStyle.DropDownList;
            OutputCombobox4.FormattingEnabled = true;
            OutputCombobox4.Location = new Point(4, 89);
            OutputCombobox4.Name = "OutputCombobox4";
            OutputCombobox4.Size = new Size(192, 23);
            OutputCombobox4.TabIndex = 6;
            OutputCombobox4.SelectedIndexChanged += OutputCombobox4_SelectedIndexChanged;
            // 
            // OutputList4
            // 
            OutputList4.FormattingEnabled = true;
            OutputList4.ItemHeight = 15;
            OutputList4.Location = new Point(4, 247);
            OutputList4.Name = "OutputList4";
            OutputList4.Size = new Size(191, 169);
            OutputList4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Station 4";
            // 
            // RandomButton4
            // 
            RandomButton4.BackColor = SystemColors.ControlLightLight;
            RandomButton4.ForeColor = SystemColors.ControlText;
            RandomButton4.Location = new Point(4, 217);
            RandomButton4.Name = "RandomButton4";
            RandomButton4.Size = new Size(191, 23);
            RandomButton4.TabIndex = 3;
            RandomButton4.Text = "Playback Random";
            RandomButton4.UseVisualStyleBackColor = false;
            RandomButton4.Click += RandomButton4_Click;
            // 
            // PreviousButton4
            // 
            PreviousButton4.ForeColor = SystemColors.ControlText;
            PreviousButton4.Location = new Point(4, 188);
            PreviousButton4.Name = "PreviousButton4";
            PreviousButton4.Size = new Size(191, 23);
            PreviousButton4.TabIndex = 2;
            PreviousButton4.Text = "Playback Previous";
            PreviousButton4.UseVisualStyleBackColor = true;
            PreviousButton4.Click += PreviousButton4_Click;
            // 
            // RecordButton4
            // 
            RecordButton4.ForeColor = SystemColors.ControlText;
            RecordButton4.Location = new Point(4, 130);
            RecordButton4.Name = "RecordButton4";
            RecordButton4.Size = new Size(191, 23);
            RecordButton4.TabIndex = 1;
            RecordButton4.Text = "Record";
            RecordButton4.UseVisualStyleBackColor = true;
            RecordButton4.Click += RecordButton4_Click;
            // 
            // InputCombobox4
            // 
            InputCombobox4.DropDownStyle = ComboBoxStyle.DropDownList;
            InputCombobox4.FormattingEnabled = true;
            InputCombobox4.Location = new Point(3, 42);
            InputCombobox4.Name = "InputCombobox4";
            InputCombobox4.Size = new Size(192, 23);
            InputCombobox4.TabIndex = 0;
            InputCombobox4.SelectedIndexChanged += InputCombobox4_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 450);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Stadtgesp.";
            KeyPress += Form1_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button PreviousButton1;
        private Button RecordButton1;
        private ComboBox InputCombobox1;
        private Button RandomButton1;
        private ListBox OutputList1;
        private Label TopLabel1;
        private Panel panel2;
        private ListBox listBox2;
        private Label label2;
        private Button RandomButton4;
        private Button PreviousButton4;
        private Button RecordButton4;
        private ComboBox OutputCombobox1;
        private Panel panel3;
        private ListBox listBox3;
        private Label label3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBox3;
        private Panel panel4;
        private ListBox listBox4;
        private Label label4;
        private Button button7;
        private Button button8;
        private Button button9;
        private ComboBox comboBox4;
        private ProgressBar RecordingProgressBar1;
        private Label PlaybackDeviceLabel1;
        private Label RecordLabel1;
        private System.Windows.Forms.Timer UI_Timer;
        private Panel panel5;
        private ProgressBar RecordingProgressBar2;
        private Label label1;
        private Label label5;
        private ComboBox OutputCombobox2;
        private ListBox OutputList2;
        private Label label6;
        private Button RandomButton2;
        private Button PreviousButton2;
        private Button RecordButton2;
        private ComboBox InputCombobox2;
        private Panel panel6;
        private ProgressBar RecordingProgressBar3;
        private Label label7;
        private Label label8;
        private ComboBox OutputCombobox3;
        private ListBox OutputList3;
        private Label label9;
        private Button RandomButton3;
        private Button PreviousButton3;
        private Button RecordButton3;
        private ComboBox InputCombobox3;
        private ProgressBar RecordingProgressBar4;
        private ComboBox OutputCombobox4;
        private ListBox OutputList4;
        private ComboBox InputCombobox4;
        private Label Station1Status;
        private Label Station2Status;
        private Label Station3Status;
        private Label Station4Status;
    }
}
