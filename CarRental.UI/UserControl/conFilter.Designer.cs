namespace CarRental.UI
{
    partial class conFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.comboBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grpBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.BorderColor = System.Drawing.Color.LightGray;
            this.grpBoxFilter.BorderRadius = 6;
            this.grpBoxFilter.Controls.Add(this.comboBoxFilter);
            this.grpBoxFilter.Controls.Add(this.btnFilter);
            this.grpBoxFilter.Controls.Add(this.txtBoxSearch);
            this.grpBoxFilter.Controls.Add(this.guna2HtmlLabel1);
            this.grpBoxFilter.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.grpBoxFilter.CustomizableEdges.BottomLeft = false;
            this.grpBoxFilter.CustomizableEdges.BottomRight = false;
            this.grpBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxFilter.FillColor = System.Drawing.Color.Azure;
            this.grpBoxFilter.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.grpBoxFilter.ForeColor = System.Drawing.Color.White;
            this.grpBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(493, 89);
            this.grpBoxFilter.TabIndex = 310;
            this.grpBoxFilter.Text = "Filter";
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
            this.comboBoxFilter.Location = new System.Drawing.Point(82, 51);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(142, 26);
            this.comboBoxFilter.TabIndex = 306;
            // 
            // btnFilter
            // 
            this.btnFilter.BorderRadius = 12;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.btnFilter.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(395, 45);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(2);
            this.btnFilter.Size = new System.Drawing.Size(93, 33);
            this.btnFilter.TabIndex = 303;
            this.btnFilter.Text = "Find";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            this.txtBoxSearch.Location = new System.Drawing.Point(227, 50);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(160, 22);
            this.txtBoxSearch.TabIndex = 305;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cascadia Code", 8.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(4, 54);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 20);
            this.guna2HtmlLabel1.TabIndex = 304;
            this.guna2HtmlLabel1.Text = "Filter By ";
            // 
            // conFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grpBoxFilter);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "conFilter";
            this.Size = new System.Drawing.Size(493, 89);
            this.Load += new System.EventHandler(this.conFilter_Load);
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpBoxFilter;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilter;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
