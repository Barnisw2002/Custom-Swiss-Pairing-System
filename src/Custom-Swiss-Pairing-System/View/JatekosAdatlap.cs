using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Custom_Swiss_Pairing_System.Controller;
using Custom_Swiss_Pairing_System.Model;

namespace Custom_Swiss_Pairing_System.View
{
    public partial class JatekosAdatlap : Form
    {
        private readonly JatekosController jatekosController;
        private readonly Jatekos jatekos1;
        private readonly long jatekosID;
        private readonly bool ismodif;
        public JatekosAdatlap(Controller.JatekosController jatekosController, Jatekos jatekos)
        {
            InitializeComponent();
            this.jatekosController = jatekosController;
            this.jatekos1 = jatekos;

            jatekosID = jatekos.ID;
            nev.Text = jatekos.Nev;
            identitas.Text = jatekos.Nem;
            szulido.Text = jatekos.SzuletesiIdo;
            rangja.Text = jatekos.Rang;
            regioja.Text = jatekos.Regio;
            elker.Text = jatekos.Elkerules;
            Hozzáadás.Text = "Módosítás";
            ismodif = true;
            Törlés.Visible = true;
        }

        public JatekosAdatlap(JatekosController jatekosController)
        {
            InitializeComponent();
            Törlés.Visible = false;
            this.jatekosController = jatekosController;
        }

        private void torles_Click(object sender, EventArgs e)
        {
            jatekosController.deleteJatekos(jatekos1);
        }

        private void hozzad_click(object sender, EventArgs e)
        {
            if (ismodif)
            {
                string lNev = nev.Text;
                string lNem = identitas.Text;
                string lSzuletesiIdo = szulido.Text;
                string lRang = rangja.Text;
                string lRegio = regioja.Text;
                string lElkerules = elker.Text;

                Jatekos modjatekos = new Jatekos
                {
                    ID = this.jatekos1.ID,
                    Nev = lNev,
                    Nem = lNem,
                    SzuletesiIdo = lSzuletesiIdo,
                    Rang = lRang,
                    Regio = lRegio,
                    Elkerules = lElkerules
                };

                jatekosController.modifyJatekos(modjatekos);
            }
            else
            {
                string lNev = nev.Text;
                string lNem = identitas.Text;
                string lSzuletesiIdo = szulido.Text;
                string lRang = rangja.Text;
                string lRegio = regioja.Text;
                string lElkerules = elker.Text;

                Jatekos addjatekos = new Jatekos
                {
                    Nev = lNev,
                    Nem = lNem,
                    SzuletesiIdo = lSzuletesiIdo,
                    Rang = lRang,
                    Regio = lRegio,
                    Elkerules = lElkerules
                };

                jatekosController.addJatekos(addjatekos);
            }

        }
    }
}
