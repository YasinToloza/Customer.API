using Customer.API.Commands;
using Customer.API.Repositories;
using MediatR;

namespace Customer.API.Handlers
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, int>
    {
        private readonly ICustomerRepository customerRepository;

        public UpdateCustomerHandler(ICustomerRepository customerRepository) 
        {
            this.customerRepository = customerRepository;
        }

        public async Task<int> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            Models.Customer customer = new Models.Customer()
            {
                CustomerId = request.CustomerId,
                CustomerName = request.CustomerName,
                Email = request.Email,
                Phone = request.Phone
            };
            return await customerRepository.UpdateCustomer(customer);
        }
    }
}
