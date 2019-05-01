using System.Collections.Generic;

namespace AspDotNetCoreMvcProject.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }

}
