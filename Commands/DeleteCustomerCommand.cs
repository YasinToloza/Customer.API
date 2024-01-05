using MediatR;

namespace Customer.API.Commands
{
    public class DeleteCustomerCommand:IRequest<int>
    {
        public int CustomerId { get; set; }
    }
}
