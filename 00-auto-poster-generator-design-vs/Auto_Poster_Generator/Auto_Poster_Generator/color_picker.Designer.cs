﻿namespace Auto_Poster_Generator
{
    partial class color_picker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.track_blue = new Bunifu.Framework.UI.BunifuTrackbar();
            this.track_green = new Bunifu.Framework.UI.BunifuTrackbar();
            this.track_red = new Bunifu.Framework.UI.BunifuTrackbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rgb_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.rgb_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_blue);
            this.panel1.Controls.Add(this.lbl_green);
            this.panel1.Controls.Add(this.lbl_red);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.track_blue);
            this.panel1.Controls.Add(this.track_green);
            this.panel1.Controls.Add(this.track_red);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 315);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(399, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_blue
            // 
            this.lbl_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.lbl_blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_blue.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_blue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.lbl_blue.Location = new System.Drawing.Point(336, 217);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(64, 28);
            this.lbl_blue.TabIndex = 15;
            this.lbl_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_green
            // 
            this.lbl_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.lbl_green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_green.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.lbl_green.Location = new System.Drawing.Point(336, 169);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(64, 28);
            this.lbl_green.TabIndex = 14;
            this.lbl_green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_red
            // 
            this.lbl_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.lbl_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_red.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.lbl_red.Location = new System.Drawing.Point(336, 121);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(64, 28);
            this.lbl_red.TabIndex = 13;
            this.lbl_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(22, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(22, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "G";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "R";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // track_blue
            // 
            this.track_blue.BackColor = System.Drawing.Color.Transparent;
            this.track_blue.BackgroudColor = System.Drawing.Color.DarkGray;
            this.track_blue.BorderRadius = 0;
            this.track_blue.IndicatorColor = System.Drawing.Color.Blue;
            this.track_blue.Location = new System.Drawing.Point(55, 213);
            this.track_blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_blue.MaximumValue = 255;
            this.track_blue.MinimumValue = 0;
            this.track_blue.Name = "track_blue";
            this.track_blue.Size = new System.Drawing.Size(259, 35);
            this.track_blue.SliderRadius = 0;
            this.track_blue.TabIndex = 3;
            this.track_blue.Value = 0;
            // 
            // track_green
            // 
            this.track_green.BackColor = System.Drawing.Color.Transparent;
            this.track_green.BackgroudColor = System.Drawing.Color.DarkGray;
            this.track_green.BorderRadius = 0;
            this.track_green.IndicatorColor = System.Drawing.Color.Green;
            this.track_green.Location = new System.Drawing.Point(55, 165);
            this.track_green.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_green.MaximumValue = 255;
            this.track_green.MinimumValue = 0;
            this.track_green.Name = "track_green";
            this.track_green.Size = new System.Drawing.Size(259, 35);
            this.track_green.SliderRadius = 0;
            this.track_green.TabIndex = 2;
            this.track_green.Value = 0;
            // 
            // track_red
            // 
            this.track_red.BackColor = System.Drawing.Color.Transparent;
            this.track_red.BackgroudColor = System.Drawing.Color.DarkGray;
            this.track_red.BorderRadius = 0;
            this.track_red.IndicatorColor = System.Drawing.Color.Red;
            this.track_red.Location = new System.Drawing.Point(55, 117);
            this.track_red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_red.MaximumValue = 255;
            this.track_red.MinimumValue = 0;
            this.track_red.Name = "track_red";
            this.track_red.Size = new System.Drawing.Size(259, 35);
            this.track_red.SliderRadius = 0;
            this.track_red.TabIndex = 1;
            this.track_red.Value = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(112, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 67);
            this.panel2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rgb_txtbox
            // 
            this.rgb_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(211)))), ((int)(((byte)(225)))));
            this.rgb_txtbox.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.rgb_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(55)))));
            this.rgb_txtbox.Location = new System.Drawing.Point(127, 272);
            this.rgb_txtbox.Multiline = true;
            this.rgb_txtbox.Name = "rgb_txtbox";
            this.rgb_txtbox.Size = new System.Drawing.Size(162, 26);
            this.rgb_txtbox.TabIndex = 19;
            this.rgb_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // color_picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(443, 327);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "color_picker";
            this.Text = "color_picker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTrackbar track_blue;
        private Bunifu.Framework.UI.BunifuTrackbar track_green;
        private Bunifu.Framework.UI.BunifuTrackbar track_red;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox rgb_txtbox;
    }
}