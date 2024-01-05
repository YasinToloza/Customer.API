using Customer.API.Queries;
using Customer.API.Repositories;
using MediatR;

namespace Customer.API.Handlers
{
    public class GetCustomerByIdHandler:IRequestHandler<GetCustomerByIdQuery, Models.Customer>
    {
        private readonly ICustomerRepository customerRepository;
        public GetCustomerByIdHandler(ICustomerRepository customerRepository) 
        {
            this.customerRepository = customerRepository;
        }

        public async Task<Models.Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return await customerRepository.GetCustomerById(request.CustomerId);
        }
    }
}
