namespace Software1C968BFM1
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.pPartsContainer = new System.Windows.Forms.Panel();
            this.lblParts = new System.Windows.Forms.Label();
            this.tbSearchPart = new System.Windows.Forms.TextBox();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.pProductContainer = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.tbSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.lblFormIdentifier = new System.Windows.Forms.Label();
            this.pMainContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            this.pPartsContainer.SuspendLayout();
            this.pProductContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.pMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgParts
            // 
            this.dgParts.AllowUserToResizeColumns = false;
            this.dgParts.AllowUserToResizeRows = false;
            this.dgParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgParts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.dgParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgParts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgParts.Location = new System.Drawing.Point(4, 79);
            this.dgParts.Margin = new System.Windows.Forms.Padding(4);
            this.dgParts.MultiSelect = false;
            this.dgParts.Name = "dgParts";
            this.dgParts.ReadOnly = true;
            this.dgParts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgParts.RowHeadersVisible = false;
            this.dgParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.dgParts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgParts.RowTemplate.Height = 32;
            this.dgParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParts.Size = new System.Drawing.Size(617, 254);
            this.dgParts.TabIndex = 0;
            // 
            // pPartsContainer
            // 
            this.pPartsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pPartsContainer.Controls.Add(this.lblParts);
            this.pPartsContainer.Controls.Add(this.tbSearchPart);
            this.pPartsContainer.Controls.Add(this.btnSearchParts);
            this.pPartsContainer.Controls.Add(this.btnDeletePart);
            this.pPartsContainer.Controls.Add(this.btnModifyPart);
            this.pPartsContainer.Controls.Add(this.btnAddPart);
            this.pPartsContainer.Controls.Add(this.dgParts);
            this.pPartsContainer.Location = new System.Drawing.Point(4, 28);
            this.pPartsContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pPartsContainer.Name = "pPartsContainer";
            this.pPartsContainer.Size = new System.Drawing.Size(625, 380);
            this.pPartsContainer.TabIndex = 1;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.BackColor = System.Drawing.Color.Transparent;
            this.lblParts.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(4, 9);
            this.lblParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(65, 29);
            this.lblParts.TabIndex = 6;
            this.lblParts.Text = "Parts";
            // 
            // tbSearchPart
            // 
            this.tbSearchPart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchPart.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchPart.Location = new System.Drawing.Point(329, 6);
            this.tbSearchPart.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchPart.Name = "tbSearchPart";
            this.tbSearchPart.Size = new System.Drawing.Size(292, 30);
            this.tbSearchPart.TabIndex = 5;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnSearchParts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnSearchParts.FlatAppearance.BorderSize = 2;
            this.btnSearchParts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnSearchParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchParts.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnSearchParts.Location = new System.Drawing.Point(221, 4);
            this.btnSearchParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(100, 34);
            this.btnSearchParts.TabIndex = 4;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = false;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnDeletePart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnDeletePart.FlatAppearance.BorderSize = 2;
            this.btnDeletePart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePart.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnDeletePart.Location = new System.Drawing.Point(521, 341);
            this.btnDeletePart.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(100, 34);
            this.btnDeletePart.TabIndex = 3;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnModifyPart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnModifyPart.FlatAppearance.BorderSize = 2;
            this.btnModifyPart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnModifyPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPart.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnModifyPart.Location = new System.Drawing.Point(413, 342);
            this.btnModifyPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(100, 34);
            this.btnModifyPart.TabIndex = 2;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = false;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnAddPart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnAddPart.FlatAppearance.BorderSize = 2;
            this.btnAddPart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnAddPart.Location = new System.Drawing.Point(305, 341);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(100, 34);
            this.btnAddPart.TabIndex = 1;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // pProductContainer
            // 
            this.pProductContainer.BackColor = System.Drawing.Color.Transparent;
            this.pProductContainer.Controls.Add(this.lblProducts);
            this.pProductContainer.Controls.Add(this.tbSearchProducts);
            this.pProductContainer.Controls.Add(this.btnSearchProducts);
            this.pProductContainer.Controls.Add(this.btnDeleteProduct);
            this.pProductContainer.Controls.Add(this.btnModifyProduct);
            this.pProductContainer.Controls.Add(this.btnAddProduct);
            this.pProductContainer.Controls.Add(this.dgProducts);
            this.pProductContainer.Location = new System.Drawing.Point(635, 28);
            this.pProductContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pProductContainer.Name = "pProductContainer";
            this.pProductContainer.Size = new System.Drawing.Size(625, 380);
            this.pProductContainer.TabIndex = 7;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(4, 9);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(102, 29);
            this.lblProducts.TabIndex = 6;
            this.lblProducts.Text = "Products";
            // 
            // tbSearchProducts
            // 
            this.tbSearchProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchProducts.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProducts.Location = new System.Drawing.Point(329, 6);
            this.tbSearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchProducts.Name = "tbSearchProducts";
            this.tbSearchProducts.Size = new System.Drawing.Size(292, 30);
            this.tbSearchProducts.TabIndex = 5;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnSearchProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnSearchProducts.FlatAppearance.BorderSize = 2;
            this.btnSearchProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProducts.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnSearchProducts.Location = new System.Drawing.Point(221, 4);
            this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(100, 34);
            this.btnSearchProducts.TabIndex = 4;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = false;
            this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnDeleteProduct.FlatAppearance.BorderSize = 2;
            this.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(516, 341);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 34);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnModifyProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnModifyProduct.FlatAppearance.BorderSize = 2;
            this.btnModifyProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnModifyProduct.Location = new System.Drawing.Point(408, 341);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(100, 34);
            this.btnModifyProduct.TabIndex = 2;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 2;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnAddProduct.Location = new System.Drawing.Point(300, 341);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 34);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToResizeColumns = false;
            this.dgProducts.AllowUserToResizeRows = false;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgProducts.Location = new System.Drawing.Point(4, 79);
            this.dgProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.dgProducts.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgProducts.RowTemplate.Height = 32;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(617, 254);
            this.dgProducts.TabIndex = 0;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btnExitApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(70)))));
            this.btnExitApplication.FlatAppearance.BorderSize = 2;
            this.btnExitApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(103)))));
            this.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApplication.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnExitApplication.Location = new System.Drawing.Point(1151, 525);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(100, 34);
            this.btnExitApplication.TabIndex = 8;
            this.btnExitApplication.Text = "Exit";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // lblFormIdentifier
            // 
            this.lblFormIdentifier.AutoSize = true;
            this.lblFormIdentifier.BackColor = System.Drawing.Color.Transparent;
            this.lblFormIdentifier.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormIdentifier.Location = new System.Drawing.Point(16, 13);
            this.lblFormIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormIdentifier.Name = "lblFormIdentifier";
            this.lblFormIdentifier.Size = new System.Drawing.Size(325, 29);
            this.lblFormIdentifier.TabIndex = 38;
            this.lblFormIdentifier.Text = "Inventory Management System";
            // 
            // pMainContainer
            // 
            this.pMainContainer.BackColor = System.Drawing.Color.Transparent;
            this.pMainContainer.Controls.Add(this.pProductContainer);
            this.pMainContainer.Controls.Add(this.btnExitApplication);
            this.pMainContainer.Controls.Add(this.pPartsContainer);
            this.pMainContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMainContainer.Location = new System.Drawing.Point(0, 109);
            this.pMainContainer.Name = "pMainContainer";
            this.pMainContainer.Size = new System.Drawing.Size(1264, 572);
            this.pMainContainer.TabIndex = 39;
            this.pMainContainer.Click += new System.EventHandler(this.pMainContainer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.BackgroundImage = global::Software1C968BFM1.Properties.Resources.FormBackGrounGradient;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblFormIdentifier);
            this.Controls.Add(this.pMainContainer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            this.pPartsContainer.ResumeLayout(false);
            this.pPartsContainer.PerformLayout();
            this.pProductContainer.ResumeLayout(false);
            this.pProductContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.pMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgParts;
        private System.Windows.Forms.Panel pPartsContainer;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox tbSearchPart;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.Panel pProductContainer;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox tbSearchProducts;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Label lblFormIdentifier;
        private System.Windows.Forms.Panel pMainContainer;
    }
}

