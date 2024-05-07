
namespace Login
{
    partial class Splash
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
            this.panelone = new System.Windows.Forms.Panel();
            this.l_count = new System.Windows.Forms.Label();
            this.pb_count = new System.Windows.Forms.ProgressBar();
            this.picturbackground = new System.Windows.Forms.PictureBox();
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.panelone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturbackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelone
            // 
            this.panelone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelone.Controls.Add(this.l_count);
            this.panelone.Controls.Add(this.pb_count);
            this.panelone.Controls.Add(this.picturbackground);
            this.panelone.Location = new System.Drawing.Point(1, -2);
            this.panelone.Name = "panelone";
            this.panelone.Size = new System.Drawing.Size(922, 524);
            this.panelone.TabIndex = 0;
            // 
            // l_count
            // 
            this.l_count.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.l_count.AutoSize = true;
            this.l_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.l_count.Font = new System.Drawing.Font("Tahoma", 20F);
            this.l_count.Location = new System.Drawing.Point(441, 416);
            this.l_count.Name = "l_count";
            this.l_count.Size = new System.Drawing.Size(30, 33);
            this.l_count.TabIndex = 2;
            this.l_count.Text = "0";
            // 
            // pb_count
            // 
            this.pb_count.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_count.Location = new System.Drawing.Point(458, 434);
            this.pb_count.Name = "pb_count";
            this.pb_count.Size = new System.Drawing.Size(10, 10);
            this.pb_count.TabIndex = 1;
            // 
            // picturbackground
            // 
            this.picturbackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturbackground.BackColor = System.Drawing.SystemColors.Menu;
            this.picturbackground.Image = global::Login.Properties.Resources.photo_2024_03_24_23_26_42;
            this.picturbackground.Location = new System.Drawing.Point(0, 3);
            this.picturbackground.Name = "picturbackground";
            this.picturbackground.Size = new System.Drawing.Size(922, 521);
            this.picturbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturbackground.TabIndex = 0;
            this.picturbackground.TabStop = false;
            this.picturbackground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer_count
            // 
            this.timer_count.Enabled = true;
            this.timer_count.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panelone);
            this.Name = "Splash";
            this.Text = "Splash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelone.ResumeLayout(false);
            this.panelone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturbackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelone;
        private System.Windows.Forms.PictureBox picturbackground;
        private System.Windows.Forms.Label l_count;
        private System.Windows.Forms.ProgressBar pb_count;
        private System.Windows.Forms.Timer timer_count;
    }
}