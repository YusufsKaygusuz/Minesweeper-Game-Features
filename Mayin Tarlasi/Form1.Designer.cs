
namespace Mayin_Tarlasi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.TimerCountDown = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.ScreenShotBtn = new System.Windows.Forms.Button();
            this.MyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(53, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 413);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WidthTextBox.Location = new System.Drawing.Point(141, 25);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(50, 26);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.Text = "400";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeightTextBox.Location = new System.Drawing.Point(301, 25);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(50, 26);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.Text = "400";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(197, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mines:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(459, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textb_Result_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(122, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelTimeLeft.Location = new System.Drawing.Point(49, 83);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(57, 23);
            this.LabelTimeLeft.TabIndex = 7;
            this.LabelTimeLeft.Text = "Time";
            // 
            // TimerCountDown
            // 
            this.TimerCountDown.Enabled = true;
            this.TimerCountDown.Interval = 1000;
            this.TimerCountDown.Tick += new System.EventHandler(this.TimerCountDown_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 37);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MyPanel
            // 
            this.MyPanel.Controls.Add(this.button2);
            this.MyPanel.Controls.Add(this.panel1);
            this.MyPanel.Controls.Add(this.textBox1);
            this.MyPanel.Controls.Add(this.LabelTimeLeft);
            this.MyPanel.Controls.Add(this.label3);
            this.MyPanel.Controls.Add(this.label2);
            this.MyPanel.Controls.Add(this.HeightTextBox);
            this.MyPanel.Controls.Add(this.label1);
            this.MyPanel.Controls.Add(this.WidthTextBox);
            this.MyPanel.Location = new System.Drawing.Point(58, 12);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(606, 609);
            this.MyPanel.TabIndex = 9;
            // 
            // ScreenShotBtn
            // 
            this.ScreenShotBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScreenShotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScreenShotBtn.BackgroundImage")));
            this.ScreenShotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreenShotBtn.Location = new System.Drawing.Point(574, 627);
            this.ScreenShotBtn.Name = "ScreenShotBtn";
            this.ScreenShotBtn.Size = new System.Drawing.Size(51, 44);
            this.ScreenShotBtn.TabIndex = 10;
            this.ScreenShotBtn.UseVisualStyleBackColor = false;
            this.ScreenShotBtn.Click += new System.EventHandler(this.ScreenShotBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 755);
            this.Controls.Add(this.ScreenShotBtn);
            this.Controls.Add(this.MyPanel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MyPanel.ResumeLayout(false);
            this.MyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Timer TimerCountDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel MyPanel;
        private System.Windows.Forms.Button ScreenShotBtn;
    }
}

