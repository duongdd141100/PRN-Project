
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonClassic
            // 
            this.buttonClassic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClassic.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.button3.Location = new System.Drawing.Point(445, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // ChooseGameType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuzzelGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 794);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonClassic);
            this.Controls.Add(this.button1);
            this.Name = "ChooseGameType";
            this.Text = "ChooseGameType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClassic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}