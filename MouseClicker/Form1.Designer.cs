using System;

namespace MouseClicker
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.durationOfClicks = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clickSpeed = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTotalClicks = new System.Windows.Forms.Label();
            this.timerClickSpeed = new System.Windows.Forms.Timer(this.components);
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.durationOfClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duration (s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // durationOfClicks
            // 
            this.durationOfClicks.Location = new System.Drawing.Point(157, 106);
            this.durationOfClicks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durationOfClicks.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.durationOfClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationOfClicks.Name = "durationOfClicks";
            this.durationOfClicks.Size = new System.Drawing.Size(160, 22);
            this.durationOfClicks.TabIndex = 3;
            this.durationOfClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(377, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 231);
            this.button2.TabIndex = 5;
            this.button2.Text = "Click Area";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Click Speed (ms)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickSpeed
            // 
            this.clickSpeed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.clickSpeed.Location = new System.Drawing.Point(157, 149);
            this.clickSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clickSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.clickSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clickSpeed.Name = "clickSpeed";
            this.clickSpeed.Size = new System.Drawing.Size(160, 22);
            this.clickSpeed.TabIndex = 7;
            this.clickSpeed.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Calculate Clicks";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotalClicks
            // 
            this.lblTotalClicks.AutoSize = true;
            this.lblTotalClicks.Location = new System.Drawing.Point(157, 27);
            this.lblTotalClicks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalClicks.Name = "lblTotalClicks";
            this.lblTotalClicks.Size = new System.Drawing.Size(16, 17);
            this.lblTotalClicks.TabIndex = 9;
            this.lblTotalClicks.Text = "1";
            // 
            // timerClickSpeed
            // 
            this.timerClickSpeed.Interval = 1000;
            this.timerClickSpeed.Tick += new System.EventHandler(this.timerClickSpeed_Tick);
            // 
            // timerDuration
            // 
            this.timerDuration.Interval = 1000;
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 322);
            this.Controls.Add(this.lblTotalClicks);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clickSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.durationOfClicks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Crazy Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.durationOfClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown durationOfClicks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown clickSpeed;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTotalClicks;
        private System.Windows.Forms.Timer timerClickSpeed;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

