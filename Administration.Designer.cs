﻿namespace GorselHW1_IsmailTunaSeydisehirli
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Sname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.DellButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetbttn = new System.Windows.Forms.Button();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DellButton
            // 
            this.DellButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DellButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DellButton.Location = new System.Drawing.Point(463, 410);
            this.DellButton.Name = "DellButton";
            this.DellButton.Size = new System.Drawing.Size(90, 28);
            this.DellButton.TabIndex = 55;
            this.DellButton.Text = "Delete";
            this.DellButton.UseVisualStyleBackColor = false;
            this.DellButton.Click += new System.EventHandler(this.DellButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchButton.Location = new System.Drawing.Point(463, 85);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 31);
            this.SearchButton.TabIndex = 43;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchBox.Location = new System.Drawing.Point(463, 53);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(165, 26);
            this.SearchBox.TabIndex = 42;
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchText.Location = new System.Drawing.Point(463, 27);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(101, 19);
            this.SearchText.TabIndex = 41;
            this.SearchText.Text = "Item to Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffDutyDataGridViewTextBoxColumn,
            this.staffDivisionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 411);
            this.dataGridView1.TabIndex = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // resetbttn
            // 
            this.resetbttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetbttn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.resetbttn.Location = new System.Drawing.Point(571, 85);
            this.resetbttn.Name = "resetbttn";
            this.resetbttn.Size = new System.Drawing.Size(57, 32);
            this.resetbttn.TabIndex = 61;
            this.resetbttn.Text = "reset";
            this.resetbttn.UseVisualStyleBackColor = false;
            this.resetbttn.Click += new System.EventHandler(this.resetbttn_Click);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // staffDutyDataGridViewTextBoxColumn
            // 
            this.staffDutyDataGridViewTextBoxColumn.DataPropertyName = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.HeaderText = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.Name = "staffDutyDataGridViewTextBoxColumn";
            // 
            // staffDivisionDataGridViewTextBoxColumn
            // 
            this.staffDivisionDataGridViewTextBoxColumn.DataPropertyName = "Staff_Division";
            this.staffDivisionDataGridViewTextBoxColumn.HeaderText = "Staff_Division";
            this.staffDivisionDataGridViewTextBoxColumn.Name = "staffDivisionDataGridViewTextBoxColumn";
            // 
            // staffDBBindingSource
            // 
            this.staffDBBindingSource.DataSource = typeof(GorselHW1_IsmailTunaSeydisehirli.StaffDB);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.resetbttn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DellButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DellButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button resetbttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffDBBindingSource;
    }
}