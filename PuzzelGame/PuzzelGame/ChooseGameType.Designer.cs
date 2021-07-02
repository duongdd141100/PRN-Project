
namespace PuzzelGame
{
    partial class ChooseGameType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClassic = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.userImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose from file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClassic
            // 
            this.buttonClassic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClassic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClassic.Location = new System.Drawing.Point(445, 186);
            this.buttonClassic.Name = "buttonClassic";
            this.buttonClassic.Size = new System.Drawing.Size(163, 73);
            this.buttonClassic.TabIndex = 1;
            this.buttonClassic.Text = "Classic";
            this.buttonClassic.UseVisualStyleBackColor = false;
            this.buttonClassic.Click += new System.EventHandler(this.buttonClassic_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(377, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Play With Image";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to PUZZLE GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "What kind of game do you want to play?";
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.img1.BackgroundImage = global::PuzzelGame.Properties.Resources.img1;
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img1.Location = new System.Drawing.Point(176, 390);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(182, 176);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 5;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.img1_Click);
            this.img1.Paint += new System.Windows.Forms.PaintEventHandler(this.img1_Paint);
            // 
            // img2
            // 
            this.img2.BackgroundImage = global::PuzzelGame.Properties.Resources.img2;
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.img2.Location = new System.Drawing.Point(426, 390);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(182, 176);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 6;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.img2_Click);
            this.img2.Paint += new System.Windows.Forms.PaintEventHandler(this.img2_Paint);
            // 
            // img3
            // 
            this.img3.BackgroundImage = global::PuzzelGame.Properties.Resources.img3;
            this.img3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img3.Location = new System.Drawing.Point(686, 390);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(182, 176);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 7;
            this.img3.TabStop = false;
            this.img3.Click += new System.EventHandler(this.img3_Click);
            this.img3.Paint += new System.Windows.Forms.PaintEventHandler(this.img3_Paint);
            // 
            // userImg
            // 
            this.userImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userImg.Location = new System.Drawing.Point(533, 599);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(182, 176);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 8;
            this.userImg.TabStop = false;
            this.userImg.Click += new System.EventHandler(this.userImg_Click);
            this.userImg.Paint += new System.Windows.Forms.PaintEventHandler(this.userImg_Paint);
            // 
            // ChooseGameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuzzelGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 922);
            this.Controls.Add(this.userImg);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonClassic);
            this.Controls.Add(this.button1);
            this.Name = "ChooseGameType";
            this.Text = "ChooseGameType";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClassic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox userImg;
    }
}