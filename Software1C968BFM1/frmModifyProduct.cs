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
    public partial class frmModifyProduct : Form
    {
        public Product ProductToUpdate { get; private set; }
        public event EventHandler OnSave;
        private readonly BindingList<Part> _candidateParts;
        public frmModifyProduct(Product product, BindingList<Part> candidateParts)
        {
            InitializeComponent();
            ProductToUpdate = product;
            _candidateParts = candidateParts;

            tbID.Text = ProductToUpdate.ProductId.ToString();
            tbName.Text = ProductToUpdate.Name;
            tbInventory.Text = ProductToUpdate.InStock.ToString();
            tbMin.Text = ProductToUpdate.Min.ToString();
            tbMax.Text = ProductToUpdate.Max.ToString();
            tbPrice.Text = ProductToUpdate.Price.ToString();
            dgProductParts.DataSource = ProductToUpdate.AssociatedParts;

            dgCandidateParts.DataSource = _candidateParts;

        }

        private void btnCancelAddProduct_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchResult = _candidateParts.Where(x => x.Name.ToLower().Contains(tbSearchCandidateParts.Text.ToLower())).FirstOrDefault();
            if (searchResult == null)
            {
                MessageBox.Show("No matching parts found");
                tbSearchCandidateParts.ResetText();
                dgCandidateParts.ClearSelection();
                return;
            }

            var index = _candidateParts.IndexOf(searchResult);
            dgCandidateParts.CurrentCell = dgCandidateParts.Rows[index].Cells[0];
            dgCandidateParts.Rows[index].Selected = true;
        }

        private void btnAddPartToProduct_Click(object sender, EventArgs e)
        {
            if (dgCandidateParts.SelectedRows.Count > 0)
            {
                var partToAdd = (Part)dgCandidateParts.CurrentRow.DataBoundItem;
                ProductToUpdate.AddAssociatedPart(partToAdd);
            }
            else
            {
                MessageBox.Show("Please select a part to add to the product");
            }
        }

        private void btnDeletePartFromProduct_Click(object sender, EventArgs e)
        {

            if(dgProductParts.SelectedRows.Count > 0)
            {
                var partToRemove = (Part)dgProductParts.CurrentRow.DataBoundItem;
                if(MessageBox.Show("Are you sure you want to remove this part from the product?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ProductToUpdate.RemoveAssociatePart(partToRemove.PartId);
                }   
            }
            else
            {
                MessageBox.Show("There is no selected part to remove from the product");
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            ProductToUpdate.ProductId = int.Parse(tbID.Text);
            ProductToUpdate.Name = tbName.Text;
            ProductToUpdate.Price = decimal.Parse(tbPrice.Text);
            ProductToUpdate.InStock = int.Parse(tbInventory.Text);
            ProductToUpdate.Max = int.Parse(tbMax.Text);
            ProductToUpdate.Min = int.Parse(tbMin.Text);

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
