using Software1C968BFM1.Domain;
using Software1C968BFM1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1C968BFM1
{
    public partial class frmAddPart : Form
    {
        private const string INHOUSE = "Machine ID";
        public Part PartToCreate { get; private set; }
        public event EventHandler OnSave;
        public frmAddPart()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ResetText();
            this.Close();
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbInHouse.Checked)
            {

                this.lblSource.Text = "Company Name";

            }
            else
            {

                this.lblSource.Text = "Machine ID";
            }
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            tbID.Text = Generator.CreateNewId().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                
            
                int id, inStock, min, max, machineID;
                string name, companyName = tbSource.Text;
                decimal price;

                int.TryParse(tbID.Text, out id);
                int.TryParse(tbInventory.Text, out inStock);
                int.TryParse(tbMinQuantity.Text, out min);
                int.TryParse(tbMaxQuantity.Text, out max);
                if (!int.TryParse(tbSource.Text, out machineID))
                {
                    companyName = tbSource.Text;
                }

                name = tbName.Text;
                price = decimal.Parse(tbPrice.Text, CultureInfo.InvariantCulture);
                if (rbInHouse.Checked)
                {
                    PartToCreate = new Inhouse
                    {
                        PartId = id,
                        Name = name,
                        InStock = inStock,
                        Min = min,
                        Max = max,
                        Price = price,
                        MachineID = machineID,
                    };
                }
                else
                {
                    PartToCreate = new Outsourced
                    {
                        PartId = id,
                        Name = name,
                        InStock = inStock,
                        Min = min,
                        Max = max,
                        Price = price,
                        CompanyName = companyName
                    };
                }
                OnSave?.Invoke(this, EventArgs.Empty);
                this.ResetText();
                this.Close();
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            tbName.BackColor = Color.LightCoral;
            int conversionCheck;
            if (string.IsNullOrEmpty(tbName.Text))
            {
               
                
                epValidator.SetError(tbName, "The part name is required");
            }
            else if (int.TryParse(tbName.Text, out conversionCheck))
            {
               
                
                epValidator.SetError(tbName, "The part name should only contain letters");
            }
            else
            {
                tbName.BackColor = Color.White;
                epValidator.SetError(tbName, string.Empty);
            }
        }

        private void tbInventory_Validating(object sender, CancelEventArgs e)
        {
            tbInventory.BackColor = Color.LightCoral;
            int conversionCheck;
            if (string.IsNullOrEmpty(tbInventory.Text))
            {
                epValidator.SetError(tbInventory, "The inventory amount is required");
            }
            else if (!int.TryParse(tbInventory.Text, out conversionCheck))
            {
                epValidator.SetError(tbInventory, "Inventory should be a number");
            }
            else
            {
                tbInventory.BackColor = Color.White;
                epValidator.SetError(tbInventory, string.Empty);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            tbPrice.BackColor = Color.LightCoral;
            decimal conversionCheck;
            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                epValidator.SetError(tbPrice, "The price is required");
            }
            else if (!decimal.TryParse(tbPrice.Text, out conversionCheck))
            {
                epValidator.SetError(tbPrice, "Price should be a number");
            }
            else
            {
                tbPrice.BackColor = Color.White;
                epValidator.SetError(tbPrice, string.Empty);
            }
        }

        private void tbSource_Validating(object sender, CancelEventArgs e)
        {
            tbSource.BackColor = Color.LightCoral;
            int conversionCheck;
            if (lblSource.Text == INHOUSE)
            {
                if (string.IsNullOrEmpty(tbSource.Text))
                {
                    epValidator.SetError(tbSource, "The Machine ID amount is required");
                }
                else if (!int.TryParse(tbSource.Text, out conversionCheck))
                {
                    epValidator.SetError(tbSource, "The Machine ID should be a number");
                }
                else
                {
                    tbSource.BackColor = Color.White;
                    epValidator.SetError(tbSource, string.Empty);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbSource.Text))
                {
                    epValidator.SetError(tbSource, "The company name is required");
                }
            }
        }

        private void tbMinQuantity_Validating(object sender, CancelEventArgs e)
        {
            tbMinQuantity.BackColor = Color.LightCoral;
            int conversionCheck;
            if (string.IsNullOrEmpty(tbMinQuantity.Text))
            {
                epValidator.SetError(tbMinQuantity, "The minimum inventory amount is required");
            }
            else if (!int.TryParse(tbMinQuantity.Text, out conversionCheck))
            {
                epValidator.SetError(tbMinQuantity, "Minimum Inventory should be a number");
            }
            else
            {
                tbMinQuantity.BackColor = Color.White;
                epValidator.SetError(tbMinQuantity, string.Empty);
            }
        }

        private void tbMaxQuantity_Validating(object sender, CancelEventArgs e)
        {
            tbMaxQuantity.BackColor = Color.LightCoral;
            int conversionCheck;
            if (string.IsNullOrEmpty(tbMaxQuantity.Text))
            {
                epValidator.SetError(tbMaxQuantity, "The maximum inventory amount is required");
            }
            else if (!int.TryParse(tbMaxQuantity.Text, out conversionCheck))
            {
                epValidator.SetError(tbMaxQuantity, "Maximum Inventory should be a number");
            }
            else
            {
                tbMaxQuantity.BackColor = Color.White;
                epValidator.SetError(tbMaxQuantity, string.Empty);
            }
        }
    }
}
