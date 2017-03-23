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
    public partial class fAnswer : Form
    {
        static public int answerTime = 0;

        public fAnswer()
        {
            InitializeComponent();
        }

        private void fAnswer_Load(object sender, EventArgs e)
        {
            if (Victorina.limitAnswerTime == true)
            {
                label1.Visible = true;
                lblTimeForAnswer.Visible = true;
                answerTime = Victorina.timeForAnswer;
                lblTimeForAnswer.Text = Victorina.timeForAnswer.ToString();
            }
            else
            {
                label1.Visible = false;
                lblTimeForAnswer.Visible = false;
            }
            tmr.Start();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (Victorina.limitAnswerTime == true)
            { 
                lblTimeForAnswer.Text = System.Convert.ToString(answerTime--);
                if (System.Convert.ToInt32(lblTimeForAnswer.Text) == 0)
                {
                    button1.Enabled = false;
                    fGame fg = new fGame();
                    //label1.Text = fg.WinMP.currentMedia.name;
                    lblTimeForAnswer.Visible = false;
                }
            }
        }
    }
}
