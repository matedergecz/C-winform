using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Uszoverseny
{


    public partial class Form1 : Form
    {
        class Versenyzo
        {
            public string Rajtszam { get; private set; }
            public string Nev { get; private set; }
            public DateTime SzulDatum { get; private set; }
            public string Orszag { get; private set; }
            public TimeSpan IdoEredmeny { get; private set; }



            //konstruktor
            public Versenyzo(string rajtszam, string nev, DateTime szulDatum, string orszag, TimeSpan idoEredmeny)
            {
                this.Rajtszam = rajtszam;
                this.Nev = nev;
                this.SzulDatum = szulDatum;
                this.Orszag = orszag;
                this.IdoEredmeny = idoEredmeny;
            }

            public override string ToString()
            {
                return Nev;
            }


           

        }
       


        private void AdatBeolvasas()
        {
            StreamReader olvasoCsatorna = new StreamReader("C:/Users/user/source/repos/Uszoverseny/uszok.txt");

            string adat = olvasoCsatorna.ReadLine();
            while (adat != null)
            {
                Feldolgoz(adat);
                adat = olvasoCsatorna.ReadLine();
            }
            olvasoCsatorna.Close();
        }

        private void Feldolgoz(string adat)
        {
            string rajtSzam, nev, orszag;
            DateTime szulDatum;
            TimeSpan idoEredmeny;
            Versenyzo versenyzo;
            string[] tordelt = adat.Split(';');

            rajtSzam = tordelt[0];
            nev = tordelt[1];
            szulDatum = DateTime.Parse(tordelt[2]);
            orszag = tordelt[3];
            idoEredmeny = TimeSpan.Parse("0:" + tordelt[4]);
            versenyzo = new Versenyzo(rajtSzam, nev, szulDatum, orszag, idoEredmeny);
            lstVersenyzok.Items.Add(versenyzo);

        }
        private void lstVersenyzok_SelectedItemChanged(object sender, EventArgs e)
        {
            Versenyzo versenyzo = (Versenyzo)lstVersenyzok.SelectedItem;
            txtRajtszam.Text = versenyzo.Rajtszam;
            txtOrszag.Text = versenyzo.Orszag;
            txtIdoEredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss.ff");
            txtEletKor.Text = (DateTime.Now.Year - versenyzo.SzulDatum.Year) + " év.";

        }



        public Form1()
        {
            InitializeComponent();



        }


       

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            lstVersenyzok.Items.Clear();
            AdatBeolvasas();
            btnAdatBe.Enabled = false;
            btnGyoztes.Enabled = true;


        }

        

        private void btnGyoztes_Click(object sender, EventArgs e)
        {
            TimeSpan min = (lstVersenyzok.Items[0] as Versenyzo).IdoEredmeny;
            foreach (var item in lstVersenyzok.Items)
            {
                if((item as Versenyzo).IdoEredmeny < min)
                {
                    min = (item as Versenyzo).IdoEredmeny;

                }
            }
            txtGyoztesIdo.Text = new DateTime(min.Ticks).ToString("mm:ss:ff");
            rchTxtGyoztes.Clear();
            foreach (var item in lstVersenyzok.Items )
            {
                if ((item as Versenyzo).IdoEredmeny == min)
                {
                    rchTxtGyoztes.AppendText(item + "\n");
                }           
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
