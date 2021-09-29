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

        struct Etel
        {
            public int id, ar;
            public string nev;
            public Etel(string s)
            {
                string[] db = s.Split(';');
                id = int.Parse(db[0]);
                nev = db[1];
                ar = int.Parse(db[2]);
            }
        }
        public void gomb_Click(object sender, EventArgs e)
        {

            List<Etel> etelek = new List<Etel>();
            foreach (var i in File.ReadAllLines("tesztbazis.txt"))
            {
                etelek.Add(new Etel(i));
            }
            int osszeg = 0;
            string ido = DateTime.Now.ToString("HH:mm:ss");
            int kmdij = 30;

            string rnev = rendelonev.Text;
            string rcim = rendelocim.Text;
            int telefon = int.Parse(tszam.Text);
            int tavolsag = int.Parse(tav.Text);
            string megj = megjegyzes.Text;

            osszeg += tavolsag * kmdij;

            if (e_sajt.Checked) osszeg = +150;
            if (e_chilli.Checked) osszeg += 200;
            if (e_bbq.Checked) osszeg += 250;
            if (e_tartar.Checked) osszeg += 200;
            if (e_hagyma.Checked) osszeg += 200;


            string etelid = (string)eid.SelectedItem;
            foreach (var j in etelek)
            {
                if (j.id == int.Parse(etelid))
                {
                    osszeg += j.ar;
                }
            }
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

        private void eid_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Etel> etelek = new List<Etel>();
            foreach (var i in File.ReadAllLines("tesztbazis.txt"))
            {
                etelek.Add(new Etel(i));
            }
            foreach (var j in etelek)
            {
                if (j.id == int.Parse(eid.Text))
                {
                    enev.Text = j.nev;
                    ear.Text = Convert.ToString(j.ar);
                }
            }
        }
    }
}
