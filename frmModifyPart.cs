using Software1C968BFM1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1C968BFM1
{
    public partial class frmModifyPart : Form
    {
        private const string INHOUSE = "Machine ID";
        public Part partToUpdate { get; private set; }
        public event EventHandler OnSave;
        public frmModifyPart()
        {
            InitializeComponent();
        }
        public frmModifyPart(Inhouse part) : this()
        {

            tbID.Text = part.PartId.ToString();
            tbName.Text = part.Name;
            tbInventory.Text = part.InStock.ToString();
            tbMinQuantity.Text = part.Min.ToString();
            tbMaxQuantity.Text = part.Max.ToString();
            tbPrice.Text = part.Price.ToString();
            tbSource.Text = part.MachineID.ToString();

        }
        public frmModifyPart(Outsourced part) : this()
        {
            tbID.Text = part.PartId.ToString();
            tbName.Text = part.Name;
            tbInventory.Text = part.InStock.ToString();
            tbMinQuantity.Text = part.Min.ToString();
            tbMaxQuantity.Text = part.Max.ToString();
            tbPrice.Text = part.Price.ToString();
            tbSource.Text = part.CompanyName.ToString();

            rbOutsourced.Checked = true;
            lblSource.Text = "Company Name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInHouse.Checked)
            {
                lblSource.Text = "Machine ID";
            }
            else
            {
                lblSource.Text = "Company Name";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rbInHouse.Checked)
            {
                partToUpdate = new Inhouse
                {
                    PartId = int.Parse(tbID.Text),
                    Name = tbName.Text,
                    InStock = int.Parse(tbInventory.Text),
                    Min = int.Parse(tbMinQuantity.Text),
                    Max = int.Parse(tbMaxQuantity.Text),
                    MachineID = int.Parse(tbSource.Text),
                    Price = decimal.Parse(tbPrice.Text)
                };
            }
            else
            {
                partToUpdate = new Outsourced
                {
                    PartId = int.Parse(tbID.Text),
                    Name = tbName.Text,
                    InStock = int.Parse(tbInventory.Text),
                    Min = int.Parse(tbMinQuantity.Text),
                    Max = int.Parse(tbMaxQuantity.Text),
                    CompanyName = tbSource.Text,
                    Price = decimal.Parse(tbPrice.Text)
                };
            }

            OnSave?.Invoke(this, EventArgs.Empty);
            this.Close();
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

        private void tbInventory_TextChanged(object sender, EventArgs e)
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
