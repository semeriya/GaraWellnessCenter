using System.ComponentModel.DataAnnotations;

namespace Gara.Models
{
    public class Instructor
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DisplayFormat(NullDisplayText = "Gender not specfied")]
        public string Gender { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Hiringdate { get; set; }
        public string Position { get; set; }
        [DataType(DataType.Currency)]
        public int salary { get; set; }

        public string Address { get; set; }
        //we create the realtionship with services one insrtructor can provide many services
        public List <Service> services { get; set; }
    }
}
