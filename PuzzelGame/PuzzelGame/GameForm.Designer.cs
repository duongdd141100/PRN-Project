
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.boxLevel = new System.Windows.Forms.ComboBox();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_PRNDataSet = new PuzzelGame.PROJECT_PRNDataSet();
            this.panelTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.levelTableAdapter = new PuzzelGame.PROJECT_PRNDataSetTableAdapters.LevelTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCountByCount = new System.Windows.Forms.Label();
            this.labelCountByTime = new System.Windows.Forms.Label();
            this.labelTimeByCount = new System.Windows.Forms.Label();
            this.labelTimeByTime = new System.Windows.Forms.Label();
            this.buttonUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_PRNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 543);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 603);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 659);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(372, 543);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(36, 37);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(372, 603);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "0";
            // 
            // boxLevel
            // 
            this.boxLevel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLevel.FormattingEnabled = true;
            this.boxLevel.Location = new System.Drawing.Point(380, 657);
            this.boxLevel.Margin = new System.Windows.Forms.Padding(4);
            this.boxLevel.Name = "boxLevel";
            this.boxLevel.Size = new System.Drawing.Size(220, 45);
            this.boxLevel.TabIndex = 6;
            this.boxLevel.SelectedIndexChanged += new System.EventHandler(this.boxLevel_SelectedIndexChanged);
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataMember = "Level";
            this.levelBindingSource.DataSource = this.pROJECT_PRNDataSet;
            // 
            // pROJECT_PRNDataSet
            // 
            this.pROJECT_PRNDataSet.DataSetName = "PROJECT_PRNDataSet";
            this.pROJECT_PRNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTable
            // 
            this.panelTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTable.AutoSize = true;
            this.panelTable.BackColor = System.Drawing.Color.Transparent;
            this.panelTable.ColumnCount = 3;
            this.panelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTable.Location = new System.Drawing.Point(109, 23);
            this.panelTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelTable.Name = "panelTable";
            this.panelTable.RowCount = 2;
            this.panelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTable.Size = new System.Drawing.Size(508, 496);
            this.panelTable.TabIndex = 8;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.MistyRose;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(626, 777);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(202, 85);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "NewGame";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(835, 23);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(481, 496);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1018, 777);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(202, 85);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // levelTableAdapter
            // 
            this.levelTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(969, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "HIGH SCORE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(880, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "By Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(880, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "By Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1021, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Count:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1021, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Count:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1176, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1176, 659);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 31);
            this.label10.TabIndex = 19;
            this.label10.Text = "Time:";
            // 
            // labelCountByCount
            // 
            this.labelCountByCount.AutoSize = true;
            this.labelCountByCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCountByCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountByCount.Location = new System.Drawing.Point(1122, 603);
            this.labelCountByCount.Name = "labelCountByCount";
            this.labelCountByCount.Size = new System.Drawing.Size(30, 31);
            this.labelCountByCount.TabIndex = 20;
            this.labelCountByCount.Text = "0";
            // 
            // labelCountByTime
            // 
            this.labelCountByTime.AutoSize = true;
            this.labelCountByTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCountByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountByTime.Location = new System.Drawing.Point(1122, 659);
            this.labelCountByTime.Name = "labelCountByTime";
            this.labelCountByTime.Size = new System.Drawing.Size(30, 31);
            this.labelCountByTime.TabIndex = 21;
            this.labelCountByTime.Text = "0";
            // 
            // labelTimeByCount
            // 
            this.labelTimeByCount.AutoSize = true;
            this.labelTimeByCount.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeByCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeByCount.Location = new System.Drawing.Point(1247, 603);
            this.labelTimeByCount.Name = "labelTimeByCount";
            this.labelTimeByCount.Size = new System.Drawing.Size(30, 31);
            this.labelTimeByCount.TabIndex = 22;
            this.labelTimeByCount.Text = "0";
            // 
            // labelTimeByTime
            // 
            this.labelTimeByTime.AutoSize = true;
            this.labelTimeByTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeByTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeByTime.Location = new System.Drawing.Point(1247, 659);
            this.labelTimeByTime.Name = "labelTimeByTime";
            this.labelTimeByTime.Size = new System.Drawing.Size(30, 31);
            this.labelTimeByTime.TabIndex = 23;
            this.labelTimeByTime.Text = "0";
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndo.Location = new System.Drawing.Point(224, 777);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(202, 85);
            this.buttonUndo.TabIndex = 24;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PuzzelGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 948);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.labelTimeByTime);
            this.Controls.Add(this.labelTimeByCount);
            this.Controls.Add(this.labelCountByTime);
            this.Controls.Add(this.labelCountByCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.boxLevel);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_PRNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Timer timer;
        private PROJECT_PRNDataSet pROJECT_PRNDataSet;
        private System.Windows.Forms.BindingSource levelBindingSource;
        private PROJECT_PRNDataSetTableAdapters.LevelTableAdapter levelTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCountByCount;
        private System.Windows.Forms.Label labelCountByTime;
        private System.Windows.Forms.Label labelTimeByCount;
        private System.Windows.Forms.Label labelTimeByTime;
        private System.Windows.Forms.Button buttonUndo;
    }
}

