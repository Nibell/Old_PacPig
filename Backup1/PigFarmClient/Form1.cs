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
            string[] arrRows = new string[8];
            string[] arrFlowers = new string[8];

            arrRows[0] = "2C46AEAC";
            arrRows[1] = "6BF94785";
            arrRows[2] = "56FAFD69";
            arrRows[3] = "3D3C57B8";
            arrRows[4] = "47AD57AC";
            arrRows[5] = "3FC7D7C5";
            arrRows[6] = "6D397D11";
            arrRows[7] = "13AA93A8";

            arrFlowers[0] = "01000000";
            arrFlowers[1] = "00001010";
            arrFlowers[2] = "00001000";
            arrFlowers[3] = "01000001";
            arrFlowers[4] = "10000000";
            arrFlowers[5] = "10000000";
            arrFlowers[6] = "01000000";
            arrFlowers[7] = "00000110";

            PigFarm.clsPigMan frmLabyrint = new PigFarm.clsPigMan(this);
            frmLabyrint.NewMaze(arrRows, arrFlowers);

            frmLabyrint.InsertPig(0, 0, 0, 1);

            frmLabyrint.TickSpeed = 250;
            frmLabyrint.AutoPilot = false;

            while (frmLabyrint.PigIsAlive)
            {
                if (frmLabyrint.Points == 30 && frmLabyrint.NumberOfWolves <= 0)
                {
                    frmLabyrint.InsertWolf(1, 2, 1, 2);
                }
                if (frmLabyrint.Points == 60 && frmLabyrint.NumberOfWolves <= 1)
                {
                    frmLabyrint.InsertWolf(1, 2, 1, 2);
                }
                if (frmLabyrint.Points == 90 && frmLabyrint.NumberOfWolves <= 2)
                {
                    frmLabyrint.InsertWolf(1, 2, 1, 2);
                }
                frmLabyrint.Move();
                frmLabyrint.Tick();
            }
        }
    }
}