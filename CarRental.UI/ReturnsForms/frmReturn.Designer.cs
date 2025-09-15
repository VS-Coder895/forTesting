namespace CarRental.UI
{
    partial class frmReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewReturns = new Guna.UI2.WinForms.Guna2DataGridView();
            this.conMenuReturns = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.DetailsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturns)).BeginInit();
            this.conMenuReturns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BorderRadius = 10;
            this.pnlTitle.Controls.Add(this.guna2HtmlLabel1);
            this.pnlTitle.CustomizableEdges.TopLeft = false;
            this.pnlTitle.CustomizableEdges.TopRight = false;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.pnlTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1076, 95);
            this.pnlTitle.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Azure;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(421, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(170, 71);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Returns";
            // 
            // dataGridViewReturns
            // 
            this.dataGridViewReturns.AllowUserToAddRows = false;
            this.dataGridViewReturns.AllowUserToDeleteRows = false;
            this.dataGridViewReturns.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewReturns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReturns.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReturns.ColumnHeadersHeight = 30;
            this.dataGridViewReturns.ContextMenuStrip = this.conMenuReturns;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReturns.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReturns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewReturns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewReturns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReturns.Location = new System.Drawing.Point(0, 199);
            this.dataGridViewReturns.MultiSelect = false;
            this.dataGridViewReturns.Name = "dataGridViewReturns";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturns.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReturns.RowHeadersVisible = false;
            this.dataGridViewReturns.RowHeadersWidth = 51;
            this.dataGridViewReturns.RowTemplate.Height = 26;
            this.dataGridViewReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReturns.Size = new System.Drawing.Size(1076, 548);
            this.dataGridViewReturns.TabIndex = 1;
            this.dataGridViewReturns.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReturns.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewReturns.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewReturns.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewReturns.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewReturns.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.dataGridViewReturns.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReturns.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewReturns.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewReturns.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGridViewReturns.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewReturns.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewReturns.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridViewReturns.ThemeStyle.ReadOnly = false;
            this.dataGridViewReturns.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReturns.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReturns.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dataGridViewReturns.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReturns.ThemeStyle.RowsStyle.Height = 26;
            this.dataGridViewReturns.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReturns.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // conMenuReturns
            // 
            this.conMenuReturns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuReturns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailsStripMenuItem,
            this.UpdateStripMenuItem,
            this.DeleteStripMenuItem});
            this.conMenuReturns.Name = "conMenuReturns";
            this.conMenuReturns.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.conMenuReturns.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.conMenuReturns.RenderStyle.ColorTable = null;
            this.conMenuReturns.RenderStyle.RoundedEdges = true;
            this.conMenuReturns.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conMenuReturns.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.conMenuReturns.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.conMenuReturns.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.conMenuReturns.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.conMenuReturns.Size = new System.Drawing.Size(128, 76);
            // 
            // DetailsStripMenuItem
            // 
            this.DetailsStripMenuItem.Name = "DetailsStripMenuItem";
            this.DetailsStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.DetailsStripMenuItem.Text = "Details";
            this.DetailsStripMenuItem.Click += new System.EventHandler(this.DetailstoolStripMenuItem_Click);
            // 
            // UpdateStripMenuItem
            // 
            this.UpdateStripMenuItem.Name = "UpdateStripMenuItem";
            this.UpdateStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.UpdateStripMenuItem.Text = "Update";
            this.UpdateStripMenuItem.Click += new System.EventHandler(this.UpdateStripMenuItem_Click);
            // 
            // DeleteStripMenuItem
            // 
            this.DeleteStripMenuItem.Name = "DeleteStripMenuItem";
            this.DeleteStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.DeleteStripMenuItem.Text = "Delete";
            this.DeleteStripMenuItem.Click += new System.EventHandler(this.DeleteStripMenuItem_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxFilter.BorderRadius = 10;
            this.comboBoxFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FocusedColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxFilter.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxFilter.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxFilter.ItemHeight = 20;
            this.comboBoxFilter.Location = new System.Drawing.Point(17, 109);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(210, 26);
            this.comboBoxFilter.TabIndex = 3;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderRadius = 10;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSearch.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtBoxSearch.IconLeft = global::CarRental.UI.Properties.Resources.search1;
            this.txtBoxSearch.Location = new System.Drawing.Point(17, 149);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(210, 36);
            this.txtBoxSearch.TabIndex = 2;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1076, 747);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.dataGridViewReturns);
            this.Name = "frmReturn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturns)).EndInit();
            this.conMenuReturns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewReturns;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conMenuReturns;
        private System.Windows.Forms.ToolStripMenuItem DetailsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenuItem;
    }
}