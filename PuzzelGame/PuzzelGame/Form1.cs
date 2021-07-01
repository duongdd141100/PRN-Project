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
    public partial class form : Form
    {
        int level;
        int count = 0;
        int time = 0;
        Button[][] buttons;
        int width;
        int height;
        public form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.SetStyle(ControlStyles.ResizeRedraw, true);

            boxLevel.SelectedIndex = 0;
            level = getLevel();
            Controller con = new Controller(panelTable, level);
            //con.designButton();
            //Button button = new Button();
            //button.Text = "1";
            //panel.Controls.Add(button);

            // Button button2 = new Button();
            //button2.Text = "2";
            //Button button3 = new Button();
            //button3.Text = "3";


        }

        private int getLevel()
        {
            String input = boxLevel.SelectedItem.ToString();
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'x')
                {
                    return Int32.Parse(input.Substring(0, i));
                }
            }
            return -1;
        }

        private void boxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelTable.Controls.Clear();
            level = getLevel();
            Controller con = new Controller(panelTable, level);
            con.designButton();
        }

        private void panelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
