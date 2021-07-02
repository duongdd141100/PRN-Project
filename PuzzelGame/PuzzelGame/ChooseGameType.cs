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
        String imgPath;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(imgPath))
            {
                MessageBox.Show("Please choose one image to play!", "Alert");
            }
            else
            {
                this.Hide();
                GameForm f = new GameForm(imgPath);
                f.Show();
            }
        }
        private void img1_Click(object sender, EventArgs e)
        {
            imgPath = "img1";
            img1.Tag = Color.Blue;
            img2.Tag = Color.White;
            img3.Tag = Color.White;
            userImg.Tag = Color.White;
            refreshImg();
        }
        private void img2_Click(object sender, EventArgs e)
        {
            imgPath = "img2";
            img1.Tag = Color.White;
            img2.Tag = Color.Blue;
            img3.Tag = Color.White;
            userImg.Tag = Color.White;
            refreshImg();
        }
        private void img3_Click(object sender, EventArgs e)
        {
            imgPath = "img3";
            img1.Tag = Color.White;
            img2.Tag = Color.White;
            img3.Tag = Color.Blue;
            userImg.Tag = Color.White;
            refreshImg();
        }

        private void img1_Paint(object sender, PaintEventArgs e)
        {
            if(img1.Tag == null)
            {
                img1.Tag = Color.White;
            }
            ControlPaint.DrawBorder(e.Graphics, img1.ClientRectangle, (Color)img1.Tag, ButtonBorderStyle.Solid);
        }

        private void img2_Paint(object sender, PaintEventArgs e)
        {
            if (img2.Tag == null)
            {
                img2.Tag = Color.White;
            }
            ControlPaint.DrawBorder(e.Graphics, img2.ClientRectangle, (Color)img2.Tag, ButtonBorderStyle.Solid);
        }

        private void img3_Paint(object sender, PaintEventArgs e)
        {
            if (img3.Tag == null)
            {
                img3.Tag = Color.White;
            }
            ControlPaint.DrawBorder(e.Graphics, img3.ClientRectangle, (Color)img3.Tag, ButtonBorderStyle.Solid);
        }

        private void refreshImg()
        {
            img1.Refresh();
            img2.Refresh();
            img3.Refresh();
            userImg.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgPath = open.FileName;
                userImg.ImageLocation = imgPath;
                userImg.Image = Image.FromFile(imgPath);
                userImg_Click(sender, e);
            }
        }

        private void userImg_Click(object sender, EventArgs e)
        {
            imgPath = userImg.ImageLocation;
            img1.Tag = Color.White;
            img2.Tag = Color.White;
            img3.Tag = Color.White;
            userImg.Tag = Color.Blue;
            refreshImg();
        }

        private void userImg_Paint(object sender, PaintEventArgs e)
        {

            if (userImg.Tag == null)
            {
                userImg.Tag = Color.White;
            }
            ControlPaint.DrawBorder(e.Graphics, userImg.ClientRectangle, (Color)userImg.Tag, ButtonBorderStyle.Solid);
        }
    }
}
