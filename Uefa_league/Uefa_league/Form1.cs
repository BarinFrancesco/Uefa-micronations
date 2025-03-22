using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        match[] risultati = new match[20];
        team[] team_list = new team[20];
        int index_match = 0;
        int index_team = 0;

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
                        risultati[index_match] =  new match(dati[0], dati[1], int.Parse(dati[2]),int.Parse(dati[3]));

                        add_team(dati[0], dati[1], int.Parse(dati[2]), int.Parse(dati[3]));

                    }
                    index_match++;
                    index_team++;
                }
            }
        }

        public void add_team(string nome1, string nome2, int gol1, int gol2)
        {
            team_list[index_team] = new team(nome1, gol1 );
            index_team++;
            team_list[index_team] = new team(nome2, gol2 );
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

        struct team
        {
            public int Goal, matchDisputed;
            public string Name;
            
            public team( string nome, int goal)
            {
                Goal = goal;
                matchDisputed = 0;
                Name = nome;
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
    }
}
