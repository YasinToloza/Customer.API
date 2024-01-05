using MediatR;

namespace Customer.API.Commands
{
    public class UpdateCustomerCommand:IRequest<int>
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
