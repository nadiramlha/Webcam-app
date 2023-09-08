﻿namespace Webcam
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
            comboBoxWebcam = new ComboBox();
            startbutton = new Button();
            capturebutton = new Button();
            saveimagebutton = new Button();
            exitbutton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcam
            // 
            comboBoxWebcam.FormattingEnabled = true;
            comboBoxWebcam.Location = new Point(13, 17);
            comboBoxWebcam.Margin = new Padding(4, 5, 4, 5);
            comboBoxWebcam.Name = "comboBoxWebcam";
            comboBoxWebcam.Size = new Size(200, 33);
            comboBoxWebcam.TabIndex = 0;
            comboBoxWebcam.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // startbutton
            // 
            startbutton.Location = new Point(221, 17);
            startbutton.Margin = new Padding(4, 5, 4, 5);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(108, 38);
            startbutton.TabIndex = 1;
            startbutton.Text = "start";
            startbutton.UseVisualStyleBackColor = true;
            startbutton.Click += startbutton_Click;
            // 
            // capturebutton
            // 
            capturebutton.Location = new Point(337, 17);
            capturebutton.Margin = new Padding(4, 5, 4, 5);
            capturebutton.Name = "capturebutton";
            capturebutton.Size = new Size(108, 38);
            capturebutton.TabIndex = 2;
            capturebutton.Text = "capture";
            capturebutton.UseVisualStyleBackColor = true;
            capturebutton.Click += capturebutton_Click;
            // 
            // saveimagebutton
            // 
            saveimagebutton.Location = new Point(453, 17);
            saveimagebutton.Margin = new Padding(4, 5, 4, 5);
            saveimagebutton.Name = "saveimagebutton";
            saveimagebutton.Size = new Size(137, 38);
            saveimagebutton.TabIndex = 3;
            saveimagebutton.Text = "save image";
            saveimagebutton.UseVisualStyleBackColor = true;
            saveimagebutton.Click += saveimagebutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(994, 15);
            exitbutton.Margin = new Padding(4, 5, 4, 5);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(81, 38);
            exitbutton.TabIndex = 4;
            exitbutton.Text = "exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(13, 65);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1063, 690);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 680);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(535, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(524, 680);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 775);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(exitbutton);
            Controls.Add(saveimagebutton);
            Controls.Add(capturebutton);
            Controls.Add(startbutton);
            Controls.Add(comboBoxWebcam);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebcam;
        private Button startbutton;
        private Button capturebutton;
        private Button saveimagebutton;
        private Button exitbutton;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}