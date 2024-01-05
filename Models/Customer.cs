namespace Customer.API.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }  
    }
}
