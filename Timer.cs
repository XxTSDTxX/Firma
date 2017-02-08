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
    public partial class Timer : Form
    {
        TimeSpan tsArbeitsBegin;
        Boolean minderjaehrig;
        Boolean countUeberstd;
        Boolean shutDown;
        Color bgColor;
        string[] arrShutDown;
        public Timer()
        {
            InitializeComponent();
        }

        public Timer(TimeSpan tsBegin, Boolean minderjaehrig, Boolean countUeberstd, Color bgColor)
        {
            InitializeComponent();
            this.tsArbeitsBegin = tsBegin;
            this.minderjaehrig = minderjaehrig;
            this.countUeberstd = countUeberstd;
            this.bgColor = bgColor;
        }

        public Timer(TimeSpan tsBegin, Boolean minderjaehrig, Boolean countUeberstd, string[] arrShutDown, Color bgColor)
        {
            InitializeComponent();
            this.tsArbeitsBegin = tsBegin;
            this.minderjaehrig = minderjaehrig;
            this.countUeberstd = countUeberstd;
            this.arrShutDown = arrShutDown;
            this.bgColor = bgColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = bgColor;
            timer1.Start();
        }

        public void zeitdifferenz() //String pause in minuten!
        {
            // Format HH:MM z.B. 07:00. Wenn keine pause eingerechnet werden soll -> string pause = ""
            TimeSpan tsEndeMP;
            TimeSpan tsArbeitszeit = new TimeSpan(7,0,0);
            TimeSpan tsPauseS = new TimeSpan(0, 45, 0);
            TimeSpan tsPauseL = new TimeSpan(1, 0, 0);
            TimeSpan tsTimer;
            TimeSpan tsEndeOP;
            int vergleichsVar;
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            
            vergleichsVar = Convert.ToInt32(tsArbeitsBegin.ToString().Substring(0, 2) + tsArbeitsBegin.ToString().Substring(3, 2));

            tsEndeOP = tsArbeitsBegin.Add(tsArbeitszeit);
            if(vergleichsVar <900)
            {
            }
            else if (vergleichsVar >= 900 && vergleichsVar < 915)
            {
                tsPauseS = tsPauseS.Subtract(new TimeSpan(0, tsArbeitsBegin.Minutes,0));
                tsPauseL = tsPauseL.Subtract(new TimeSpan(0, tsArbeitsBegin.Minutes, 0));
            }
            else if (vergleichsVar >= 915 && vergleichsVar <= 1300)
            {
                tsPauseS = tsPauseS.Subtract(new TimeSpan(0, 15, 0));
                tsPauseL = tsPauseL.Subtract(new TimeSpan(0, 15, 0));
            }
            else if (vergleichsVar > 1300 && vergleichsVar <= 1345 && !minderjaehrig)
            {
                tsPauseS = tsPauseS.Subtract(new TimeSpan(0, 15 + tsArbeitsBegin.Minutes, 0));
            }
            else if (vergleichsVar > 1300 && vergleichsVar <= 1345 && minderjaehrig)
            {
                tsPauseL = tsPauseL.Subtract(new TimeSpan(0, 15 + tsArbeitsBegin.Minutes, 0));
            }else
            {
                tsPauseS = tsPauseS.Subtract(new TimeSpan(0, 45, 0));
                tsPauseL = tsPauseL.Subtract(new TimeSpan(1, 0, 0));
            }

            if(minderjaehrig)
            {
                tsEndeMP = tsEndeOP.Add(tsPauseL);
            }else
            {
                tsEndeMP = tsEndeOP.Add(tsPauseS);
            }
            tsTimer = tsEndeMP.Subtract(tsNow);
            if(tsTimer.Hours <= 0 && tsTimer.Minutes <= 0 && tsTimer.Seconds <=0)
            {
                if(countUeberstd)
                {
                    if(tsTimer.Hours <= -1)
                    {
                        this.BackColor = Color.Red;
                    }
                    if(!string.IsNullOrEmpty(arrShutDown[0]))
                    {
                        if(tsTimer.Hours == Convert.ToInt32(arrShutDown[0]) && tsTimer.Minutes == Convert.ToInt32(arrShutDown[1]))
                        {
                            timer1.Stop();
                            System.Diagnostics.Process.Start("shutdown", "/s /f /t 03");
                        }
                    }
                    lTimer.Text = "+"+tsTimer.ToString().Substring(1,tsTimer.ToString().Length-1);
                }else
                {
                    lTimer.Text = "00:00:00";
                    timer1.Stop();
                    MessageBox.Show("FEIERABEND!!!!!!!");
                    this.Close();
                }
                
            }else
            {
                lTimer.Text = tsTimer.ToString();
            }

        }

        public string zeitdifferenzSchule() //String pause in minuten!
        {
            // Format HH:MM z.B. 07:00. Wenn keine pause eingerechnet werden soll -> string pause = ""

            DateTime start;
            DateTime pause;

            string datum = Convert.ToString(DateTime.Now);
            datum = datum.Remove(10, 9);
            string gesamtanfang = datum + " " + DateTime.Now.ToShortTimeString();
            string jetzt = DateTime.Now.ToShortTimeString().Remove(2, 1);
            if (Convert.ToDouble(jetzt) < 0915)
            {
                pause = Convert.ToDateTime(datum + " " + "09:15");
                start = Convert.ToDateTime(gesamtanfang);
                int minuten = Convert.ToInt32(pause.Subtract(start).TotalMinutes);
                int stunden;
                int rest;

                stunden = minuten / 60;
                rest = minuten % 60;

                string ausgabe = Convert.ToString(stunden) + " Stunde(n) und " + Convert.ToString(rest);

                return ausgabe;
            }
            else if (Convert.ToDouble(jetzt) < 1100)
            {
                pause = Convert.ToDateTime(datum + " " + "11:00");
                start = Convert.ToDateTime(gesamtanfang);
                int minuten = Convert.ToInt32(pause.Subtract(start).TotalMinutes);
                int stunden;
                int rest;

                stunden = minuten / 60;
                rest = minuten % 60;

                string ausgabe = Convert.ToString(stunden) + " Stunde(n) und " + Convert.ToString(rest);

                return ausgabe;
            }
            else if (Convert.ToDouble(jetzt) < 1245)
            {
                pause = Convert.ToDateTime(datum + " " + "12:45");
                start = Convert.ToDateTime(gesamtanfang);
                int minuten = Convert.ToInt32(pause.Subtract(start).TotalMinutes);
                int stunden;
                int rest;

                stunden = minuten / 60;
                rest = minuten % 60;

                string ausgabe = Convert.ToString(stunden) + " Stunde(n) und " + Convert.ToString(rest);

                return ausgabe;
            }
            else if (Convert.ToDouble(jetzt) < 1445)
            {
                pause = Convert.ToDateTime(datum + " " + "12:45");
                start = Convert.ToDateTime(gesamtanfang);
                int minuten = Convert.ToInt32(pause.Subtract(start).TotalMinutes);
                int stunden;
                int rest;

                stunden = minuten / 60;
                rest = minuten % 60;

                string ausgabe = Convert.ToString(stunden) + " Stunde(n) und " + Convert.ToString(rest);

                return ausgabe;
            }
            else
            {
                string ausgabe = "Fehler";

                return ausgabe;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zeitdifferenz();
        }
    }
}
