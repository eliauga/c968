using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1C968BFM1.Domain
{
    public class Inventory
    {
        public BindingList<Product> Products {get; set;}
        public BindingList<Part> Parts { get; set; }
        
        public Inventory()
        {
            Products = new BindingList<Product>();
            Parts = new BindingList<Part>();
        }

        public void AddProduct(Product productToAdd)
        {
            Products.Add(productToAdd);
        }

        public void AddPart(Part partToAdd)
        {
            Parts.Add(partToAdd);
        }

        public Product LookupProduct(int productId)
        {
            var product = Products.Where(x=> x.ProductId == productId).FirstOrDefault();

            if (product == null)
                throw new Exception(message: "No matching product could be found.");

            return product;
        }

        public Part LookupPart(int partId)
        {
            var part = Parts.Where(x=> x.PartId == partId).FirstOrDefault();
            
            if (part == null)
                throw new Exception(message: "No matching part could be found.");

            return part;
        }

        public void UpdateProduct(int productId, Product productToUpdate)
        {
            if (productId != productToUpdate.ProductId)
                throw new Exception(message: "Product Id did not match, update stopped");

            var product = Products.Select((Product, index) => new { Product, index }).FirstOrDefault(x => x.Product.ProductId == productId);
             
            if(product == null)
                throw new Exception(message: "Could not update the product");

            Products[product.index] = productToUpdate;
        }

        public void UpdatePart(int partId, Part partToUpdate)
        {
            if (partId != partToUpdate.PartId)
                throw new Exception(message: "Part Id did not match, update stopped");


            var part = Parts.Select((Part, index) => new { Part, index }).FirstOrDefault(x => x.Part.PartId == partToUpdate.PartId);

            if (part == null)
                throw new Exception(message: "Could Not Update the part");

            Parts[part.index] = partToUpdate;
        }

        public bool RemoveProduct(int productId)
        {
            var productToRemove = Products.Where(x => x.ProductId == productId).FirstOrDefault();

            if (productToRemove == null)
                return false;

            if (productToRemove.AssociatedParts.Any())
                return false;

            productToRemove.AssociatedParts = null;
            Products.Remove(productToRemove);
            return true;
        }

        public bool RemovePart(int partId)
        {
            var partToRemove = Parts.Where(x => x.PartId == partId).FirstOrDefault();

            if (partToRemove == null)
                return false;

            Parts.Remove(partToRemove);
            return true;
        }
    }
}
