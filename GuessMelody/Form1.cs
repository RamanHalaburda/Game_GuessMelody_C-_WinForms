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
    public partial class fMain : Form
    {
        fSettings fs = new fSettings();
        fGame fg = new fGame();

        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Victorina.SetSettings();
            fs.ShowDialog();            
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Victorina.SetSettings();            
        }
    }
}
