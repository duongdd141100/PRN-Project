
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
            this.label1.Location = new System.Drawing.Point(243, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Level:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(371, 297);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(19, 20);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(371, 328);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(19, 20);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "0";
            // 
            // boxLevel
            // 
            this.boxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLevel.FormattingEnabled = true;
            this.boxLevel.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5"});
            this.boxLevel.Location = new System.Drawing.Point(375, 356);
            this.boxLevel.Margin = new System.Windows.Forms.Padding(2);
            this.boxLevel.Name = "boxLevel";
            this.boxLevel.Size = new System.Drawing.Size(112, 28);
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
            this.panelTable.Location = new System.Drawing.Point(9, 15);
            this.panelTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelTable.Name = "panelTable";
            this.panelTable.RowCount = 2;
            this.panelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTable.Size = new System.Drawing.Size(254, 258);
            this.panelTable.TabIndex = 8;
            this.panelTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTable_Paint);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.MistyRose;
            this.btnNewGame.Location = new System.Drawing.Point(219, 404);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(101, 44);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "NewGame";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(427, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(270, 270);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Location = new System.Drawing.Point(385, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 44);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PuzzelGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 493);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Form1";
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
    }
}

