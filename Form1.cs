using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MPSHIFT3
{
    public partial class Form1 : Form
    {
        public long timePlayed = 0;
        public Form1()
        {
            InitializeComponent();
            //buttonFirst = new ThumbnailToolBarButton(Properties.Resources.first, "First Image");
            track_volume.Value = 69;
        }

        bool shuffle_play = false;
        bool toggle_view = false;
        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex != -1)
            {
                player.URL = paths[track_list.SelectedIndex];
                player.Ctlcontrols.play();
            }
            try
            {
                /*
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
                */
            } catch { }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            if (track_list.SelectedIndex == -1)
                track_list.SelectedIndex = 0;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!shuffle_play)
            {
                if (track_list.SelectedIndex < track_list.Items.Count - 1)
                {
                    track_list.SelectedIndex = track_list.SelectedIndex + 1;
                }
            }
            else
            {
                Random rndSong = new Random();
                track_list.SelectedIndex = rndSong.Next(0, track_list.Items.Count);
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timePlayed++;
                lbl_time_played.Text = "Timp ascultat: " + ((int)(timePlayed/10)).ToString();
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
                //track_volume.Value = (int)player.Ctlcontrols.currentPosition;
               
            }
            try
            {
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            } catch
            {

            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_volume_percentage.Text = track_volume.Value + "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            shuffle_play = !shuffle_play;
            lbl_shuffle.Text = "Shuffle play \t " + shuffle_play.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //button de vazut sau nu optiuni avansate
        private void button1_Click(object sender, EventArgs e)
        {
            if (toggle_view)
            {
                Size = new Size(623, 523);
                toggle_view = !toggle_view;    
            }
            else
            {
                toggle_view = !toggle_view;
                Size = new Size(310, 523);
            }
        
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void p_bar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int procentDeDatSkip = (e.X * 100) / 268;
                int inceputMelodie = 0;
                int lungimeMelodie = (int)(player.Ctlcontrols.currentItem.duration);
                player.Ctlcontrols.currentPosition = procentDeDatSkip * lungimeMelodie / 100;
            } catch { }
        }

        private void timer_melodie_terminata_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                btn_next_Click(sender, e);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                files = ofd.FileNames;
                paths = ofd.FileNames;
                track_list.DataSource = null;
                track_list.Items.Clear();
                for (int i = 0; i < files.Length; i++)
                {
                    string file = Path.GetFileName(files[i]);
                    string ext = Path.GetExtension(file);
                    if(ext == ".mp3") //adaugam doar fisierele mp3
                    track_list.Items.Add(file);
                }
                //btn_open.Enabled = false;
                System.Windows.Forms.MessageBox.Show("Melodiile au fost adaugate cu succes!");
            }
        }


        //NEUTILIZABIL MOMENTAN


    }
}
