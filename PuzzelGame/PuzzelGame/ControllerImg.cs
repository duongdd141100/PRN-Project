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
        private Button[,] buttons;
        private Bitmap[,] bmps;
        private String imgPath;
        Label labelCount;

        public ControllerImg(TableLayoutPanel panel, int level, String imgPath, Label labelCount)
        {
            this.panel = panel;
            this.level = level;
            this.imgPath = imgPath;
            this.labelCount = labelCount;
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
                    if (buttons[i, j].BackgroundImage == null)
                    {
                        if (i < level - 1 && sender == buttons[i + 1, j])
                        {
                            buttons[i, j].BackgroundImage = buttons[i + 1, j].BackgroundImage;
                            buttons[i + 1, j].BackgroundImage = null;
                        }
                        if (i > 0 && sender == buttons[i - 1, j])
                        {
                            buttons[i, j].BackgroundImage = buttons[i - 1, j].BackgroundImage;
                            buttons[i - 1, j].BackgroundImage = null;
                        }
                        if (j < level - 1 && sender == buttons[i, j + 1])
                        {
                            buttons[i, j].BackgroundImage = buttons[i, j + 1].BackgroundImage;
                            buttons[i, j + 1].BackgroundImage = null;
                        }
                        if (j > 0 && sender == buttons[i, j - 1])
                        {
                            buttons[i, j].BackgroundImage = buttons[i, j - 1].BackgroundImage;
                            buttons[i, j - 1].BackgroundImage = null;
                        }
                    }
                }
            }
            //int count = Int32.Parse(labelCount.Text);
            labelCount.Text = (++count).ToString();
            if (checkSuccess())
            {
                MessageBox.Show("you win");
            }


        }

        internal void designButton()
        {
            panel.Location = new Point(5, 5);
            buttons = new Button[level, level];
            Image img = Image.FromFile("Images\\MyBae2.jpeg");
            //img.Width = 210;
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
                    buttons[i, j].Click += ButtonHanler;
                    panel.Controls.Add(buttons[i, j]);
                }
            }
            buttons[level - 1, level - 1].BackgroundImage = null;


            randomButton();
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

        public void randomButton()
        {
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
                            buttons[rowIndex, colIndex].BackgroundImage = buttons[rowIndex - 1, colIndex].BackgroundImage;
                            buttons[rowIndex - 1, colIndex].BackgroundImage = null;
                            rowIndex -= 1;
                        }
                        break;

                    //right
                    case 2:
                        if (colIndex < level - 1)
                        {
                            buttons[rowIndex, colIndex].BackgroundImage = buttons[rowIndex, colIndex + 1].BackgroundImage;
                            buttons[rowIndex, colIndex + 1].BackgroundImage = null;
                            colIndex += 1;
                        }
                        break;
                    //down
                    case 3:
                        if (rowIndex < level - 1)
                        {
                            buttons[rowIndex, colIndex].BackgroundImage = buttons[rowIndex + 1, colIndex].BackgroundImage;
                            buttons[rowIndex + 1, colIndex].BackgroundImage = null;
                            rowIndex += 1;
                        }
                        break;
                    //left
                    case 4:
                        if (colIndex > 0)
                        {
                            buttons[rowIndex, colIndex].BackgroundImage = buttons[rowIndex, colIndex - 1].BackgroundImage;
                            buttons[rowIndex, colIndex - 1].BackgroundImage = null;
                            colIndex -= 1;
                        }
                        break;
                }
            }
        }
        private static Image resizeImage(Image imgToResize, Size size)
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
