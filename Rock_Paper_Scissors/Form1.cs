using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public int rounds = 3;
        public int timePerRound = 6; 
        string[] AIchoice = { "rock", "paper", "scissor", "rock", "scissor", "paper" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string playerChoice;
        int playerWins = 0;
        int AIwins = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            playerChoice = "none";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   

}
