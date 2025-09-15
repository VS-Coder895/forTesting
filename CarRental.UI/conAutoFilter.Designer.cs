namespace CarRental.UI
{
    partial class conAutoFilter
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
            this.comboBoxFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.comboBoxFilter.Location = new System.Drawing.Point(34, 25);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(142, 26);
            this.comboBoxFilter.TabIndex = 308;
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
            this.txtBoxSearch.Location = new System.Drawing.Point(179, 25);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(160, 33);
            this.txtBoxSearch.TabIndex = 307;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // conAutoFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.txtBoxSearch);
            this.Name = "conAutoFilter";
            this.Size = new System.Drawing.Size(433, 76);
            this.Load += new System.EventHandler(this.conAutoFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilter;
        public Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
    }
}
