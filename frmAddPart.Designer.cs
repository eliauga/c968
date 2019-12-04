namespace Software1C968BFM1
{
    partial class frmAddPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPart));
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMinQuantity = new System.Windows.Forms.TextBox();
            this.tbMaxQuantity = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFormIdentifier = new System.Windows.Forms.Label();
            this.ttValid = new System.Windows.Forms.ToolTip(this.components);
            this.pAddFormContainer = new System.Windows.Forms.Panel();
            this.epValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.pAddFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.BackColor = System.Drawing.Color.Transparent;
            this.rbInHouse.Checked = true;
            this.rbInHouse.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(519, 93);
            this.rbInHouse.Margin = new System.Windows.Forms.Padding(4);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(99, 27);
            this.rbInHouse.TabIndex = 0;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = false;
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.rbInHouse_CheckedChanged);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.BackColor = System.Drawing.Color.Transparent;
            this.rbOutsourced.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(629, 93);
            this.rbOutsourced.Margin = new System.Windows.Forms.Padding(4);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(121, 27);
            this.rbOutsourced.TabIndex = 1;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbID.Location = new System.Drawing.Point(166, 93);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(291, 30);
            this.tbID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.LightCoral;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Location = new System.Drawing.Point(166, 164);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 30);
            this.tbName.TabIndex = 3;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbInventory
            // 
            this.tbInventory.BackColor = System.Drawing.Color.LightCoral;
            this.tbInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInventory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbInventory.Location = new System.Drawing.Point(166, 239);
            this.tbInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(291, 30);
            this.tbInventory.TabIndex = 4;
            this.tbInventory.Validating += new System.ComponentModel.CancelEventHandler(this.tbInventory_Validating);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.LightCoral;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrice.Location = new System.Drawing.Point(166, 310);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(291, 30);
            this.tbPrice.TabIndex = 5;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            // 
            // tbMinQuantity
            // 
            this.tbMinQuantity.BackColor = System.Drawing.Color.LightCoral;
            this.tbMinQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinQuantity.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMinQuantity.Location = new System.Drawing.Point(519, 239);
            this.tbMinQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbMinQuantity.Name = "tbMinQuantity";
            this.tbMinQuantity.Size = new System.Drawing.Size(133, 30);
            this.tbMinQuantity.TabIndex = 6;
            this.tbMinQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.tbMinQuantity_Validating);
            // 
            // tbMaxQuantity
            // 
            this.tbMaxQuantity.BackColor = System.Drawing.Color.LightCoral;
            this.tbMaxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaxQuantity.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMaxQuantity.Location = new System.Drawing.Point(519, 310);
            this.tbMaxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaxQuantity.Name = "tbMaxQuantity";
            this.tbMaxQuantity.Size = new System.Drawing.Size(133, 30);
            this.tbMaxQuantity.TabIndex = 7;
            this.tbMaxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaxQuantity_Validating);
            // 
            // tbSource
            // 
            this.tbSource.BackColor = System.Drawing.Color.LightCoral;
            this.tbSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSource.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSource.Location = new System.Drawing.Point(166, 383);
            this.tbSource.Margin = new System.Windows.Forms.Padding(4);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(291, 30);
            this.tbSource.TabIndex = 8;
            this.tbSource.Validating += new System.ComponentModel.CancelEventHandler(this.tbSource_Validating);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(162, 66);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 23);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(162, 137);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 23);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(165, 212);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(87, 23);
            this.lblInventory.TabIndex = 11;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(162, 283);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(515, 212);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(42, 23);
            this.lblMin.TabIndex = 13;
            this.lblMin.Text = "Min";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(162, 356);
            this.lblSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(100, 23);
            this.lblSource.TabIndex = 14;
            this.lblSource.Text = "Machine ID";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.BackColor = System.Drawing.Color.Transparent;
            this.LblMax.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMax.Location = new System.Drawing.Point(515, 283);
            this.LblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(45, 23);
            this.LblMax.TabIndex = 15;
            this.LblMax.Text = "Max";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnCancel.Location = new System.Drawing.Point(877, 379);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnSave.Location = new System.Drawing.Point(769, 379);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFormIdentifier
            // 
            this.lblFormIdentifier.AutoSize = true;
            this.lblFormIdentifier.BackColor = System.Drawing.Color.Transparent;
            this.lblFormIdentifier.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormIdentifier.Location = new System.Drawing.Point(16, 13);
            this.lblFormIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormIdentifier.Name = "lblFormIdentifier";
            this.lblFormIdentifier.Size = new System.Drawing.Size(131, 39);
            this.lblFormIdentifier.TabIndex = 38;
            this.lblFormIdentifier.Text = "Add Part";
            // 
            // ttValid
            // 
            this.ttValid.BackColor = System.Drawing.Color.DimGray;
            this.ttValid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // pAddFormContainer
            // 
            this.pAddFormContainer.BackColor = System.Drawing.Color.Transparent;
            this.pAddFormContainer.Controls.Add(this.btnCancel);
            this.pAddFormContainer.Controls.Add(this.btnSave);
            this.pAddFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAddFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pAddFormContainer.Name = "pAddFormContainer";
            this.pAddFormContainer.Size = new System.Drawing.Size(1063, 468);
            this.pAddFormContainer.TabIndex = 39;
            // 
            // epValidator
            // 
            this.epValidator.BlinkRate = 500;
            this.epValidator.ContainerControl = this;
            this.epValidator.Icon = ((System.Drawing.Icon)(resources.GetObject("epValidator.Icon")));
            // 
            // frmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.BackgroundImage = global::Software1C968BFM1.Properties.Resources.FormBackGrounGradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1068, 468);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.lblFormIdentifier);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.tbMaxQuantity);
            this.Controls.Add(this.tbMinQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.pAddFormContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddPart";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.frmAddPart_Load);
            this.pAddFormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMinQuantity;
        private System.Windows.Forms.TextBox tbMaxQuantity;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFormIdentifier;
        private System.Windows.Forms.ToolTip ttValid;
        private System.Windows.Forms.Panel pAddFormContainer;
        private System.Windows.Forms.ErrorProvider epValidator;
    }
}