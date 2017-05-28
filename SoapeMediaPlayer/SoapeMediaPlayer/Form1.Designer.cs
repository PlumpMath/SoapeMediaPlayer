namespace SoapeMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VLCPlayer = new AxAXVLC.AxVLCPlugin2();
            this.button_play = new System.Windows.Forms.Button();
            this.button_load_playlist = new System.Windows.Forms.Button();
            this.button_skip = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_load_video = new System.Windows.Forms.Button();
            this.lv_playlist = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VLCPlayer
            // 
            this.VLCPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VLCPlayer.Enabled = true;
            this.VLCPlayer.Location = new System.Drawing.Point(13, 13);
            this.VLCPlayer.Name = "VLCPlayer";
            this.VLCPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VLCPlayer.OcxState")));
            this.VLCPlayer.Size = new System.Drawing.Size(551, 342);
            this.VLCPlayer.TabIndex = 0;
            // 
            // button_play
            // 
            this.button_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.Location = new System.Drawing.Point(231, 371);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(47, 42);
            this.button_play.TabIndex = 6;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_load_playlist
            // 
            this.button_load_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_load_playlist.Image = ((System.Drawing.Image)(resources.GetObject("button_load_playlist.Image")));
            this.button_load_playlist.Location = new System.Drawing.Point(125, 371);
            this.button_load_playlist.Name = "button_load_playlist";
            this.button_load_playlist.Size = new System.Drawing.Size(47, 42);
            this.button_load_playlist.TabIndex = 7;
            this.button_load_playlist.UseVisualStyleBackColor = true;
            this.button_load_playlist.Click += new System.EventHandler(this.button_load_playlist_Click);
            // 
            // button_skip
            // 
            this.button_skip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_skip.Image = ((System.Drawing.Image)(resources.GetObject("button_skip.Image")));
            this.button_skip.Location = new System.Drawing.Point(390, 371);
            this.button_skip.Name = "button_skip";
            this.button_skip.Size = new System.Drawing.Size(47, 42);
            this.button_skip.TabIndex = 8;
            this.button_skip.UseVisualStyleBackColor = true;
            this.button_skip.Click += new System.EventHandler(this.button_skip_Click);
            // 
            // button_stop
            // 
            this.button_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_stop.Image")));
            this.button_stop.Location = new System.Drawing.Point(337, 371);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(47, 42);
            this.button_stop.TabIndex = 9;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_pause
            // 
            this.button_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_pause.Image = ((System.Drawing.Image)(resources.GetObject("button_pause.Image")));
            this.button_pause.Location = new System.Drawing.Point(284, 371);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(47, 42);
            this.button_pause.TabIndex = 10;
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_load_video
            // 
            this.button_load_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_load_video.Image = ((System.Drawing.Image)(resources.GetObject("button_load_video.Image")));
            this.button_load_video.Location = new System.Drawing.Point(178, 371);
            this.button_load_video.Name = "button_load_video";
            this.button_load_video.Size = new System.Drawing.Size(47, 42);
            this.button_load_video.TabIndex = 11;
            this.button_load_video.UseVisualStyleBackColor = true;
            this.button_load_video.Click += new System.EventHandler(this.button_load_video_Click);
            // 
            // lv_playlist
            // 
            this.lv_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_playlist.Location = new System.Drawing.Point(570, 42);
            this.lv_playlist.Name = "lv_playlist";
            this.lv_playlist.Size = new System.Drawing.Size(179, 313);
            this.lv_playlist.TabIndex = 12;
            this.lv_playlist.UseCompatibleStateImageBehavior = false;
            this.lv_playlist.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Playlist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_playlist);
            this.Controls.Add(this.button_load_video);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_skip);
            this.Controls.Add(this.button_load_playlist);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.VLCPlayer);
            this.Name = "Form1";
            this.Text = "Soape\'s Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 VLCPlayer;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_load_playlist;
        private System.Windows.Forms.Button button_skip;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_load_video;
        private System.Windows.Forms.ListView lv_playlist;
        private System.Windows.Forms.Label label1;
    }
}

