using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigFarmClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Skapa fönstret för porträtt
            PigFarm.clsPigFamilyPortraits frmPortratt = new
                            PigFarm.clsPigFamilyPortraits(this);

            int[] arr_iGris; 		// Vektorn deklareras
            arr_iGris = new int[5]; 	// De olika posterna i vektorn skapas
            arr_iGris[0] = 4; 	// Grisen på position noll får storleken fyra
            arr_iGris[1] = 0;
            arr_iGris[2] = 2;
            arr_iGris[3] = 1;
            arr_iGris[4] = 3; 	// Grisen på position fyra får storleken tre
             

            frmPortratt.ShowPigs(arr_iGris);

            frmPortratt.TickSpeed = 1000; // Hastigheten sätts 1000 msek

            for (int iAktuellGris = 1; iAktuellGris < 5; iAktuellGris++)
            {
                if (arr_iGris[iAktuellGris] <= arr_iGris[0])
                {
                    frmPortratt.ShowPig(arr_iGris[iAktuellGris]);
                    frmPortratt.Tick(); // pausar i 1000 msek
                }
            }
        }
    }
}
