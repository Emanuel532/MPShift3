namespace MPSHIFT3
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
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_time_played = new System.Windows.Forms.Label();
            this.lbl_shuffle = new System.Windows.Forms.Label();
            this.lbl_volume_percentage = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_melodie_terminata = new System.Windows.Forms.Timer(this.components);
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.search_results = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(12, 345);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(111, 31);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Previous";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(243, 345);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(111, 31);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(126, 308);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(111, 31);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(126, 385);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(111, 31);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(126, 345);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(111, 31);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(79, 494);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(204, 31);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(11, 425);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(359, 23);
            this.p_bar.TabIndex = 7;
            this.p_bar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseClick);
            // 
            // track_list
            // 
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(399, 125);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(403, 468);
            this.track_list.TabIndex = 8;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(314, 67);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 180);
            this.track_volume.TabIndex = 11;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(311, 250);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(55, 17);
            this.lbl_volume.TabIndex = 12;
            this.lbl_volume.Text = "Volume";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Location = new System.Drawing.Point(8, 250);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(44, 17);
            this.lbl_track_start.TabIndex = 13;
            this.lbl_track_start.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Location = new System.Drawing.Point(76, 250);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(44, 17);
            this.lbl_track_end.TabIndex = 15;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "|||";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_time_played
            // 
            this.lbl_time_played.AutoSize = true;
            this.lbl_time_played.Location = new System.Drawing.Point(396, 28);
            this.lbl_time_played.Name = "lbl_time_played";
            this.lbl_time_played.Size = new System.Drawing.Size(100, 17);
            this.lbl_time_played.TabIndex = 17;
            this.lbl_time_played.Text = "Timp ascultat: ";
            this.lbl_time_played.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_shuffle
            // 
            this.lbl_shuffle.AutoSize = true;
            this.lbl_shuffle.Location = new System.Drawing.Point(396, 57);
            this.lbl_shuffle.Name = "lbl_shuffle";
            this.lbl_shuffle.Size = new System.Drawing.Size(120, 17);
            this.lbl_shuffle.TabIndex = 18;
            this.lbl_shuffle.Text = "Shuffle play: false";
            this.lbl_shuffle.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_volume_percentage
            // 
            this.lbl_volume_percentage.AutoSize = true;
            this.lbl_volume_percentage.Location = new System.Drawing.Point(311, 47);
            this.lbl_volume_percentage.Name = "lbl_volume_percentage";
            this.lbl_volume_percentage.Size = new System.Drawing.Size(36, 17);
            this.lbl_volume_percentage.TabIndex = 19;
            this.lbl_volume_percentage.Text = "70%";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(810, 10);
            this.player.TabIndex = 10;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // timer_melodie_terminata
            // 
            this.timer_melodie_terminata.Enabled = true;
            this.timer_melodie_terminata.Interval = 1000;
            this.timer_melodie_terminata.Tick += new System.EventHandler(this.timer_melodie_terminata_Tick);
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(399, 87);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(399, 22);
            this.txtbox_search.TabIndex = 20;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // search_results
            // 
            this.search_results.FormattingEnabled = true;
            this.search_results.ItemHeight = 16;
            this.search_results.Location = new System.Drawing.Point(399, 125);
            this.search_results.Name = "search_results";
            this.search_results.Size = new System.Drawing.Size(403, 468);
            this.search_results.TabIndex = 21;
            this.search_results.Visible = false;
            this.search_results.SelectedIndexChanged += new System.EventHandler(this.search_results_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MPSHIFT3.Properties.Resources.bgImg;
            this.pictureBox1.Location = new System.Drawing.Point(11, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 596);
            this.Controls.Add(this.search_results);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.lbl_volume_percentage);
            this.Controls.Add(this.lbl_shuffle);
            this.Controls.Add(this.lbl_time_played);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPSHIFT3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_time_played;
        private System.Windows.Forms.Label lbl_shuffle;
        private System.Windows.Forms.Label lbl_volume_percentage;
        private System.Windows.Forms.Timer timer_melodie_terminata;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.ListBox search_results;
        public AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

