using MediatR;

namespace Customer.API.Queries
{
    public class GetCustomersQuery:IRequest<List<Models.Customer>>
    {
    }
}
