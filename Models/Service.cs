using Gara.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gara.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int price { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }

        public Available   available { get; set; }
        public List<Service_Customer> Service_Customers { get; set; }
        //category
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        //Instructor
        public int InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }
    }
}
