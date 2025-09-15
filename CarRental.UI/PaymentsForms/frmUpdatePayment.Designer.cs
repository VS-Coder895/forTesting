namespace CarRental.UI
{
    partial class frmUpdatePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePayment));
            this.numRefundedAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numRemainingAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numInitialPaidAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.comboBoxPaymentStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtPicPaymentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel24 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel25 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel27 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel28 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel29 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxPaymentNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.numActualFinalDueAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxRentalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxPaymentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.BorderlessfrmUpdatePayment = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtPicUpdatedAt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numRefundedAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialPaidAmount)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // numRefundedAmount
            // 
            this.numRefundedAmount.BackColor = System.Drawing.Color.Transparent;
            this.numRefundedAmount.BorderRadius = 12;
            this.numRefundedAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRefundedAmount.DecimalPlaces = 2;
            this.numRefundedAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numRefundedAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRefundedAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numRefundedAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRefundedAmount.Location = new System.Drawing.Point(199, 335);
            this.numRefundedAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numRefundedAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numRefundedAmount.Name = "numRefundedAmount";
            this.numRefundedAmount.Size = new System.Drawing.Size(288, 35);
            this.numRefundedAmount.TabIndex = 21;
            this.numRefundedAmount.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            this.numRefundedAmount.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // numRemainingAmount
            // 
            this.numRemainingAmount.BackColor = System.Drawing.Color.Transparent;
            this.numRemainingAmount.BorderRadius = 12;
            this.numRemainingAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numRemainingAmount.DecimalPlaces = 2;
            this.numRemainingAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numRemainingAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numRemainingAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numRemainingAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRemainingAmount.Location = new System.Drawing.Point(206, 294);
            this.numRemainingAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numRemainingAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numRemainingAmount.Name = "numRemainingAmount";
            this.numRemainingAmount.Size = new System.Drawing.Size(281, 35);
            this.numRemainingAmount.TabIndex = 21;
            this.numRemainingAmount.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            this.numRemainingAmount.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // numInitialPaidAmount
            // 
            this.numInitialPaidAmount.BackColor = System.Drawing.Color.Transparent;
            this.numInitialPaidAmount.BorderRadius = 12;
            this.numInitialPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numInitialPaidAmount.DecimalPlaces = 2;
            this.numInitialPaidAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numInitialPaidAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numInitialPaidAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numInitialPaidAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInitialPaidAmount.Location = new System.Drawing.Point(226, 253);
            this.numInitialPaidAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numInitialPaidAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.numInitialPaidAmount.Name = "numInitialPaidAmount";
            this.numInitialPaidAmount.Size = new System.Drawing.Size(261, 35);
            this.numInitialPaidAmount.TabIndex = 21;
            this.numInitialPaidAmount.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            this.numInitialPaidAmount.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPaymentStatus.BorderRadius = 8;
            this.comboBoxPaymentStatus.BorderThickness = 0;
            this.comboBoxPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentStatus.FillColor = System.Drawing.Color.SteelBlue;
            this.comboBoxPaymentStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPaymentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPaymentStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxPaymentStatus.IntegralHeight = false;
            this.comboBoxPaymentStatus.ItemHeight = 25;
            this.comboBoxPaymentStatus.Items.AddRange(new object[] {
            "Partial",
            "paid"});
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(206, 216);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(281, 31);
            this.comboBoxPaymentStatus.StartIndex = 0;
            this.comboBoxPaymentStatus.TabIndex = 18;
            this.comboBoxPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentStatus_SelectedIndexChanged);
            // 
            // dtPicPaymentDate
            // 
            this.dtPicPaymentDate.BorderRadius = 8;
            this.dtPicPaymentDate.Checked = true;
            this.dtPicPaymentDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.dtPicPaymentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPicPaymentDate.ForeColor = System.Drawing.Color.White;
            this.dtPicPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPicPaymentDate.Location = new System.Drawing.Point(167, 175);
            this.dtPicPaymentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicPaymentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicPaymentDate.Name = "dtPicPaymentDate";
            this.dtPicPaymentDate.Size = new System.Drawing.Size(320, 35);
            this.dtPicPaymentDate.TabIndex = 17;
            this.dtPicPaymentDate.Value = new System.DateTime(2025, 8, 19, 2, 59, 12, 816);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 469);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(181, 26);
            this.guna2HtmlLabel5.TabIndex = 13;
            this.guna2HtmlLabel5.Text = "Payment Notes";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.AutoSize = false;
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(12, 97);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(127, 27);
            this.guna2HtmlLabel21.TabIndex = 16;
            this.guna2HtmlLabel21.Text = "Payment ID";
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.AutoSize = false;
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(12, 218);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(158, 27);
            this.guna2HtmlLabel22.TabIndex = 16;
            this.guna2HtmlLabel22.Text = "Payment Status";
            // 
            // guna2HtmlLabel23
            // 
            this.guna2HtmlLabel23.AutoSize = false;
            this.guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel23.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel23.Location = new System.Drawing.Point(12, 428);
            this.guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            this.guna2HtmlLabel23.Size = new System.Drawing.Size(125, 28);
            this.guna2HtmlLabel23.TabIndex = 13;
            this.guna2HtmlLabel23.Text = "Updated At";
            // 
            // guna2HtmlLabel24
            // 
            this.guna2HtmlLabel24.AutoSize = false;
            this.guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel24.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel24.Location = new System.Drawing.Point(12, 384);
            this.guna2HtmlLabel24.Name = "guna2HtmlLabel24";
            this.guna2HtmlLabel24.Size = new System.Drawing.Size(254, 31);
            this.guna2HtmlLabel24.TabIndex = 13;
            this.guna2HtmlLabel24.Text = "Actual Final Amount Due";
            // 
            // guna2HtmlLabel25
            // 
            this.guna2HtmlLabel25.AutoSize = false;
            this.guna2HtmlLabel25.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel25.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel25.Location = new System.Drawing.Point(12, 340);
            this.guna2HtmlLabel25.Name = "guna2HtmlLabel25";
            this.guna2HtmlLabel25.Size = new System.Drawing.Size(181, 31);
            this.guna2HtmlLabel25.TabIndex = 13;
            this.guna2HtmlLabel25.Text = "Refunded Amount";
            // 
            // guna2HtmlLabel26
            // 
            this.guna2HtmlLabel26.AutoSize = false;
            this.guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel26.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel26.Location = new System.Drawing.Point(12, 178);
            this.guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            this.guna2HtmlLabel26.Size = new System.Drawing.Size(149, 27);
            this.guna2HtmlLabel26.TabIndex = 13;
            this.guna2HtmlLabel26.Text = "Payment Date";
            // 
            // guna2HtmlLabel27
            // 
            this.guna2HtmlLabel27.AutoSize = false;
            this.guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel27.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel27.Location = new System.Drawing.Point(12, 137);
            this.guna2HtmlLabel27.Name = "guna2HtmlLabel27";
            this.guna2HtmlLabel27.Size = new System.Drawing.Size(125, 28);
            this.guna2HtmlLabel27.TabIndex = 13;
            this.guna2HtmlLabel27.Text = "Rental ID";
            // 
            // guna2HtmlLabel28
            // 
            this.guna2HtmlLabel28.AutoSize = false;
            this.guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel28.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel28.Location = new System.Drawing.Point(12, 299);
            this.guna2HtmlLabel28.Name = "guna2HtmlLabel28";
            this.guna2HtmlLabel28.Size = new System.Drawing.Size(187, 28);
            this.guna2HtmlLabel28.TabIndex = 13;
            this.guna2HtmlLabel28.Text = "Remaining Amount";
            // 
            // guna2HtmlLabel29
            // 
            this.guna2HtmlLabel29.AutoSize = false;
            this.guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel29.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel29.Location = new System.Drawing.Point(12, 258);
            this.guna2HtmlLabel29.Name = "guna2HtmlLabel29";
            this.guna2HtmlLabel29.Size = new System.Drawing.Size(212, 28);
            this.guna2HtmlLabel29.TabIndex = 13;
            this.guna2HtmlLabel29.Text = "Initial Paid Amount";
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
            this.btnSave.Location = new System.Drawing.Point(158, 628);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txtBoxPaymentNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBoxPaymentNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentNotes.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtBoxPaymentNotes.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPaymentNotes.HideSelection = false;
            this.txtBoxPaymentNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentNotes.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxPaymentNotes.IconLeft")));
            this.txtBoxPaymentNotes.Location = new System.Drawing.Point(194, 458);
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
            this.txtBoxPaymentNotes.Size = new System.Drawing.Size(293, 141);
            this.txtBoxPaymentNotes.TabIndex = 11;
            this.txtBoxPaymentNotes.TabStop = false;
            this.txtBoxPaymentNotes.WordWrap = false;
            // 
            // numActualFinalDueAmount
            // 
            this.numActualFinalDueAmount.BackColor = System.Drawing.Color.Transparent;
            this.numActualFinalDueAmount.BorderRadius = 12;
            this.numActualFinalDueAmount.BorderThickness = 0;
            this.numActualFinalDueAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numActualFinalDueAmount.DefaultText = "";
            this.numActualFinalDueAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numActualFinalDueAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numActualFinalDueAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numActualFinalDueAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numActualFinalDueAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numActualFinalDueAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numActualFinalDueAmount.Font = new System.Drawing.Font("Georgia", 10F);
            this.numActualFinalDueAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.numActualFinalDueAmount.HideSelection = false;
            this.numActualFinalDueAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numActualFinalDueAmount.IconLeft = ((System.Drawing.Image)(resources.GetObject("numActualFinalDueAmount.IconLeft")));
            this.numActualFinalDueAmount.Location = new System.Drawing.Point(272, 376);
            this.numActualFinalDueAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numActualFinalDueAmount.MaxLength = 0;
            this.numActualFinalDueAmount.Name = "numActualFinalDueAmount";
            this.numActualFinalDueAmount.PlaceholderText = "";
            this.numActualFinalDueAmount.ReadOnly = true;
            this.numActualFinalDueAmount.SelectedText = "";
            this.numActualFinalDueAmount.ShadowDecoration.BorderRadius = 12;
            this.numActualFinalDueAmount.ShadowDecoration.Depth = 3;
            this.numActualFinalDueAmount.ShadowDecoration.Enabled = true;
            this.numActualFinalDueAmount.ShortcutsEnabled = false;
            this.numActualFinalDueAmount.Size = new System.Drawing.Size(215, 35);
            this.numActualFinalDueAmount.TabIndex = 11;
            this.numActualFinalDueAmount.TabStop = false;
            this.numActualFinalDueAmount.WordWrap = false;
            // 
            // txtBoxRentalID
            // 
            this.txtBoxRentalID.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxRentalID.BorderRadius = 12;
            this.txtBoxRentalID.BorderThickness = 0;
            this.txtBoxRentalID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBoxRentalID.DefaultText = "";
            this.txtBoxRentalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxRentalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxRentalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRentalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRentalID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBoxRentalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRentalID.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtBoxRentalID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxRentalID.HideSelection = false;
            this.txtBoxRentalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRentalID.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxRentalID.IconLeft")));
            this.txtBoxRentalID.Location = new System.Drawing.Point(127, 134);
            this.txtBoxRentalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRentalID.MaxLength = 0;
            this.txtBoxRentalID.Name = "txtBoxRentalID";
            this.txtBoxRentalID.PlaceholderText = "";
            this.txtBoxRentalID.ReadOnly = true;
            this.txtBoxRentalID.SelectedText = "";
            this.txtBoxRentalID.ShadowDecoration.BorderRadius = 12;
            this.txtBoxRentalID.ShadowDecoration.Depth = 3;
            this.txtBoxRentalID.ShadowDecoration.Enabled = true;
            this.txtBoxRentalID.ShortcutsEnabled = false;
            this.txtBoxRentalID.Size = new System.Drawing.Size(360, 35);
            this.txtBoxRentalID.TabIndex = 11;
            this.txtBoxRentalID.TabStop = false;
            this.txtBoxRentalID.WordWrap = false;
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
            this.txtBoxPaymentID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBoxPaymentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentID.Font = new System.Drawing.Font("Georgia", 10F);
            this.txtBoxPaymentID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPaymentID.HideSelection = false;
            this.txtBoxPaymentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPaymentID.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxPaymentID.IconLeft")));
            this.txtBoxPaymentID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtBoxPaymentID.Location = new System.Drawing.Point(145, 93);
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
            this.txtBoxPaymentID.Size = new System.Drawing.Size(342, 35);
            this.txtBoxPaymentID.TabIndex = 11;
            this.txtBoxPaymentID.TabStop = false;
            this.txtBoxPaymentID.WordWrap = false;
            // 
            // BorderlessfrmUpdatePayment
            // 
            this.BorderlessfrmUpdatePayment.BorderRadius = 16;
            this.BorderlessfrmUpdatePayment.ContainerControl = this;
            this.BorderlessfrmUpdatePayment.DockForm = false;
            this.BorderlessfrmUpdatePayment.DockIndicatorTransparencyValue = 1D;
            this.BorderlessfrmUpdatePayment.DragStartTransparencyValue = 1D;
            this.BorderlessfrmUpdatePayment.HasFormShadow = false;
            this.BorderlessfrmUpdatePayment.ResizeForm = false;
            this.BorderlessfrmUpdatePayment.ShadowColor = System.Drawing.Color.Transparent;
            this.BorderlessfrmUpdatePayment.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(517, 73);
            this.guna2Panel1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(472, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(129, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(231, 37);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Update Payment";
            // 
            // dtPicUpdatedAt
            // 
            this.dtPicUpdatedAt.BorderRadius = 8;
            this.dtPicUpdatedAt.Checked = true;
            this.dtPicUpdatedAt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.dtPicUpdatedAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPicUpdatedAt.ForeColor = System.Drawing.Color.White;
            this.dtPicUpdatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPicUpdatedAt.Location = new System.Drawing.Point(167, 417);
            this.dtPicUpdatedAt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicUpdatedAt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicUpdatedAt.Name = "dtPicUpdatedAt";
            this.dtPicUpdatedAt.Size = new System.Drawing.Size(320, 35);
            this.dtPicUpdatedAt.TabIndex = 17;
            this.dtPicUpdatedAt.Value = new System.DateTime(2025, 8, 19, 2, 59, 12, 816);
            // 
            // frmUpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(512, 714);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.numRefundedAmount);
            this.Controls.Add(this.numRemainingAmount);
            this.Controls.Add(this.guna2HtmlLabel21);
            this.Controls.Add(this.numInitialPaidAmount);
            this.Controls.Add(this.txtBoxPaymentID);
            this.Controls.Add(this.comboBoxPaymentStatus);
            this.Controls.Add(this.txtBoxRentalID);
            this.Controls.Add(this.dtPicUpdatedAt);
            this.Controls.Add(this.dtPicPaymentDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.numActualFinalDueAmount);
            this.Controls.Add(this.txtBoxPaymentNotes);
            this.Controls.Add(this.guna2HtmlLabel29);
            this.Controls.Add(this.guna2HtmlLabel28);
            this.Controls.Add(this.guna2HtmlLabel27);
            this.Controls.Add(this.guna2HtmlLabel26);
            this.Controls.Add(this.guna2HtmlLabel25);
            this.Controls.Add(this.guna2HtmlLabel22);
            this.Controls.Add(this.guna2HtmlLabel24);
            this.Controls.Add(this.guna2HtmlLabel23);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdatePayment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Payment";
            this.Load += new System.EventHandler(this.UpdatePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRefundedAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemainingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialPaidAmount)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2NumericUpDown numRefundedAmount;
        private Guna.UI2.WinForms.Guna2NumericUpDown numRemainingAmount;
        private Guna.UI2.WinForms.Guna2NumericUpDown numInitialPaidAmount;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPaymentStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPicPaymentDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPaymentNotes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel24;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel25;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel26;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel27;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel28;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel29;
        private Guna.UI2.WinForms.Guna2TextBox numActualFinalDueAmount;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxRentalID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPaymentID;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessfrmUpdatePayment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPicUpdatedAt;
    }
}