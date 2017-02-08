using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fima
{
    public partial class Eingabe : Form
    {
        Color bgColor;

        public Eingabe()
        {
            InitializeComponent();
        }

        private void Eingabe_Load(object sender, EventArgs e)
        {
            dtBegin.CustomFormat = "HH:mm";
            dtHour.CustomFormat = "mm";
            dtMin.CustomFormat = "mm";
            dtHour.Value = Convert.ToDateTime("00:00");
            dtMin.Value = Convert.ToDateTime("00:00");
            dtBegin.Value = Convert.ToDateTime("06:00");
            cbChild.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan tsBegin = dtBegin.Value.TimeOfDay;
            string[] arrShutDown = { dtHour.ToString(), dtMin.ToString() };
            Boolean minderjaehrig;
            if (cbChild.SelectedIndex == 0) { minderjaehrig = false; } else { minderjaehrig = true; }
            if(rbCustomShutdown.Checked)
            {
                Timer timer = new Timer(tsBegin, minderjaehrig, cbUeberstunden.Checked, arrShutDown, bgColor);
                this.Visible = false;
                timer.ShowDialog();
                this.Visible = true;
            }else
            {
                Timer timer = new Timer(tsBegin, minderjaehrig, cbUeberstunden.Checked, bgColor);
                this.Visible = false;
                timer.ShowDialog();
                this.Visible = true;
            }
        }

        private void bJetzt_Click(object sender, EventArgs e)
        {
            dtBegin.Value = Convert.ToDateTime(DateTime.Now.TimeOfDay.ToString().Substring(0, 5));
        }

        private void bFarbe_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bFarbe.BackColor = colorDialog1.Color;
                bgColor = colorDialog1.Color;
            }
        }

        private void rbCustomShutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomShutdown.Checked)
            {
                gbCustomShutdown.Visible = true;
            }
            else
            {
                gbCustomShutdown.Visible = false;
            }
        }
    }
}
