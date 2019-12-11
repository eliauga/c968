using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1C968BFM1.Domain
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void AddAssociatedPart(Part partToAssociate)
        {
            AssociatedParts.Add(partToAssociate);
        }

        public Part LookupAssociatePart(int partId)
        {
            var part = AssociatedParts.Where(x => x.PartId == partId).FirstOrDefault();
            if (part == null)
                throw new Exception(message: "No matching parts could be found.");

            return part;
        }

        public bool RemoveAssociatePart(int partId)
        {
            var partToRemove = AssociatedParts.Where(x => x.PartId == partId).FirstOrDefault();

            if (partToRemove == null)
                return false;

            AssociatedParts.Remove(partToRemove);
            return true;
        }
    }
}
