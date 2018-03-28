namespace ImageEditorCSharp
{
    partial class ZMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.labB = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.labG = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackG = new System.Windows.Forms.TrackBar();
            this.labR = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackR = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(513, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.DarkGray;
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture1.Location = new System.Drawing.Point(229, 93);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(264, 195);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 1;
            this.picture1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(229, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(364, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save As";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|GIF|.*gif|BMP|*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|GIF|.*gif|BMP|*.bmp";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(10, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Grayscale";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(10, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "©Zahid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(10, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Blur ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Indigo;
            this.trackBar1.Location = new System.Drawing.Point(99, 373);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(375, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(480, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Indigo;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(10, 407);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "Brightness";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Indigo;
            this.trackBar2.Location = new System.Drawing.Point(99, 407);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(375, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(10, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 37);
            this.button6.TabIndex = 12;
            this.button6.Text = "Invert";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Indigo;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(10, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 40);
            this.button7.TabIndex = 13;
            this.button7.Text = "Contrast";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(480, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.Color.Indigo;
            this.trackBar3.Location = new System.Drawing.Point(99, 436);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(375, 45);
            this.trackBar3.TabIndex = 14;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(480, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "1";
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.Color.Indigo;
            this.trackBar4.Location = new System.Drawing.Point(99, 468);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(375, 45);
            this.trackBar4.TabIndex = 17;
            this.trackBar4.TickFrequency = 5;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Indigo;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Location = new System.Drawing.Point(10, 468);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 16;
            this.button8.Text = "Gamma";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Maroon;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button9.Location = new System.Drawing.Point(364, 311);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 42);
            this.button9.TabIndex = 19;
            this.button9.Text = "Rotate Right";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(229, 311);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 42);
            this.button10.TabIndex = 20;
            this.button10.Text = "Rotate Left";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.MediumBlue;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button11.Location = new System.Drawing.Point(9, 110);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(214, 37);
            this.button11.TabIndex = 21;
            this.button11.Text = "Sepia";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.labB);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.trackB);
            this.panel2.Controls.Add(this.labG);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.trackG);
            this.panel2.Controls.Add(this.labR);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.trackR);
            this.panel2.Location = new System.Drawing.Point(9, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 199);
            this.panel2.TabIndex = 27;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 28;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.BackColor = System.Drawing.Color.Transparent;
            this.labB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labB.Location = new System.Drawing.Point(162, 3);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(16, 16);
            this.labB.TabIndex = 8;
            this.labB.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(153, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "BULE";
            // 
            // trackB
            // 
            this.trackB.BackColor = System.Drawing.Color.Blue;
            this.trackB.Location = new System.Drawing.Point(148, 19);
            this.trackB.Maximum = 255;
            this.trackB.Minimum = 1;
            this.trackB.Name = "trackB";
            this.trackB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackB.Size = new System.Drawing.Size(45, 158);
            this.trackB.TabIndex = 6;
            this.trackB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackB.Value = 1;
            this.trackB.Scroll += new System.EventHandler(this.trackB_Scroll);
            // 
            // labG
            // 
            this.labG.AutoSize = true;
            this.labG.BackColor = System.Drawing.Color.Transparent;
            this.labG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labG.Location = new System.Drawing.Point(94, 3);
            this.labG.Name = "labG";
            this.labG.Size = new System.Drawing.Size(16, 16);
            this.labG.TabIndex = 5;
            this.labG.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(79, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = " GREEN";
            // 
            // trackG
            // 
            this.trackG.BackColor = System.Drawing.Color.Green;
            this.trackG.Location = new System.Drawing.Point(81, 19);
            this.trackG.Maximum = 255;
            this.trackG.Minimum = 1;
            this.trackG.Name = "trackG";
            this.trackG.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackG.Size = new System.Drawing.Size(45, 158);
            this.trackG.TabIndex = 3;
            this.trackG.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackG.Value = 1;
            this.trackG.Scroll += new System.EventHandler(this.trackG_Scroll);
            // 
            // labR
            // 
            this.labR.AutoSize = true;
            this.labR.BackColor = System.Drawing.Color.Transparent;
            this.labR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labR.Location = new System.Drawing.Point(32, 3);
            this.labR.Name = "labR";
            this.labR.Size = new System.Drawing.Size(16, 16);
            this.labR.TabIndex = 2;
            this.labR.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(26, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "RED";
            // 
            // trackR
            // 
            this.trackR.BackColor = System.Drawing.Color.Red;
            this.trackR.Location = new System.Drawing.Point(19, 19);
            this.trackR.Maximum = 255;
            this.trackR.Minimum = 1;
            this.trackR.Name = "trackR";
            this.trackR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackR.Size = new System.Drawing.Size(45, 158);
            this.trackR.TabIndex = 0;
            this.trackR.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackR.Value = 1;
            this.trackR.Scroll += new System.EventHandler(this.trackR_Scroll);
            // 
            // ZMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZMain";
            this.Text = "Image Editor Using C# -- Digital Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.Label labG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackG;
        private System.Windows.Forms.Label labR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackR;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

