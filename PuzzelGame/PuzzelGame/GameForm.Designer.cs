
namespace PuzzelGame
{
    partial class GameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.boxLevel = new System.Windows.Forms.ComboBox();
            this.panelTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(352, 11);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(354, 34);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(13, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "0";
            // 
            // boxLevel
            // 
            this.boxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLevel.FormattingEnabled = true;
            this.boxLevel.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5"});
            this.boxLevel.Location = new System.Drawing.Point(357, 57);
            this.boxLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxLevel.Name = "boxLevel";
            this.boxLevel.Size = new System.Drawing.Size(62, 21);
            this.boxLevel.TabIndex = 6;
            this.boxLevel.SelectedIndexChanged += new System.EventHandler(this.boxLevel_SelectedIndexChanged);
            // 
            // panelTable
            // 
            this.panelTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTable.AutoSize = true;
            this.panelTable.ColumnCount = 3;
            this.panelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTable.Location = new System.Drawing.Point(9, 13);
            this.panelTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelTable.Name = "panelTable";
            this.panelTable.RowCount = 2;
            this.panelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTable.Size = new System.Drawing.Size(250, 260);
            this.panelTable.TabIndex = 8;
            this.panelTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTable_Paint);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(436, 479);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.boxLevel);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox boxLevel;
        private System.Windows.Forms.TableLayoutPanel panelTable;
    }
}

