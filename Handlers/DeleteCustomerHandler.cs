using Customer.API.Commands;
using Customer.API.Repositories;
using MediatR;

namespace Customer.API.Handlers
{
    public class DeleteCustomerHandler:IRequestHandler<DeleteCustomerCommand, int>
    {
        private readonly ICustomerRepository customerRepository;
        public DeleteCustomerHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<int> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customerRepository.DeleteCustomer(request.CustomerId);
        }
    }
}
