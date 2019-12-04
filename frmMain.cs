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
    public partial class frmMain : Form
    {
        private readonly Inventory _inventory;
        private frmAddPart addPartForm;
        private frmModifyPart modifyPartForm;
        private frmAddProduct addProductForm;
        private frmModifyProduct modifyProductForm;
        public frmMain()
        {
            InitializeComponent();
            
            _inventory = new Inventory();
            _inventory.Parts.Add(new Inhouse
            {
                PartId = Generator.CreateNewId(),
                Name = "Wheel",
                Price = 12.25M,
                InStock = 15,
                Min = 10,
                Max = 20,
                MachineID = 110,
            });
            _inventory.Parts.Add(new Inhouse
            {
                PartId = Generator.CreateNewId(),
                Name = "Bearing",
                Price = 2.50M,
                InStock = 11,
                Min = 5,
                Max = 20,
                MachineID = 111,
            });
            _inventory.Parts.Add(new Outsourced
            {
                PartId = Generator.CreateNewId(),
                Name = "Handle",
                Price = 7.75M,
                InStock = 10,
                Min = 5,
                Max = 20,
                CompanyName = "Handle Makers",
            });
            _inventory.Products.Add(new Product
            {
                ProductId = Generator.CreateNewId(),
                Name = "Bike",
                InStock = 5,
                Min = 2,
                Max = 8,
                Price = 125.50M,
                
            });
            _inventory.Products[0].AddAssociatedPart(_inventory.Parts[0]);
            _inventory.Products[0].AddAssociatedPart(_inventory.Parts[1]);
            _inventory.Products[0].AddAssociatedPart(_inventory.Parts[2]);
        }
        void AddPartForm_OnSave(object sender, EventArgs e)
        {
            _inventory.AddPart(addPartForm.PartToCreate);
        }
        void ModifyPartForm_OnSave(object sender, EventArgs e)
        {
            _inventory.UpdatePart(modifyPartForm.partToUpdate.PartId, modifyPartForm.partToUpdate);
            _inventory.Parts.ResetBindings();
        }
        void ModifyProductForm_OnSave(object sender, EventArgs e) 
        {
            _inventory.UpdateProduct(modifyProductForm.ProductToUpdate.ProductId, modifyProductForm.ProductToUpdate);
            _inventory.Products.ResetBindings();
        }
        void AddProductForm_OnSave(object sender, EventArgs e) 
        {
            _inventory.AddProduct(addProductForm.productToAdd);
        }
        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            addPartForm = new frmAddPart();
            addPartForm.OnSave += new EventHandler(AddPartForm_OnSave);
            addPartForm.Show();   
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            addProductForm = new frmAddProduct(_inventory.Parts);
            addProductForm.OnSave += new EventHandler(AddProductForm_OnSave);
            addProductForm.Show();
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
         
            if(dgParts.SelectedRows.Count > 0)
            {

                var part = dgParts.CurrentRow.DataBoundItem;
                if(part.GetType() == typeof(Inhouse))
                {
                    modifyPartForm = new frmModifyPart((Inhouse)part);
                }
                else
                {
                    modifyPartForm = new frmModifyPart((Outsourced)part);
                }
                modifyPartForm.OnSave += new EventHandler(ModifyPartForm_OnSave);
                modifyPartForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify");
            }
            
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if(dgProducts.SelectedRows.Count > 0)
            {
                var product = dgProducts.CurrentRow.DataBoundItem;
                modifyProductForm = new frmModifyProduct((Product)product, _inventory.Parts);
                modifyProductForm.OnSave += new EventHandler(ModifyProductForm_OnSave);
                modifyProductForm.Show();
            }
            else
            {
                MessageBox.Show("Please Select a product to modify");
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgParts.DataSource = _inventory.Parts;
            dgProducts.DataSource = _inventory.Products;
            dgParts.ClearSelection();
            dgProducts.ClearSelection();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgParts.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this part?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var result = _inventory.RemovePart(int.Parse(dgParts.SelectedRows[0].Cells[0].Value.ToString()));
                    if (result)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong, the part could not be removed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure a part is selected before attempting to delete");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgProducts.SelectedRows.Count > 0)
            {
                var product = (Product)dgProducts.CurrentRow.DataBoundItem;
                if (MessageBox.Show("Are you sure you want to remove this product?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        // refactor 
                        if (_inventory.LookupProduct(product.ProductId).AssociatedParts.Any())
                        {
                            MessageBox.Show("A product can't have any associated parts in order to be deleted");
                            return;
                        }
                        
                        var result = _inventory.RemoveProduct(product.ProductId);
                        if (!result)
                        {
                            MessageBox.Show("Something went wrong, the product could not be removed");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong, the product could not be removed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure a part is selected before attempting to delete");
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            var  searchResult = _inventory.Parts.Where(x => x.Name.ToLower().Contains(tbSearchPart.Text.ToLower())).FirstOrDefault();
            if(searchResult == null)
            {
                MessageBox.Show("No matching parts found");
                tbSearchPart.ResetText();
                dgParts.ClearSelection();
                return;
            }

            var index = _inventory.Parts.IndexOf(searchResult);
            dgParts.CurrentCell = dgParts.Rows[index].Cells[0];
            dgParts.Rows[index].Selected = true;

            
        }

        private void pMainContainer_Click(object sender, EventArgs e)
        {
            dgParts.ClearSelection();
            dgProducts.ClearSelection();
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            var searchResult = _inventory.Products.Where(x => x.Name.ToLower().Contains(tbSearchProducts.Text.ToLower())).FirstOrDefault();
            if (searchResult == null)
            {
                MessageBox.Show("No matching products found");
                tbSearchProducts.ResetText();
                dgProducts.ClearSelection();
                return;
            }

            var index = _inventory.Products.IndexOf(searchResult);
            dgProducts.CurrentCell = dgParts.Rows[index].Cells[0];
            dgProducts.Rows[index].Selected = true;
        }
    }
}
