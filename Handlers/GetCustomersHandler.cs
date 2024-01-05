using Customer.API.Queries;
using Customer.API.Repositories;
using MediatR;

namespace Customer.API.Handlers
{
    public class GetCustomersHandler : IRequestHandler<GetCustomersQuery, List<Models.Customer>>
    {
        private readonly ICustomerRepository customerRepository;
        public GetCustomersHandler(ICustomerRepository customerRepository)
        { 
            this.customerRepository = customerRepository;
        }

        public async Task<List<Models.Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return await customerRepository.GetCustomers();
        }
    }
}
