using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using BUS;

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

        //private void loadLevel()
        //{
        //    boxLevel.Items.Add("3x3");
        //    //LevelBUS levelBUS = new LevelBUS();
        //    //DataTable dataTable = levelBUS.getLevel();
        //    //boxLevel.DataSource = dataTable;

        //}

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
                controllerClassic = new ControllerClassic(panelTable, level, labelCount,timer);
                controllerClassic.designButton();
            } else
            {
                controllerImg = new ControllerImg(panelTable, level, imgPath, labelCount, timer);
                controllerImg.designButton();
            }
                
        }

        private void panelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {
            controllerImg = new ControllerImg(panelTable, level, imgPath, labelCount, timer);
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
            //loadLevel();
            boxLevel.SelectedIndex = 0;
            level = getLevel();
            // TODO: This line of code loads data into the 'pROJECT_PRNDataSet.Level' table. You can move, or remove it, as needed.
            //this.levelTableAdapter.Fill(this.pROJECT_PRNDataSet.Level);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        

        private void btnNewGame_Click(object sender, EventArgs e)
        {

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
    }
}
