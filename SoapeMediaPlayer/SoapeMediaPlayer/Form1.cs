using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAXVLC;
using System.IO;

namespace SoapeMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Load multiple videos into playlist
        private void button_load_playlist_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Put video paths in array 
                string[] videoPaths = Directory.GetFiles(fbd.SelectedPath);

                // Put video titles in array
                string[] videoTitles = Directory.GetFiles(fbd.SelectedPath).Select(Path.GetFileName).ToArray();

                // Put each video path into VLC playlist
                foreach (string s in videoPaths)
                {
                    VLCPlayer.playlist.add("file:///" + s, null);
                }

                // Put each video title into the playlist display
                foreach (string s in videoTitles)
                {
                    lv_playlist.Items.Add(s);
                }
            }
        }


        // Load single video into playlist
        private void button_load_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Add video to VLC playlist
                VLCPlayer.playlist.add("file:///" + ofd.FileName, ofd.SafeFileName, null);
                // Add video title to playlist display
                lv_playlist.Items.Add(ofd.SafeFileName);
            }
        }


        // Play
        private void button_play_Click(object sender, EventArgs e)
        {
            VLCPlayer.playlist.play();
        }

        // Toggle Pause
        private void button_pause_Click(object sender, EventArgs e)
        {
            VLCPlayer.playlist.togglePause();
        }

        // Stop
        private void button_stop_Click(object sender, EventArgs e)
        {
            VLCPlayer.playlist.stop();
        }

        // Skip to next video in playlist
        private void button_skip_Click(object sender, EventArgs e)
        {
            VLCPlayer.playlist.next();
        }


    }
}
