using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PuzzelGame
{
    class ControllerImg
    {
        private TableLayoutPanel panel;
        private int level;
        private Timer timer;
        private Button[,] buttons;
        private Bitmap[,] bmps;
        private String imgPath;
        private Label labelCount;
        private Label labelTime;
        private Label labelCountByCount;
        private Label labelTimeByTime;
        private Label labelTimeByCount;
        private Label labelCountByTime;
        private List<int> listMove = new List<int>();
        public ControllerImg() { }

        public ControllerImg(TableLayoutPanel panel, int level, String imgPath, Label labelCount, Timer timer, Label labelTime, Label labelCountByCount, Label labelTimeByTime, Label labelTimeByCount, Label labelCountByTime)
        {
            this.panel = panel;
            this.level = level;
            this.imgPath = imgPath;
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
                    if (buttons[i, j].BackgroundImage==null)
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
            if (checkSuccess())
            {
                timer.Stop();
                LoadData load = new LoadData();
                int time = Int32.Parse(labelTime.Text);
                int minTime = Int32.Parse(labelTimeByTime.Text);
                bool isHighScore = false;
                if (time < minTime || minTime == 0)
                {
                    load.updateScore(labelTime.Text, labelCount.Text, 2, level, "Time");
                    MessageBox.Show("You are victory! New Min Time Score!", "Alert");
                    load.loadTimeScore(labelCountByTime, labelTimeByTime, level, imgPath);
                    isHighScore = true;
                }
                int minCount = Int32.Parse(labelCountByCount.Text);
                if (count < minCount || minCount == 0)
                {
                    load.updateScore(labelTime.Text, labelCount.Text, 2, level, "Count");
                    MessageBox.Show("You are victory! New Min Count Score!", "Alert");
                    load.loadCountScore(labelCountByCount, labelTimeByCount, level, imgPath);
                    isHighScore = true;
                }
                if (!isHighScore)
                {
                    MessageBox.Show("You are victory!", "Alert");
                }
            }
        }
        internal void undo()
        {
            if (listMove.Count == 0)
            {
                MessageBox.Show("Out of move!", "Alert");
            }
            else
            {
                for (int i = 0; i < level; i++)
                {
                    for (int j = 0; j < level; j++)
                    {
                        if (buttons[i, j].BackgroundImage == null)
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
                                    swapButton(buttons[i, j], buttons[i + 1, j]);
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
        internal void designButton()
        {
            panel.Location = new Point(5, 5);
            buttons = new Button[level, level];
            Image img;
            if(imgPath.Equals("img1"))
            {
                img = PuzzelGame.Properties.Resources.img1;
            } else if (imgPath.Equals("img2"))
            {
                img = PuzzelGame.Properties.Resources.img2;
            }
            else if (imgPath.Equals("img3"))
            {
                img = PuzzelGame.Properties.Resources.img3;
            } else
            {
                img = Image.FromFile(imgPath);
            }
            img = resizeImage(img, new Size(250, 250));
            int widthThird = (int)((double)img.Width / level);
            int heightThird = (int)((double)img.Height / level);
            bmps = new Bitmap[level, level];
            for (int i = 0; i < level; i++)
                for (int j = 0; j < level; j++)
                {
                    bmps[i, j] = new Bitmap(widthThird, heightThird);
                    Graphics g = Graphics.FromImage(bmps[i, j]);
                    g.DrawImage(img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                    g.Dispose();
                }
            bmps[level - 1, level - 1] = null;

            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    buttons[i, j] = new Button();
                    //buttons[i, j].Text = (i * level + j + 1) + "";
                    //Console.WriteLine(panel.Width + " " + level);
                    //Console.WriteLine(panel.Width / level + "," + panel.Height / level);
                    buttons[i, j].BackgroundImage = bmps[i, j];
                    buttons[i, j].Size = new Size(img.Width / level, img.Height / level);
                    buttons[i, j].Enabled = false;
                    buttons[i, j].Click += ButtonHanler;
                    panel.Controls.Add(buttons[i, j]);
                }
            }
            buttons[level - 1, level - 1].BackgroundImage = null;
        }

        public bool checkSuccess()
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    if (buttons[i, j].BackgroundImage != bmps[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void swapButton(Button a, Button b)
        {
            a.BackgroundImage = b.BackgroundImage;
            b.BackgroundImage = null;
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
        public Image resizeImage(Image imgToResize, Size size)
        {
            //New Width  
            int destWidth = size.Width;
            //New Height  
            int destHeight = size.Height;
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (Image)b;
        }
    }
}
