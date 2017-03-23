using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration;

        public fGame()
        {
            InitializeComponent();
        }        

        void makeMusic()
        {
            if (Victorina.listSongs.Count == 0)
            {
                GamePause();
            }
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.listSongs.Count);
                WinMP.URL = Victorina.listSongs[n];
                GameContinue();
                Victorina.listSongs.RemoveAt(n);
                lblMelodyCnt.Text = Victorina.listSongs.Count.ToString() + " песен";
                progressBar1.Value = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                makeMusic();
                timer1.Start();
            }
            catch { System.Windows.Forms.MessageBox.Show("Не выбран список аудиозаписей!"); }
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            musicDuration = Victorina.musicDuration;
            lblMelodyCnt.Text = Victorina.listSongs.Count.ToString() + " песен";
            progressBar1.Maximum = Victorina.gameDuration;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            lblMusicDuration.Text = System.Convert.ToString(--musicDuration);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GamePause();
            }
            if(musicDuration == 0)
            {
                makeMusic();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GameContinue();
        }

        void GamePause()
        {
            timer1.Stop();
            WinMP.Ctlcontrols.pause();
        }

        void GameContinue()
        {
            timer1.Start();
            WinMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.A)
            {
                GamePause();
                fAnswer fa = new fAnswer();
                fa.lblPlayer.Text = "Игрок 1";
                if (fa.ShowDialog() == DialogResult.Yes)
                {
                    lblCnt1.Text = System.Convert.ToString(System.Convert.ToInt32(lblCnt1.Text) + 1); 
                }
                makeMusic();
            }
            if (e.KeyData == Keys.P)
            {
                GamePause();
                fAnswer fa = new fAnswer();
                fa.lblPlayer.Text = "Игрок 2";
                if (fa.ShowDialog() == DialogResult.Yes)
                {
                    lblCnt2.Text = System.Convert.ToString(System.Convert.ToInt32(lblCnt2.Text) + 1);
                }
                makeMusic();
            }
        }

        private void WinMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart == true)
                if (WinMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WinMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WinMP.currentMedia.duration / 2 - 10);
        }
    }
}
