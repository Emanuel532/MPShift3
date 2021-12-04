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
            track_volume.Value = 70;
        }
        bool butonDeOpritApasat = false;
        bool shuffle_play = false;
        bool toggle_view = false;
        string[] paths = new string[100001];
        string[] files = new string[100001];
        string FolderPath;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex != -1)
            {
                player.URL = paths[track_list.SelectedIndex];
                player.Ctlcontrols.play();
                //player.currentMedia.
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
            butonDeOpritApasat = true;
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
            try
            {
                //Incarcam fisierele adaugate in playlist anterior
                int counter = 0;
                StreamReader sr = new StreamReader("db.csv");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    files[counter] = line;
                    paths[counter] = line;
                    counter++;
                }

                for (int i = 0; i < files.Length; i++)
                {
                    string file = Path.GetFileName(files[i]);
                    string ext = Path.GetExtension(file);
                    FolderPath = Path.GetDirectoryName(files[0]);
                    if (ext == ".mp3") //adaugam doar fisierele mp3
                        track_list.Items.Add(file);
                }
                sr.Close();
            } catch { }
                
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
                int lungimeMelodie = (int)(player.Ctlcontrols.currentItem.duration);
                player.Ctlcontrols.currentPosition = procentDeDatSkip * lungimeMelodie / 100;
            } catch { }
        }

        private void timer_melodie_terminata_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsStopped && butonDeOpritApasat == false)
            {
                btn_next_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {//inainte de inchidere salvam fisierele deja adaugate in playlist
            try
            {
                StreamWriter sw = new StreamWriter("db.csv");
                for (int i = 0; i < track_list.Items.Count; i++) {
                    sw.WriteLine(paths[i]);
                }
                sw.Close();
            } catch
            {

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

                FolderPath = Path.GetDirectoryName(files[0]);
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

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_search.Text != "")
            {
                search_results.Visible = true;
                search_results.DataSource = null;
                search_results.Items.Clear();
                for (int i =0;i < files.Length; i++)
                {
                    if (files[i] == null)
                        break;
                    //MessageBox.Show();
                    if(files[i].ToUpper().Contains(txtbox_search.Text.ToUpper().Trim()))
                    {
                        string file = Path.GetFileName(files[i]);
                        string ext = Path.GetExtension(file);
                        if (ext == ".mp3") //adaugam doar fisierele mp3
                            search_results.Items.Add(file);
                    }
                }
            }
            else
            {
                search_results.Visible = false;
            }
        }

        private void search_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            player.URL = FolderPath+ "\\" + search_results.SelectedItem.ToString();
            player.Ctlcontrols.play();
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }
        //NEUTILIZABIL MOMENTAN


    }
}
