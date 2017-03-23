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

namespace GuessMelody
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = checkBoxRandomStart.Checked;
            Victorina.gameDuration = System.Convert.ToInt32(cbGameDuration.Text);
            Victorina.musicDuration = System.Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = checkBoxRandomStart.Checked;
            Victorina.limitAnswerTime = cbLimitAnswerTime.Checked;
            Victorina.timeForAnswer = System.Convert.ToInt32(cBoxLimitAnswerTime.Text);
            Victorina.SaveSettings();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetSettings();
            this.Hide();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Victorina.listSongs = Directory.GetFiles(fbd.SelectedPath, "*.mp3", orDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Victorina.listSongs.ToArray());
            }
        }

        void SetSettings()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Directory.GetFiles(Victorina.lastFolder, "*.mp3", orDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
            orDirectory.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.gameDuration.ToString();
            cbMusicDuration.Text = Victorina.musicDuration.ToString();
            checkBoxRandomStart.Checked = Victorina.randomStart;
            cbLimitAnswerTime.Checked = Victorina.limitAnswerTime;
            cBoxLimitAnswerTime.Text = Victorina.timeForAnswer.ToString();
        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            SetSettings();
            Victorina.ReadMusic();
            listBox1.Items.AddRange(Victorina.listSongs.ToArray());
            cbLimitAnswerTime.Checked = true;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void cbLimitAnswerTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLimitAnswerTime.Checked == true)
                cBoxLimitAnswerTime.Enabled = true;
            else
                cBoxLimitAnswerTime.Enabled = false;
        }
    }
}
