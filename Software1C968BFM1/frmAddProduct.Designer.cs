namespace Software1C968BFM1
{
    partial class frmAddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.dgCandidateParts = new System.Windows.Forms.DataGridView();
            this.dgProductParts = new System.Windows.Forms.DataGridView();
            this.btnAddPartToProduct = new System.Windows.Forms.Button();
            this.btnDeletePartFromProduct = new System.Windows.Forms.Button();
            this.btnCancelAddProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbSearchCandidateParts = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFormIdentifier = new System.Windows.Forms.Label();
            this.lblCandidatePartsList = new System.Windows.Forms.Label();
            this.lblProductPartsList = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pFormContainer = new System.Windows.Forms.Panel();
            this.epValidator = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCandidateParts
            // 
            this.dgCandidateParts.AllowUserToAddRows = false;
            this.dgCandidateParts.AllowUserToDeleteRows = false;
            this.dgCandidateParts.AllowUserToResizeColumns = false;
            this.dgCandidateParts.AllowUserToResizeRows = false;
            this.dgCandidateParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCandidateParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.dgCandidateParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCandidateParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCandidateParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCandidateParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCandidateParts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCandidateParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCandidateParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgCandidateParts.Location = new System.Drawing.Point(516, 57);
            this.dgCandidateParts.Margin = new System.Windows.Forms.Padding(4);
            this.dgCandidateParts.Name = "dgCandidateParts";
            this.dgCandidateParts.ReadOnly = true;
            this.dgCandidateParts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCandidateParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCandidateParts.RowHeadersVisible = false;
            this.dgCandidateParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.dgCandidateParts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCandidateParts.Size = new System.Drawing.Size(522, 219);
            this.dgCandidateParts.TabIndex = 0;
            // 
            // dgProductParts
            // 
            this.dgProductParts.AllowUserToAddRows = false;
            this.dgProductParts.AllowUserToDeleteRows = false;
            this.dgProductParts.AllowUserToResizeColumns = false;
            this.dgProductParts.AllowUserToResizeRows = false;
            this.dgProductParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.dgProductParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgProductParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProductParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProductParts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductParts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgProductParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgProductParts.Location = new System.Drawing.Point(516, 342);
            this.dgProductParts.Margin = new System.Windows.Forms.Padding(4);
            this.dgProductParts.Name = "dgProductParts";
            this.dgProductParts.ReadOnly = true;
            this.dgProductParts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProductParts.RowHeadersVisible = false;
            this.dgProductParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.dgProductParts.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgProductParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductParts.Size = new System.Drawing.Size(522, 219);
            this.dgProductParts.TabIndex = 1;
            // 
            // btnAddPartToProduct
            // 
            this.btnAddPartToProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnAddPartToProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnAddPartToProduct.FlatAppearance.BorderSize = 2;
            this.btnAddPartToProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnAddPartToProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartToProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartToProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnAddPartToProduct.Location = new System.Drawing.Point(937, 285);
            this.btnAddPartToProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPartToProduct.Name = "btnAddPartToProduct";
            this.btnAddPartToProduct.Size = new System.Drawing.Size(100, 34);
            this.btnAddPartToProduct.TabIndex = 2;
            this.btnAddPartToProduct.Text = "Add";
            this.btnAddPartToProduct.UseVisualStyleBackColor = false;
            this.btnAddPartToProduct.Click += new System.EventHandler(this.btnAddPartToProduct_Click);
            // 
            // btnDeletePartFromProduct
            // 
            this.btnDeletePartFromProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnDeletePartFromProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnDeletePartFromProduct.FlatAppearance.BorderSize = 2;
            this.btnDeletePartFromProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnDeletePartFromProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePartFromProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePartFromProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnDeletePartFromProduct.Location = new System.Drawing.Point(937, 570);
            this.btnDeletePartFromProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePartFromProduct.Name = "btnDeletePartFromProduct";
            this.btnDeletePartFromProduct.Size = new System.Drawing.Size(100, 34);
            this.btnDeletePartFromProduct.TabIndex = 3;
            this.btnDeletePartFromProduct.Text = "Delete";
            this.btnDeletePartFromProduct.UseVisualStyleBackColor = false;
            this.btnDeletePartFromProduct.Click += new System.EventHandler(this.btnDeletePartFromProduct_Click);
            // 
            // btnCancelAddProduct
            // 
            this.btnCancelAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnCancelAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnCancelAddProduct.FlatAppearance.BorderSize = 2;
            this.btnCancelAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnCancelAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnCancelAddProduct.Location = new System.Drawing.Point(937, 612);
            this.btnCancelAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAddProduct.Name = "btnCancelAddProduct";
            this.btnCancelAddProduct.Size = new System.Drawing.Size(100, 34);
            this.btnCancelAddProduct.TabIndex = 4;
            this.btnCancelAddProduct.Text = "Cancel";
            this.btnCancelAddProduct.UseVisualStyleBackColor = false;
            this.btnCancelAddProduct.Click += new System.EventHandler(this.btnCancelAddProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnSaveProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnSaveProduct.FlatAppearance.BorderSize = 2;
            this.btnSaveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnSaveProduct.Location = new System.Drawing.Point(829, 612);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(100, 34);
            this.btnSaveProduct.TabIndex = 5;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblName.Location = new System.Drawing.Point(74, 219);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblInventory.Location = new System.Drawing.Point(74, 293);
            this.lblInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(87, 23);
            this.lblInventory.TabIndex = 8;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblPrice.Location = new System.Drawing.Point(74, 365);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 23);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblMin.Location = new System.Drawing.Point(311, 293);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(42, 23);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblMax.Location = new System.Drawing.Point(311, 365);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(45, 23);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Max";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.LightCoral;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.Location = new System.Drawing.Point(78, 246);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 30);
            this.tbName.TabIndex = 12;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbInventory
            // 
            this.tbInventory.BackColor = System.Drawing.Color.LightCoral;
            this.tbInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInventory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbInventory.Location = new System.Drawing.Point(78, 323);
            this.tbInventory.Margin = new System.Windows.Forms.Padding(4);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(207, 30);
            this.tbInventory.TabIndex = 13;
            this.tbInventory.Validating += new System.ComponentModel.CancelEventHandler(this.tbInventory_Validating);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.LightCoral;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrice.Location = new System.Drawing.Point(78, 392);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(207, 30);
            this.tbPrice.TabIndex = 14;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            // 
            // tbMin
            // 
            this.tbMin.BackColor = System.Drawing.Color.LightCoral;
            this.tbMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMin.Location = new System.Drawing.Point(315, 323);
            this.tbMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(132, 30);
            this.tbMin.TabIndex = 15;
            this.tbMin.Validating += new System.ComponentModel.CancelEventHandler(this.tbMin_Validating);
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.Color.LightCoral;
            this.tbMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMax.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMax.Location = new System.Drawing.Point(315, 392);
            this.tbMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(132, 30);
            this.tbMax.TabIndex = 16;
            this.tbMax.Validating += new System.ComponentModel.CancelEventHandler(this.tbMax_Validating);
            // 
            // tbSearchCandidateParts
            // 
            this.tbSearchCandidateParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchCandidateParts.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchCandidateParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchCandidateParts.Location = new System.Drawing.Point(789, 19);
            this.tbSearchCandidateParts.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchCandidateParts.Name = "tbSearchCandidateParts";
            this.tbSearchCandidateParts.Size = new System.Drawing.Size(247, 30);
            this.tbSearchCandidateParts.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnSearch.Location = new System.Drawing.Point(681, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 34);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFormIdentifier
            // 
            this.lblFormIdentifier.AutoSize = true;
            this.lblFormIdentifier.BackColor = System.Drawing.Color.Transparent;
            this.lblFormIdentifier.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormIdentifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblFormIdentifier.Location = new System.Drawing.Point(16, 13);
            this.lblFormIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormIdentifier.Name = "lblFormIdentifier";
            this.lblFormIdentifier.Size = new System.Drawing.Size(180, 39);
            this.lblFormIdentifier.TabIndex = 38;
            this.lblFormIdentifier.Text = "Add Product";
            // 
            // lblCandidatePartsList
            // 
            this.lblCandidatePartsList.AutoSize = true;
            this.lblCandidatePartsList.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidatePartsList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidatePartsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblCandidatePartsList.Location = new System.Drawing.Point(512, 30);
            this.lblCandidatePartsList.Name = "lblCandidatePartsList";
            this.lblCandidatePartsList.Size = new System.Drawing.Size(117, 19);
            this.lblCandidatePartsList.TabIndex = 39;
            this.lblCandidatePartsList.Text = "Candidate Parts";
            // 
            // lblProductPartsList
            // 
            this.lblProductPartsList.AutoSize = true;
            this.lblProductPartsList.BackColor = System.Drawing.Color.Transparent;
            this.lblProductPartsList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPartsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblProductPartsList.Location = new System.Drawing.Point(512, 319);
            this.lblProductPartsList.Name = "lblProductPartsList";
            this.lblProductPartsList.Size = new System.Drawing.Size(103, 19);
            this.lblProductPartsList.TabIndex = 40;
            this.lblProductPartsList.Text = "Product Parts";
            // 
            // tbID
            // 
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbID.Location = new System.Drawing.Point(78, 174);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(207, 30);
            this.tbID.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.lblID.Location = new System.Drawing.Point(74, 147);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 23);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "ID";
            // 
            // pFormContainer
            // 
            this.pFormContainer.BackColor = System.Drawing.Color.Transparent;
            this.pFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFormContainer.Location = new System.Drawing.Point(0, 0);
            this.pFormContainer.Name = "pFormContainer";
            this.pFormContainer.Size = new System.Drawing.Size(1067, 658);
            this.pFormContainer.TabIndex = 43;
            // 
            // epValidator
            // 
            this.epValidator.ContainerControl = this;
            this.epValidator.Icon = ((System.Drawing.Icon)(resources.GetObject("epValidator.Icon")));
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.BackgroundImage = global::Software1C968BFM1.Properties.Resources.FormBackGrounGradient;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblProductPartsList);
            this.Controls.Add(this.lblCandidatePartsList);
            this.Controls.Add(this.lblFormIdentifier);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchCandidateParts);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnCancelAddProduct);
            this.Controls.Add(this.btnDeletePartFromProduct);
            this.Controls.Add(this.btnAddPartToProduct);
            this.Controls.Add(this.dgProductParts);
            this.Controls.Add(this.dgCandidateParts);
            this.Controls.Add(this.pFormContainer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCandidateParts;
        private System.Windows.Forms.DataGridView dgProductParts;
        private System.Windows.Forms.Button btnAddPartToProduct;
        private System.Windows.Forms.Button btnDeletePartFromProduct;
        private System.Windows.Forms.Button btnCancelAddProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbSearchCandidateParts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFormIdentifier;
        private System.Windows.Forms.Label lblCandidatePartsList;
        private System.Windows.Forms.Label lblProductPartsList;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pFormContainer;
        private System.Windows.Forms.ErrorProvider epValidator;
    }
}