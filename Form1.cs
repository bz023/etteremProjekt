using System;
using System.Collections.Generic;
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
            List<Etel> etelek = new List<Etel>();
            foreach (var i in File.ReadAllLines("tesztbazis.txt"))
            {
                etelek.Add(new Etel(i));
            }
            foreach (var j in etelek)
            {
                eid.Items.Add(j.id);
            }


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
            bool osztjominden = false;
            if (rendelonev.Text != "" && rendelocim.Text != "" && tszam.Text != "" && enev.Text != "" && ear.Text != "" && megjegyzes.Text != "") osztjominden = true;
            else osztjominden = false;




            if (osztjominden)
            {
                int osszeg = 0;
                int kmdij = 30;
                int tavolsag = int.Parse(tav.Text);

                osszeg += tavolsag * kmdij;

                if (e_sajt.Checked) osszeg = +150;
                if (e_chilli.Checked) osszeg += 200;
                if (e_bbq.Checked) osszeg += 250;
                if (e_tartar.Checked) osszeg += 200;
                if (e_hagyma.Checked) osszeg += 200;


                string etelid = eid.Text;
                foreach (var j in etelek)
                {
                    if (j.id == int.Parse(etelid))
                    {
                        osszeg += j.ar;
                    }
                }
                string n = string.Format("nyugta_{0:yyyy-MM-dd_HH-mm-ss}.txt", DateTime.Now);
                StreamWriter ki = new StreamWriter(n);


                ki.WriteLine("Rendelés leadásának ideje: " + DateTime.Now);
                ki.WriteLine("\n\nMegrendelő adatai:");
                ki.WriteLine("\tNév: " + rendelonev.Text);
                ki.WriteLine("\tCím: " + rendelocim.Text);
                ki.WriteLine("\tTelefonszám: " + tszam.Text);
                ki.WriteLine("\tTávolság: " + tavolsag);
                ki.WriteLine("\n\nRendelés adatai:");
                ki.WriteLine("\tTermék neve: " + enev.Text);
                ki.WriteLine("\tTermék ára: " + ear.Text);
                if (e_sajt.Checked) ki.WriteLine("\tExtra sajt ára: +150Ft");
                if (e_chilli.Checked) ki.WriteLine("\tChilli szósz ára: +200Ft");
                if (e_bbq.Checked) ki.WriteLine("\tBarbecue szósz ára: +250Ft");
                if (e_tartar.Checked) ki.WriteLine("\tTartár szósz ára: +200Ft");
                if (e_hagyma.Checked) ki.WriteLine("\tPirított hagyma ára: +200Ft");
                ki.WriteLine("\tMegjegyzés: " + megjegyzes.Text);
                ki.WriteLine("\n\n\nVégösszeg: " + osszeg + "Ft.");


                ki.Flush();
                ki.Close();
                MessageBox.Show("Sikeres rendelés! Végösszeg: " + osszeg);
                clearData();
            }
            else
            {
                MessageBox.Show("Hiba a felvitt adatokban!");
                clearData();
            }

        }
        private void clearData()
        {
            rendelonev.Clear();
            rendelocim.Clear();
            tszam.Clear();
            tav.Value = 0;
            enev.Clear();
            ear.Clear();
            eid.SelectedIndex = 0;
            e_sajt.Checked = false;
            e_chilli.Checked = false;
            e_bbq.Checked = false;
            e_tartar.Checked = false;
            e_hagyma.Checked = false;
            megjegyzes.Clear();
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
