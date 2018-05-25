using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosAmpel_StatePattern
{
    public partial class Form1 : Form
    {
        //Hier wird das StateContext Objekt angelegt
        StateContext MeineAmpel = new StateContext();

        public Form1()
        {
            InitializeComponent();
            MeineAmpel.State = new Red();
            MeineAmpel.Change();
            this.BackColor = Color.DodgerBlue;
            //panel_oben.BackColor = Color.Black;
            //panel_mitte.BackColor = Color.Black;
            //panel_unten.BackColor = Color.Black;
        }

        private void btn_state_change_Click(object sender, EventArgs e)
        {            
            MeineAmpel.Change();
            //Colorcheck();
            panel_oben.BackColor = MeineAmpel.AmpelOben;
            panel_mitte.BackColor = MeineAmpel.AmpelMitte;
            panel_unten.BackColor = MeineAmpel.AmpelUnten;

            Console.WriteLine(MeineAmpel.State);
            this.Refresh();
        }

        /// <summary>
        /// Ampelfarben wechseln im Abhängigkeit zum Status
        /// </summary>
        public void Colorcheck()
        {
            string Vergleich = MeineAmpel.State.ToString();
            //Console.WriteLine(Vergleich);

            if (Vergleich == "MariosAmpel_StatePattern.Green")
            {
                panel_oben.BackColor = Color.Black;
                panel_mitte.BackColor = Color.Black;
                panel_unten.BackColor = Color.Lime;
                return;
            }
            if (Vergleich == "MariosAmpel_StatePattern.RedAndAmber")
            {
                panel_oben.BackColor = Color.Red;
                panel_mitte.BackColor = Color.Yellow;
                panel_unten.BackColor = Color.Black;
                return;
            }
            if (Vergleich == "MariosAmpel_StatePattern.Yellow")
            {
                panel_oben.BackColor = Color.Black;
                panel_mitte.BackColor = Color.Yellow;
                panel_unten.BackColor = Color.Black;
                return;
            }
            if (Vergleich == "MariosAmpel_StatePattern.Red")
            {
                panel_oben.BackColor = Color.Red;
                panel_mitte.BackColor = Color.Black;
                panel_unten.BackColor = Color.Black;
                return;
            }
            else
            { Console.WriteLine("Hier ist was falsch!"); }
        }
    }
}
