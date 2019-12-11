using Software1C968BFM1.Domain;
using Software1C968BFM1.Helpers;
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
    public partial class frmAddProduct : Form
    {
        private readonly BindingList<Part> _availableParts;
        private readonly BindingList<Part> _associatedParts;
        public Product productToAdd { get; private set; }
        public event EventHandler OnSave;

        public frmAddProduct()
        {
            InitializeComponent();
        }

        public frmAddProduct(BindingList<Part> availableParts) : this()
        {
            _availableParts = availableParts;
            dgCandidateParts.DataSource = _availableParts;
            _associatedParts = new BindingList<Part>();
            dgProductParts.DataSource = _associatedParts;
        }

        private void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPartToProduct_Click(object sender, EventArgs e)
        {
            if (dgCandidateParts.SelectedRows.Count > 0)
            {
                Part partToAdd = (Part)dgCandidateParts.CurrentRow.DataBoundItem;
                _associatedParts.Add(partToAdd);
            }
            else
            {
                MessageBox.Show("You must select a candidate part before adding it to the product");
            }
        }

        private void btnDeletePartFromProduct_Click(object sender, EventArgs e)
        {
            if (dgProductParts.SelectedRows.Count > 0)
            {
                var partToRemove = (Part)dgProductParts.CurrentRow.DataBoundItem;
                if (MessageBox.Show("Are you sure you want to remove this part from the product?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _associatedParts.Remove(partToRemove);
                }
            }
            else
            {
                MessageBox.Show("There is no selected part to remove from the product");
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            //If valid
            productToAdd = new Product
            {
                ProductId = int.Parse(tbID.Text),
                Price = decimal.Parse(tbPrice.Text),
                Name = tbName.Text,
                Min = int.Parse(tbMin.Text),
                Max = int.Parse(tbMax.Text),
                InStock = int.Parse(tbInventory.Text),
                AssociatedParts = _associatedParts
            };
            
            if (productToAdd.AssociatedParts.Count <= 0)
            {
                MessageBox.Show("This product has to have at least one part associated with it");
                return;
            }

            OnSave?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            tbID.Text = Generator.CreateNewId().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchResult = _availableParts.Where(x => x.Name.ToLower().Contains(tbSearchCandidateParts.Text.ToLower())).FirstOrDefault();
            if (searchResult == null)
            {
                MessageBox.Show("No matching parts found");
                tbSearchCandidateParts.ResetText();
                dgCandidateParts.ClearSelection();
                return;
            }

            var index = _availableParts.IndexOf(searchResult);
            dgCandidateParts.CurrentCell = dgCandidateParts.Rows[index].Cells[0];
            dgCandidateParts.Rows[index].Selected = true;
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
            int conversionCheck, min, max;
            int.TryParse(tbInventory.Text, out conversionCheck);
            int.TryParse(tbMin.Text, out min);
            int.TryParse(tbMax.Text, out max);
            
            if (string.IsNullOrEmpty(tbInventory.Text))
            {
                epValidator.SetError(tbInventory, "The inventory amount is required");
            }
            else if (!int.TryParse(tbInventory.Text, out conversionCheck))
            {
                epValidator.SetError(tbInventory, "Inventory should be a number");
            }
            else if (conversionCheck > max || conversionCheck < min)
            {
                epValidator.SetError(tbInventory, "Inventory should be between the Minimum and Maximum Quantities");
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

        private void tbMin_Validating(object sender, CancelEventArgs e)
        {
            tbMin.BackColor = Color.LightCoral;
            int min, max;
            var isNumber = int.TryParse(tbMin.Text, out min);
            int.TryParse(tbMax.Text, out max);

            if (string.IsNullOrEmpty(tbMin.Text))
            {
                epValidator.SetError(tbMin, "The minimum inventory amount is required");
            }
            else if (!isNumber)
            {
                epValidator.SetError(tbMin, "Minimum Inventory should be a number");
            }
            else if (min > max)
            {
                epValidator.SetError(tbMin, "Minimum quantity should be less than the Maximum Quantity");
            }
            else
            {
                tbMin.BackColor = Color.White;
                epValidator.SetError(tbMin, string.Empty);
            }
        }

        private void tbMax_Validating(object sender, CancelEventArgs e)
        {
            tbMax.BackColor = Color.LightCoral;
            int min, max;
            var isNumber = int.TryParse(tbMax.Text, out max);
            int.TryParse(tbMin.Text, out min);
            if (string.IsNullOrEmpty(tbMax.Text))
            {
                epValidator.SetError(tbMax, "The maximum inventory amount is required");
            }
            else if (!isNumber)
            {
                epValidator.SetError(tbMax, "Maximum Inventory should be a number");
            }
            else if (max < min)
            {
                epValidator.SetError(tbMax, "The Maximum inventory should be greater than the minimum");
            }
            else
            {
                tbMax.BackColor = Color.White;
                epValidator.SetError(tbMax, string.Empty);
            }
        }
    }
}
