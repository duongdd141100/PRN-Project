using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace PuzzelGame
{
    public partial class GameForm : Form
    {
        int level;
        public int count = 0;
        String imgPath;
        ControllerImg controllerImg;
        ControllerClassic controllerClassic;

        public GameForm() { }
        public GameForm(String imgPath)
        {
            InitializeComponent();
            this.imgPath = imgPath;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }
        private void form_Load(object sender, EventArgs e)
        {
            controllerClassic = new ControllerClassic(panelTable, level, labelCount, timer, labelTime, labelCountByCount, labelTimeByTime, labelTimeByCount, labelCountByTime);
            controllerImg = new ControllerImg(panelTable, level, imgPath, labelCount, timer, labelTime, labelCountByCount, labelTimeByTime, labelTimeByCount, labelCountByTime);
            if (imgPath.Equals("img1"))
            {
                pictureBox.Image = controllerImg.resizeImage(PuzzelGame.Properties.Resources.img1, new Size(270, 270));
            }
            else if (imgPath.Equals("img2"))
            {
                pictureBox.Image = controllerImg.resizeImage(PuzzelGame.Properties.Resources.img2, new Size(270, 270));
            }
            else if (imgPath.Equals("img3"))
            {
                pictureBox.Image = controllerImg.resizeImage(PuzzelGame.Properties.Resources.img3, new Size(270, 270));
            }
            else if (String.IsNullOrEmpty(imgPath))
            {
                this.Controls.Remove(pictureBox);
            }
            else
            {
                pictureBox.Image = controllerImg.resizeImage(Image.FromFile(imgPath), new Size(270, 270));
            }
            LoadData load = new LoadData();
            load.loadLevel(boxLevel);
            boxLevel.SelectedIndex = 0;
            load.loadCountScore(labelCountByCount, labelTimeByCount, level, imgPath);
            load.loadTimeScore(labelCountByTime, labelTimeByTime, level, imgPath);
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
            count = 0;
            labelCount.Text = "0";
            labelTime.Text = "0";
            panelTable.Controls.Clear();
            timer.Stop();
            level = getLevel();
            if (String.IsNullOrEmpty(imgPath))
            {
                controllerClassic = new ControllerClassic(panelTable, level, labelCount, timer, labelTime, labelCountByCount, labelTimeByTime, labelTimeByCount, labelCountByTime);
                controllerClassic.designButton();
            } else
            {
                controllerImg = new ControllerImg(panelTable, level, imgPath, labelCount, timer, labelTime, labelCountByCount, labelTimeByTime, labelTimeByCount, labelCountByTime);
                controllerImg.designButton();
            }
                
        }

        

        
        
        

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            count = 0;
            labelCount.Text = "0";
            boxLevel_SelectedIndexChanged(sender,e);
            if (String.IsNullOrEmpty(imgPath))
            {
                controllerClassic.randomButton();
            }
            else
            {
                controllerImg.randomButton();

            }
            timer.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseGameType chooseGameType = new ChooseGameType();
            chooseGameType.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count++;
            labelTime.Text = count.ToString();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(imgPath))
            {
                controllerClassic.undo();
            } else
            {
                controllerImg.undo();
            }
        }
    }
}
