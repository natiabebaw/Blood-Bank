﻿namespace BloodBank.Forms.Request
{
    partial class RequestTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_deleteDonor = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateDonor = new Guna.UI2.WinForms.Guna2Button();
            this.dataGrid_donor = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_donor)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBox1.Location = new System.Drawing.Point(254, 7);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(230, 36);
            this.guna2TextBox1.TabIndex = 10;
            // 
            // btn_deleteDonor
            // 
            this.btn_deleteDonor.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteDonor.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_deleteDonor.BorderRadius = 20;
            this.btn_deleteDonor.CheckedState.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.CustomImages.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteDonor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteDonor.ForeColor = System.Drawing.Color.White;
            this.btn_deleteDonor.HoverState.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteDonor.Image")));
            this.btn_deleteDonor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_deleteDonor.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_deleteDonor.Location = new System.Drawing.Point(421, 446);
            this.btn_deleteDonor.Name = "btn_deleteDonor";
            this.btn_deleteDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_deleteDonor.ShadowDecoration.Parent = this.btn_deleteDonor;
            this.btn_deleteDonor.Size = new System.Drawing.Size(140, 40);
            this.btn_deleteDonor.TabIndex = 9;
            this.btn_deleteDonor.Text = "Delete";
            this.btn_deleteDonor.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_deleteDonor.UseTransparentBackground = true;
            // 
            // btn_updateDonor
            // 
            this.btn_updateDonor.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateDonor.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_updateDonor.BorderRadius = 20;
            this.btn_updateDonor.CheckedState.Parent = this.btn_updateDonor;
            this.btn_updateDonor.CustomImages.Parent = this.btn_updateDonor;
            this.btn_updateDonor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_updateDonor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDonor.ForeColor = System.Drawing.Color.White;
            this.btn_updateDonor.HoverState.Parent = this.btn_updateDonor;
            this.btn_updateDonor.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateDonor.Image")));
            this.btn_updateDonor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_updateDonor.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_updateDonor.Location = new System.Drawing.Point(220, 446);
            this.btn_updateDonor.Name = "btn_updateDonor";
            this.btn_updateDonor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_updateDonor.ShadowDecoration.Parent = this.btn_updateDonor;
            this.btn_updateDonor.Size = new System.Drawing.Size(140, 40);
            this.btn_updateDonor.TabIndex = 8;
            this.btn_updateDonor.Text = "Update";
            this.btn_updateDonor.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_updateDonor.UseTransparentBackground = true;
            // 
            // dataGrid_donor
            // 
            this.dataGrid_donor.AllowUserToDeleteRows = false;
            this.dataGrid_donor.AllowUserToResizeColumns = false;
            this.dataGrid_donor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_donor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_donor.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_donor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_donor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_donor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_donor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_donor.ColumnHeadersHeight = 28;
            this.dataGrid_donor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_donor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_donor.EnableHeadersVisualStyles = false;
            this.dataGrid_donor.GridColor = System.Drawing.Color.Red;
            this.dataGrid_donor.Location = new System.Drawing.Point(-1, 51);
            this.dataGrid_donor.Name = "dataGrid_donor";
            this.dataGrid_donor.ReadOnly = true;
            this.dataGrid_donor.RowHeadersVisible = false;
            this.dataGrid_donor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid_donor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_donor.Size = new System.Drawing.Size(754, 387);
            this.dataGrid_donor.TabIndex = 7;
            this.dataGrid_donor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid_donor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid_donor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGrid_donor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid_donor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_donor.ThemeStyle.HeaderStyle.Height = 28;
            this.dataGrid_donor.ThemeStyle.ReadOnly = true;
            this.dataGrid_donor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid_donor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_donor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGrid_donor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid_donor.ThemeStyle.RowsStyle.Height = 22;
            this.dataGrid_donor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid_donor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RequestTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 493);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btn_deleteDonor);
            this.Controls.Add(this.btn_updateDonor);
            this.Controls.Add(this.dataGrid_donor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestTable";
            this.Text = "RequestTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_donor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btn_deleteDonor;
        private Guna.UI2.WinForms.Guna2Button btn_updateDonor;
        private Guna.UI2.WinForms.Guna2DataGridView dataGrid_donor;
    }
}