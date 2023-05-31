using System.ComponentModel.DataAnnotations;

namespace Gara.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string logo {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public List <Service> services{ get; set; }

    }
}
