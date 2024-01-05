using MediatR;

namespace Customer.API.Commands
{
    public class CreateCustomerCommand:IRequest<Models.Customer>
    {
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
