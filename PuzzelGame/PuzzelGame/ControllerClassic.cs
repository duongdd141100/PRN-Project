using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PuzzelGame
{
    class ControllerClassic
    {
        private TableLayoutPanel panel;
        private int level;
        private Timer timer;
        private Button[,] buttons;
        Label labelCount;

        public ControllerClassic() { }
        public ControllerClassic(TableLayoutPanel panel, int level, Label labelCount, Timer timer)
        {
            this.panel = panel;
            this.level = level;
            this.labelCount = labelCount;
            this.timer = timer;
            panel.ColumnCount = level;
            panel.RowCount = level;
        }
        int count = 0;
        private void ButtonHanler(object sender, EventArgs e)
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    if (buttons[i, j].Text.Equals(""))
                    {
                        if (i < level - 1 && sender == buttons[i + 1, j])
                        {
                            swapButton(buttons[i, j], buttons[i + 1, j]);
                            labelCount.Text = (++count).ToString();
                        }
                        if (i > 0 && sender == buttons[i - 1, j])
                        {
                            swapButton(buttons[i, j], buttons[i - 1, j]);
                            labelCount.Text = (++count).ToString();
                        }
                        if (j < level - 1 && sender == buttons[i, j + 1])
                        {
                            swapButton(buttons[i, j], buttons[i, j + 1]);
                            labelCount.Text = (++count).ToString();
                        }
                        if (j > 0 && sender == buttons[i, j - 1])
                        {
                            swapButton(buttons[i, j], buttons[i, j - 1]);
                            labelCount.Text = (++count).ToString();
                        }
                    }
                }
            }
            if (checkSuccess())
            {
                timer.Stop();
                MessageBox.Show("you win");
            }
        }

        public void swapButton(Button a, Button b)
        {
            a.Text = b.Text;
            b.Text = "";
            a.BackColor = b.BackColor;
            b.BackColor = Color.White;
        }

        internal void designButton()
        {

            panel.Location = new Point(725 / 2 - 210 / 2, 20);
            buttons = new Button[level, level];

            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Text = (i * level + j + 1) + "";
                    buttons[i, j].Click += ButtonHanler;
                    buttons[i, j].Font = new Font("Arial", 12, FontStyle.Bold);
                    buttons[i, j].BackColor = System.Drawing.Color.Cyan;
                    buttons[i, j].Enabled = false;
                    buttons[i, j].Size = new Size(210 / level, 210 / level);
                    panel.Controls.Add(buttons[i, j]);
                }
            }
            buttons[level - 1, level - 1].Text = "";
            buttons[level - 1, level - 1].BackColor = System.Drawing.Color.White;
        }

        public bool checkSuccess()
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level - 1; j++)
                {
                    int num = i * level + j + 1;
                    if (!buttons[i, j].Text.Equals(num.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void randomButton()
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    buttons[i, j].Enabled = true;
                }
            }

            int rowIndex = level - 1;
            int colIndex = level - 1;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int temp = random.Next(1, 5);
                switch (temp)
                {
                    //up
                    case 1:
                        if (rowIndex > 0)
                        {
                            swapButton(buttons[rowIndex, colIndex], buttons[rowIndex - 1, colIndex]);
                            rowIndex -= 1;
                        }
                        break;

                    //right
                    case 2:
                        if (colIndex < level - 1)
                        {
                            swapButton(buttons[rowIndex, colIndex], buttons[rowIndex, colIndex + 1]);
                            colIndex += 1;
                        }
                        break;
                    //down
                    case 3:
                        if (rowIndex < level - 1)
                        {
                            swapButton(buttons[rowIndex, colIndex], buttons[rowIndex + 1, colIndex]);
                            rowIndex += 1;
                        }
                        break;
                    //left
                    case 4:
                        if (colIndex > 0)
                        {
                            swapButton(buttons[rowIndex, colIndex], buttons[rowIndex, colIndex - 1]);
                            colIndex -= 1;
                        }
                        break;
                }
            }
        }

    }
}
