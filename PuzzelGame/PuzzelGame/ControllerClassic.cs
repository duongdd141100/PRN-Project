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
        private Label labelCount;
        private Label labelTime;
        private Label labelCountByCount;
        private Label labelTimeByTime;
        private Label labelTimeByCount;
        private Label labelCountByTime;
        List<int> listMove = new List<int>();

        public ControllerClassic() { }
        public ControllerClassic(TableLayoutPanel panel, int level, Label labelCount, Timer timer, Label labelTime, Label labelCountByCount, Label labelTimeByTime, Label labelTimeByCount, Label labelCountByTime)
        {
            this.panel = panel;
            this.level = level;
            this.labelCount = labelCount;
            this.timer = timer;
            panel.ColumnCount = level;
            panel.RowCount = level;
            this.labelTime = labelTime;
            this.labelCountByCount = labelCountByCount;
            this.labelTimeByTime = labelTimeByTime;
            this.labelCountByTime = labelCountByTime;
            this.labelTimeByCount = labelTimeByCount;
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
                            listMove.Add(1);
                        }
                        if (i > 0 && sender == buttons[i - 1, j])
                        {
                            swapButton(buttons[i, j], buttons[i - 1, j]);
                            labelCount.Text = (++count).ToString();
                            listMove.Add(3);
                        }
                        if (j < level - 1 && sender == buttons[i, j + 1])
                        {
                            swapButton(buttons[i, j], buttons[i, j + 1]);
                            labelCount.Text = (++count).ToString();
                            listMove.Add(4);
                        }
                        if (j > 0 && sender == buttons[i, j - 1])
                        {
                            swapButton(buttons[i, j], buttons[i, j - 1]);
                            labelCount.Text = (++count).ToString();
                            listMove.Add(2);
                        }
                    }
                }
            }
            if (isSuccess())
            {
                timer.Stop();
                LoadData load = new LoadData();
                int time = Int32.Parse(labelTime.Text);
                int minTime = Int32.Parse(labelTimeByTime.Text);
                bool isHighScore = false;
                if(time < minTime || minTime == 0)
                {
                    load.updateScore(labelTime.Text, labelCount.Text, 1, level, "Time");
                    MessageBox.Show("You are victory! New Min Time Score!", "Alert");
                    isHighScore = true;
                    load.loadTimeScore(labelCountByTime, labelTimeByTime, level, "");
                }
                int minCount = Int32.Parse(labelCountByCount.Text);
                if(count < minCount || minCount == 0)
                {
                    load.updateScore(labelTime.Text, labelCount.Text, 1, level, "Count");
                    MessageBox.Show("You are victory! New Min Count Score!", "Alert");
                    isHighScore = true;
                    load.loadCountScore(labelCountByCount, labelTimeByCount, level, "");
                }
                if(!isHighScore)
                {
                    MessageBox.Show("You are victory!", "Alert");
                }
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
        
        internal void undo()
        {
            if(listMove.Count == 0)
            {
                MessageBox.Show("Out of move!", "Alert");
            } else
            {
                for(int i = 0; i < level; i++)
                {
                    for(int j = 0; j < level; j++)
                    {
                        if(buttons[i, j].Text.Equals(""))
                        {
                            switch (listMove[listMove.Count - 1])
                            {
                                case 1:
                                    swapButton(buttons[i, j], buttons[i - 1, j]);
                                    break;
                                case 2:
                                    swapButton(buttons[i, j], buttons[i, j + 1]);
                                    break;
                                case 3:
                                    swapButton(buttons[i, j], buttons[i  + 1, j]);
                                    break;
                                case 4:
                                    swapButton(buttons[i, j], buttons[i, j - 1]);
                                    break;
                            }
                            i = level;
                            j = level;
                        }
                    }

                }
                listMove.RemoveAt(listMove.Count - 1);
                count--;
                labelCount.Text = count.ToString();
            }
        }

        public bool isSuccess()
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    if(i == level - 1 && j == level - 1)
                    {
                        break;
                    }
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
