namespace CarRental.UI
{
    partial class conAddEditInitialPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conAddEditInitialPayment));
            this.numRemainingAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numInitialPaidAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtPicPaymentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel29 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxPaymentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxPaymentNotes = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialPaidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numRemainingAmount
            // 
            this.numRemainingAmount.BackColor = System.Drawing.Color.Transparent;
            this.numRemainingAmount.BorderRadius = 12;
            this.numRemainingAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRemainingAmount.DecimalPlaces = 2;
            this.numRemainingAmount.Enabled = false;
            this.numRemainingAmount.FillColor = System.Drawing.Color.SteelBlue;
            this.numRemainingAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRemainingAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numRemainingAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRemainingAmount.Location = new System.Drawing.Point(252, 180);
            this.numRemainingAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numRemainingAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numRemainingAmount.Name = "numRemainingAmount";
            this.numRemainingAmount.Size = new System.Drawing.Size(192, 35);
            this.numRemainingAmount.TabIndex = 44;
            this.numRemainingAmount.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Cascadia Code", 8.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(58, 36);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(103, 40);
            this.guna2HtmlLabel21.TabIndex = 42;
            this.guna2HtmlLabel21.Text = "Payment ID";
            // 
            // numInitialPaidAmount
            // 
            this.numInitialPaidAmount.BackColor = System.Drawing.Color.Transparent;
            this.numInitialPaidAmount.BorderRadius = 12;
            this.numInitialPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numInitialPaidAmount.DecimalPlaces = 2;
            this.numInitialPaidAmount.FillColor = System.Drawing.Color.SteelBlue;
            this.numInitialPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numInitialPaidAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numInitialPaidAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInitialPaidAmount.Location = new System.Drawing.Point(272, 133);
            this.numInitialPaidAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numInitialPaidAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numInitialPaidAmount.Name = "numInitialPaidAmount";
            this.numInitialPaidAmount.Size = new System.Drawing.Size(172, 35);
            this.numInitialPaidAmount.TabIndex = 45;
            this.numInitialPaidAmount.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            this.numInitialPaidAmount.ValueChanged += new System.EventHandler(this.numInitialPaidAmount_ValueChanged);
            // 
            // dtPicPaymentDate
            // 
            this.dtPicPaymentDate.BorderRadius = 8;
            this.dtPicPaymentDate.Checked = true;
            this.dtPicPaymentDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.dtPicPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPicPaymentDate.ForeColor = System.Drawing.Color.White;
            this.dtPicPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPicPaymentDate.Location = new System.Drawing.Point(213, 86);
            this.dtPicPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicPaymentDate.Name = "dtPicPaymentDate";
            this.dtPicPaymentDate.Size = new System.Drawing.Size(231, 35);
            this.dtPicPaymentDate.TabIndex = 43;
            this.dtPicPaymentDate.Value = new System.DateTime(2025, 8, 19, 2, 59, 12, 816);
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Cascadia Code", 8.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(58, 232);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(127, 40);
            this.guna2HtmlLabel22.TabIndex = 38;
            this.guna2HtmlLabel22.Text = "Payment Notes";
            // 
            // guna2HtmlLabel29
            // 
            this.guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel29.Font = new System.Drawing.Font("Cascadia Code", 8.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel29.Location = new System.Drawing.Point(58, 134);
            this.guna2HtmlLabel29.Name = "guna2HtmlLabel29";
            this.guna2HtmlLabel29.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel29.Size = new System.Drawing.Size(175, 40);
            this.guna2HtmlLabel29.TabIndex = 39;
            this.guna2HtmlLabel29.Text = "Initial Paid Amount";
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel28.Font = new System.Drawing.Font("Cascadia Code", 8.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(58, 183);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(151, 40);
            this.guna2HtmlLabel28.TabIndex = 40;
            this.guna2HtmlLabel28.Text = "Remaining Amount";
            // 
            // guna2HtmlLabel26
            // 
            this.guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel26.Font = new System.Drawing.Font("Cascadia Code", 8.2F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel26.Location = new System.Drawing.Point(58, 85);
            this.guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            this.guna2HtmlLabel26.Padding = new System.Windows.Forms.Padding(10);
            this.guna2HtmlLabel26.Size = new System.Drawing.Size(119, 40);
            this.guna2HtmlLabel26.TabIndex = 41;
            this.guna2HtmlLabel26.Text = "Payment Date";
            // 
            // txtBoxPaymentID
            // 
            this.txtBoxPaymentID.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPaymentID.BorderRadius = 12;
            this.txtBoxPaymentID.BorderThickness = 0;
            this.txtBoxPaymentID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBoxPaymentID.DefaultText = "";
            this.txtBoxPaymentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPaymentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPaymentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPaymentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPaymentID.FillColor = System.Drawing.Color.SteelBlue;
            this.txtBoxPaymentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentID.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtBoxPaymentID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPaymentID.HideSelection = false;
            this.txtBoxPaymentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentID.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxPaymentID.IconLeft")));
            this.txtBoxPaymentID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtBoxPaymentID.Location = new System.Drawing.Point(191, 39);
            this.txtBoxPaymentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPaymentID.MaxLength = 0;
            this.txtBoxPaymentID.Name = "txtBoxPaymentID";
            this.txtBoxPaymentID.PlaceholderText = "";
            this.txtBoxPaymentID.ReadOnly = true;
            this.txtBoxPaymentID.SelectedText = "";
            this.txtBoxPaymentID.ShadowDecoration.BorderRadius = 12;
            this.txtBoxPaymentID.ShadowDecoration.Depth = 3;
            this.txtBoxPaymentID.ShadowDecoration.Enabled = true;
            this.txtBoxPaymentID.ShortcutsEnabled = false;
            this.txtBoxPaymentID.Size = new System.Drawing.Size(253, 35);
            this.txtBoxPaymentID.TabIndex = 36;
            this.txtBoxPaymentID.TabStop = false;
            this.txtBoxPaymentID.WordWrap = false;
            // 
            // txtBoxPaymentNotes
            // 
            this.txtBoxPaymentNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPaymentNotes.BorderRadius = 12;
            this.txtBoxPaymentNotes.BorderThickness = 0;
            this.txtBoxPaymentNotes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBoxPaymentNotes.DefaultText = "";
            this.txtBoxPaymentNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPaymentNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPaymentNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPaymentNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPaymentNotes.FillColor = System.Drawing.Color.SteelBlue;
            this.txtBoxPaymentNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentNotes.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtBoxPaymentNotes.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPaymentNotes.HideSelection = false;
            this.txtBoxPaymentNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentNotes.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxPaymentNotes.IconLeft")));
            this.txtBoxPaymentNotes.Location = new System.Drawing.Point(240, 227);
            this.txtBoxPaymentNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPaymentNotes.MaxLength = 0;
            this.txtBoxPaymentNotes.Multiline = true;
            this.txtBoxPaymentNotes.Name = "txtBoxPaymentNotes";
            this.txtBoxPaymentNotes.PlaceholderText = "";
            this.txtBoxPaymentNotes.SelectedText = "";
            this.txtBoxPaymentNotes.ShadowDecoration.BorderRadius = 12;
            this.txtBoxPaymentNotes.ShadowDecoration.Depth = 3;
            this.txtBoxPaymentNotes.ShadowDecoration.Enabled = true;
            this.txtBoxPaymentNotes.ShortcutsEnabled = false;
            this.txtBoxPaymentNotes.Size = new System.Drawing.Size(204, 99);
            this.txtBoxPaymentNotes.TabIndex = 37;
            this.txtBoxPaymentNotes.TabStop = false;
            this.txtBoxPaymentNotes.WordWrap = false;
            // 
            // conAddEditInitialPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.numRemainingAmount);
            this.Controls.Add(this.guna2HtmlLabel21);
            this.Controls.Add(this.numInitialPaidAmount);
            this.Controls.Add(this.dtPicPaymentDate);
            this.Controls.Add(this.guna2HtmlLabel22);
            this.Controls.Add(this.guna2HtmlLabel29);
            this.Controls.Add(this.guna2HtmlLabel28);
            this.Controls.Add(this.guna2HtmlLabel26);
            this.Controls.Add(this.txtBoxPaymentID);
            this.Controls.Add(this.txtBoxPaymentNotes);
            this.Name = "conAddEditInitialPayment";
            this.Size = new System.Drawing.Size(472, 400);
            this.Load += new System.EventHandler(this.conAddEditInitialPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialPaidAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown numRemainingAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2NumericUpDown numInitialPaidAmount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPicPaymentDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel29;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel28;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel26;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPaymentID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPaymentNotes;
    }
}
