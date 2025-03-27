using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uefa_league
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadresults("../../../files/Resultlist.CSV");
            rdoPartitamaxgoal.Checked = true;
        }

        match[] risultati = new match[20];
        int index_match = 0;

        public void loadresults(string path)
        {
            using ( StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string riga = reader.ReadLine();
                    if( !string.IsNullOrEmpty(riga)  && index_match != 0 )
                    {
                        string[] dati = riga.Split(';') ;
                        lstResults.Items.Add($"{dati[0].PadLeft(9)} |{dati[2]}:{dati[3]}| {dati[1]}");
                        risultati[index_match-1] = new match(dati[0], dati[1], int.Parse(dati[2]), int.Parse(dati[3]));
                    }
                    index_match++;
                }
            }
        }

        struct match
        {
            public string Away, Home;
            public int Awaygol, Homegol;

                public match( string casa, string ospiti, int golcasa, int golospiti)
            {
                Away = ospiti;
                Awaygol = golospiti;
                Home = casa;
                Homegol = golcasa;
            }
        } 

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdoSquadramaxgol.Checked)
            {
                int maxgoal = -1;
                string team = "";

                for (int i = 0; i < risultati.Length; i++)
                {
                    if (risultati[i].Homegol > risultati[i].Homegol)
                    {
                       
                    }

                   
                }
                
            } else if (rdoTotgoal.Checked)
            {
                int totgoal = 0;
                for (int i = 0; i < risultati.Length && risultati[i].Away != null ; i++) //nel controllo di esistenza controllo solo il nome, tanto se c'è quello c'è anche il resto
                {
                    totgoal += risultati[i].Homegol;
                    totgoal += risultati[i].Awaygol;
                }
                MessageBox.Show($"in totale nel girone sono stati segnati {totgoal} goal");
            } else if(rdoPartitamaxgoal.Checked) {
                int maxgoal = -1;
                int indexMatch = 0;
                for (int i = 0; i < risultati.Length && risultati[i].Away != null; i++) //nel controllo di esistenza controllo solo il nome, tanto se c'è quello c'è anche il resto
                {
                    int matchgoal = risultati[i].Awaygol+risultati[i].Homegol;
                    if (matchgoal > maxgoal)
                    {
                        maxgoal = matchgoal;
                        indexMatch = i;
                    }
                }

                MessageBox.Show($"la partia con più goal è stata {risultati[indexMatch].Home}-{risultati[indexMatch].Away}, nella quale sonon state segnate {maxgoal} reti");
            } else
            {
                MessageBox.Show("selezionarre un'operazione");
            }
        }

        private void txtHomeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAwayName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInvio_Click(object sender, EventArgs e)
        {

        }

        private void selHomeGol_ValueChanged(object sender, EventArgs e)
        {

        }

        private void selAwayGol_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void rdoTotgoal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoSquadramaxgol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoPartitamaxgoal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
