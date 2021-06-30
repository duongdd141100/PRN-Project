using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PuzzelGame
{
    class Controller
    {
        private TableLayoutPanel panel;
        private int level;
        private Button[,] buttons;
        public Controller(TableLayoutPanel panel, int level)
        {
            this.panel = panel;
            this.level = level;
        }

        internal void designButton()
        {
            panel.ColumnCount = level;
            panel.RowCount = level;
            buttons = new Button[level,level];
            
            for (int i = 0; i < level; i++)
            {
                for(int j = 0; j < level; j++)
                {
                    
                    buttons[i, j] = new Button();
                    buttons[i, j].Text = (i * level + j + 1) + "";
                    Console.WriteLine(panel.Width + " " + level);
                    Console.WriteLine(panel.Width / level + "," + panel.Height / level);
                    buttons[i, j].Size = new Size(210 / level, 210 / level);
                    panel.Controls.Add(buttons[i, j]);
                }
            }
            buttons[level - 1, level - 1].Text = "";
            randomButton();
        }

        private void randomButton()
        {
            int rowIndex = level - 1;
            int colIndex = level - 1;
            for(int i = 0; i < 1000 * level; i++)
            {
                Random random = new Random();
                int temp = random.Next(0, 5);
                switch(temp)
                {
                    //up
                    case 1:
                        if(rowIndex > 0)
                        {     buttons[rowIndex, colIndex].Text = buttons[rowIndex - 1, colIndex].Text;
                            buttons[rowIndex - 1, colIndex].Text = "";
                            rowIndex -= 1;
                        }
                        break;
                    //right
                    case 2:
                        if (colIndex < level - 1)
                        {
                            buttons[rowIndex, colIndex].Text = buttons[rowIndex, colIndex + 1].Text;
                            buttons[rowIndex, colIndex + 1].Text = "";
                            colIndex += 1;
                        }
                        break;
                    //down
                    case 3:
                        if (rowIndex < level - 1)
                        {
                            buttons[rowIndex, colIndex].Text = buttons[rowIndex + 1, colIndex].Text;
                            buttons[rowIndex + 1, colIndex].Text = "";
                            rowIndex += 1;
                        }
                        break;
                    //left
                    case 4:
                        if (colIndex > 0)
                        {
                            buttons[rowIndex, colIndex].Text = buttons[rowIndex, colIndex - 1].Text;
                            buttons[rowIndex, colIndex - 1].Text = "";
                            colIndex -= 1;
                        }
                        break;

                }
            }
        }
    }
}
