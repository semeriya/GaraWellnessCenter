namespace Gara.Models
{
    public class Service_Customer
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Service  Service { get; set; }

        public int ServiceId { get; set; }
    }
}
 