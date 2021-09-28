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
using System.Text.RegularExpressions;

namespace etteremProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gomb_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            string ido = DateTime.Now.ToString("HH:mm:ss");

            //StreamWriter ki = new StreamWriter("nyugta.txt");
            string rnev, rcim, enev, megj; //enev : comboboxból szedi majd ki
            int telefon, tavolsag, eid, ear; //eid, ear majd jön listából
            bool sajt = false, chilli = false, bbq = false, tartar = false, hagyma = false;

            rnev = rendelonev.Text;
            rcim = rendelocim.Text;
            megj = megjegyzes.Text;
            telefon = int.Parse(tszam.Text);
            tavolsag = int.Parse(tav.Text);

            if (e_sajt.Checked) sajt = true;
            else sajt = false;

            if (e_chilli.Checked) chilli = true;
            else chilli = false;

            if (e_bbq.Checked) bbq = true;
            else bbq = false;

            if (e_tartar.Checked) tartar = true;
            else tartar = false;

            if (e_hagyma.Checked) hagyma = true;
            else hagyma = false;
        }

        private void tszam_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tszam.Text, "[^0-9]"))
            {
                MessageBox.Show("A telefonszámot csak számokkal írja be.");
                tszam.Text = tszam.Text.Remove(tszam.Text.Length - 1);
            }
        }

        private void rendelonev_TextChanged(object sender, EventArgs e)
        {
            foreach (var i in rendelonev.Text)
            {
                if (Regex.Match(Convert.ToString(i), "^[0-9]+$").Success)
                {
                    MessageBox.Show("A név nem tartalmazhat számot.");
                    rendelonev.Text = "";
                }
            }

        }
    }
}
