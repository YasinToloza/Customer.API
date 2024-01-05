using Customer.API.Commands;
using Customer.API.Repositories;
using MediatR;

namespace Customer.API.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Models.Customer>
    {
        private readonly ICustomerRepository customerRepository;
        public CreateCustomerHandler(ICustomerRepository customerRepository) 
        {
            this.customerRepository = customerRepository;
        }

        public async Task<Models.Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            Models.Customer customer = new Models.Customer()
            {
                CustomerName = request.CustomerName,
                Email = request.Email,
                Phone = request.Phone
            };

            return await customerRepository.CreateCustomer(customer);
        }
    }
}
