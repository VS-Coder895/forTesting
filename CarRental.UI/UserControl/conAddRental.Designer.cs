using BusinessLayer;

namespace CarRental.UI
{
    partial class conAddRental
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
            this.TabControlRental = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.conCustomerInfo = new CarRental.UI.conCustomerInfo();
            this.conFilter = new CarRental.UI.conFilter();
            this.tabPageVehicle = new System.Windows.Forms.TabPage();
            this.conVehicleInfo = new CarRental.UI.conVehicleInfo();
            this.conFilterVehicle = new CarRental.UI.conFilter();
            this.tabPageRental = new System.Windows.Forms.TabPage();
            this.conAddEditRental = new CarRental.UI.conAddEditRental();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.conAddEditInitialPayment = new CarRental.UI.conAddEditInitialPayment();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.TabControlRental.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.tabPageVehicle.SuspendLayout();
            this.tabPageRental.SuspendLayout();
            this.tabPagePayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlRental
            // 
            this.TabControlRental.Controls.Add(this.tabPageCustomer);
            this.TabControlRental.Controls.Add(this.tabPageVehicle);
            this.TabControlRental.Controls.Add(this.tabPageRental);
            this.TabControlRental.Controls.Add(this.tabPagePayment);
            this.TabControlRental.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControlRental.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.TabControlRental.ItemSize = new System.Drawing.Size(120, 60);
            this.TabControlRental.Location = new System.Drawing.Point(0, 0);
            this.TabControlRental.Name = "TabControlRental";
            this.TabControlRental.SelectedIndex = 0;
            this.TabControlRental.Size = new System.Drawing.Size(910, 761);
            this.TabControlRental.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlRental.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControlRental.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControlRental.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControlRental.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControlRental.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlRental.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControlRental.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControlRental.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControlRental.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControlRental.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlRental.TabButtonSelectedState.FillColor = System.Drawing.Color.SteelBlue;
            this.TabControlRental.TabButtonSelectedState.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.TabControlRental.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabControlRental.TabButtonSelectedState.InnerColor = System.Drawing.Color.DarkRed;
            this.TabControlRental.TabButtonSize = new System.Drawing.Size(120, 60);
            this.TabControlRental.TabIndex = 0;
            this.TabControlRental.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.TabControlRental.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.BackColor = System.Drawing.Color.Azure;
            this.tabPageCustomer.Controls.Add(this.conCustomerInfo);
            this.tabPageCustomer.Controls.Add(this.conFilter);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 64);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(902, 693);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customer";
            // 
            // conCustomerInfo
            // 
            this.conCustomerInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conCustomerInfo.BackColor = System.Drawing.Color.Azure;
            this.conCustomerInfo.Location = new System.Drawing.Point(3, 163);
            this.conCustomerInfo.Margin = new System.Windows.Forms.Padding(10);
            this.conCustomerInfo.Name = "conCustomerInfo";
            this.conCustomerInfo.Size = new System.Drawing.Size(896, 448);
            this.conCustomerInfo.TabIndex = 1;
            // 
            // conFilter
            // 
            this.conFilter.BackColor = System.Drawing.Color.Transparent;
            this.conFilter.clsType = null;
            this.conFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.conFilter.Location = new System.Drawing.Point(3, 3);
            this.conFilter.Margin = new System.Windows.Forms.Padding(10);
            this.conFilter.Name = "conFilter";
            this.conFilter.Size = new System.Drawing.Size(896, 142);
            this.conFilter.TabIndex = 0;
            // 
            // tabPageVehicle
            // 
            this.tabPageVehicle.BackColor = System.Drawing.Color.Azure;
            this.tabPageVehicle.Controls.Add(this.conVehicleInfo);
            this.tabPageVehicle.Controls.Add(this.conFilterVehicle);
            this.tabPageVehicle.Location = new System.Drawing.Point(4, 64);
            this.tabPageVehicle.Name = "tabPageVehicle";
            this.tabPageVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicle.Size = new System.Drawing.Size(902, 693);
            this.tabPageVehicle.TabIndex = 3;
            this.tabPageVehicle.Text = "Vehicle";
            // 
            // conVehicleInfo
            // 
            this.conVehicleInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conVehicleInfo.BackColor = System.Drawing.Color.Azure;
            this.conVehicleInfo.Location = new System.Drawing.Point(3, 163);
            this.conVehicleInfo.Margin = new System.Windows.Forms.Padding(4);
            this.conVehicleInfo.Name = "conVehicleInfo";
            this.conVehicleInfo.Size = new System.Drawing.Size(896, 514);
            this.conVehicleInfo.TabIndex = 2;
            // 
            // conFilterVehicle
            // 
            this.conFilterVehicle.BackColor = System.Drawing.Color.Transparent;
            this.conFilterVehicle.clsType = null;
            this.conFilterVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.conFilterVehicle.Location = new System.Drawing.Point(3, 3);
            this.conFilterVehicle.Margin = new System.Windows.Forms.Padding(6);
            this.conFilterVehicle.Name = "conFilterVehicle";
            this.conFilterVehicle.Size = new System.Drawing.Size(896, 142);
            this.conFilterVehicle.TabIndex = 1;
            // 
            // tabPageRental
            // 
            this.tabPageRental.BackColor = System.Drawing.Color.Azure;
            this.tabPageRental.Controls.Add(this.conAddEditRental);
            this.tabPageRental.Location = new System.Drawing.Point(4, 64);
            this.tabPageRental.Name = "tabPageRental";
            this.tabPageRental.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRental.Size = new System.Drawing.Size(902, 693);
            this.tabPageRental.TabIndex = 1;
            this.tabPageRental.Text = "Rental";
            // 
            // conAddEditRental
            // 
            this.conAddEditRental.BackColor = System.Drawing.Color.Azure;
            this.conAddEditRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conAddEditRental.Location = new System.Drawing.Point(3, 3);
            this.conAddEditRental.Margin = new System.Windows.Forms.Padding(4);
            this.conAddEditRental.Name = "conAddEditRental";
            this.conAddEditRental.Size = new System.Drawing.Size(896, 687);
            this.conAddEditRental.TabIndex = 0;
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.BackColor = System.Drawing.Color.Azure;
            this.tabPagePayment.Controls.Add(this.conAddEditInitialPayment);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 64);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayment.Size = new System.Drawing.Size(902, 693);
            this.tabPagePayment.TabIndex = 2;
            this.tabPagePayment.Text = "Payment";
            // 
            // conAddEditInitialPayment
            // 
            this.conAddEditInitialPayment.BackColor = System.Drawing.Color.Azure;
            this.conAddEditInitialPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conAddEditInitialPayment.Location = new System.Drawing.Point(3, 3);
            this.conAddEditInitialPayment.Margin = new System.Windows.Forms.Padding(4);
            this.conAddEditInitialPayment.Name = "conAddEditInitialPayment";
            this.conAddEditInitialPayment.Size = new System.Drawing.Size(896, 687);
            this.conAddEditInitialPayment.TabIndex = 0;
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.AutoSize = false;
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel20.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(109, 13);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(244, 37);
            this.guna2HtmlLabel20.TabIndex = 16;
            this.guna2HtmlLabel20.Text = "Add Initial Payment";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 12;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.btnSave.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(733, 767);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 12;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.btnClose.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(566, 767);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // conAddRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TabControlRental);
            this.Name = "conAddRental";
            this.Size = new System.Drawing.Size(910, 835);
            this.TabControlRental.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageVehicle.ResumeLayout(false);
            this.tabPageRental.ResumeLayout(false);
            this.tabPagePayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private Guna.UI2.WinForms.Guna2Button btnFilterCustomer;
        //private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilterCustomer;
        //private Guna.UI2.WinForms.Guna2TextBox txtBoxSearchCustomer;
        private Guna.UI2.WinForms.Guna2TabControl TabControlRental;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageRental;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private System.Windows.Forms.TabPage tabPageVehicle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.TabPage tabPagePayment;
        private conCustomerInfo conCustomerInfo;
        private conFilter conFilter;
        private conFilter conFilterVehicle;
        private conVehicleInfo conVehicleInfo;
        private conAddEditRental conAddEditRental;
        private conAddEditInitialPayment conAddEditInitialPayment;
    }
}
