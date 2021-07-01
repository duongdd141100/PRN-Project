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
    public partial class GameForm : Form
    {
        int level;
        public int count = 0;
        int time = 0;
        String imgPath;
        public GameForm(String imgPath)
        {
            InitializeComponent();
            this.imgPath = imgPath;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            boxLevel.SelectedIndex = 0;
            level = getLevel();
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
            if(String.IsNullOrEmpty(imgPath))
            {
                ControllerClassic con = new ControllerClassic(panelTable, level, labelCount);
                con.designButton();
            } else
            {
                ControllerImg con = new ControllerImg(panelTable, level, imgPath, labelCount);
                con.designButton();
            }
                
        }

        private void panelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
