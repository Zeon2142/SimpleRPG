using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class SimpleRPG : Form
    {
        private Player player1 = new Player(20, 20, 0 , 0, 1); 
        public SimpleRPG()
        {
            InitializeComponent();
            player1.CurrentHP = 20;
            player1.MaxHP = 20;
            player1.CurrentMP = 10;
            player1.MaxMP = 10;
            player1.Money = 0;
            player1.Level = 1;
            player1.Location = "Forest";

            HealthValue.Text = player1.CurrentHP.ToString();
            ManaValue.Text = player1.CurrentMP.ToString();
            MoneyValue.Text = player1.Money.ToString();
            CharLevelValue.Text = player1.Level.ToString();
            Location.Text = player1.Location;

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CharStats_Click(object sender, EventArgs e)
        {
            MoneyValue.Text = "1";
        }

        private void SimpleRPG_Load(object sender, EventArgs e)
        {

        }
    }
}
