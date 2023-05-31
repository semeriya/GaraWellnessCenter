using System.ComponentModel.DataAnnotations;

namespace Gara.Models
{
    public class Customer
    {
        [Key]   

        
        public int Id { get; set; }

        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        [DisplayFormat(NullDisplayText = "please specfiy gender")]
        public string Gender { get; set; }

        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        //relational mapping 
        public List <Service_Customer> Service_Customers { get; set; }
    }
}
