using MediatR;
namespace Customer.API.Queries
{
    public class GetCustomerByIdQuery:IRequest<Models.Customer>
    {
        public int CustomerId { get; set; }
    }
}
