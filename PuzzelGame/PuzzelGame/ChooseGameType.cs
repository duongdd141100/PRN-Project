using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuzzelGame
{
    public partial class ChooseGameType : Form
    {
        public ChooseGameType()
        {
            InitializeComponent();
        }

        private void buttonClassic_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm f = new GameForm("");
            f.Show();
        }
    }
}
