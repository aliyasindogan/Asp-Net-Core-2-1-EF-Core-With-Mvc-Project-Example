using System.Collections.Generic;

namespace AspDotNetCoreMvcProject.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double InStok { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
