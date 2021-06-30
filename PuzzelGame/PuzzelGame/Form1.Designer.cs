
namespace PuzzelGame
{
    partial class Form1
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
            this.buttonDuc = new System.Windows.Forms.Button();
            this.buttonDuong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDuc
            // 
            this.buttonDuc.Location = new System.Drawing.Point(104, 71);
            this.buttonDuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDuc.Name = "buttonDuc";
            this.buttonDuc.Size = new System.Drawing.Size(132, 62);
            this.buttonDuc.TabIndex = 0;
            this.buttonDuc.Text = "Duc";
            this.buttonDuc.UseVisualStyleBackColor = true;
            this.buttonDuc.Click += new System.EventHandler(this.buttonDuc_Click);
            // 
            // buttonDuong
            // 
            this.buttonDuong.Location = new System.Drawing.Point(454, 85);
            this.buttonDuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDuong.Name = "buttonDuong";
            this.buttonDuong.Size = new System.Drawing.Size(132, 62);
            this.buttonDuong.TabIndex = 1;
            this.buttonDuong.Text = "Duong";
            this.buttonDuong.UseVisualStyleBackColor = true;
            this.buttonDuong.Click += new System.EventHandler(this.buttonDuong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDuong);
            this.Controls.Add(this.buttonDuc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDuc;
        private System.Windows.Forms.Button buttonDuong;
        private System.Windows.Forms.Label label1;
    }
}

