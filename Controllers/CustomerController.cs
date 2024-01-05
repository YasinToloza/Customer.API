using Customer.API.Commands;
using Customer.API.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private IMediator mediator;
        public CustomerController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Models.Customer>> GetCustomers()
        {
            return await mediator.Send(new GetCustomersQuery());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<Models.Customer> GetCustomerById(int id)
        {
            return await mediator.Send(new GetCustomerByIdQuery() { CustomerId = id });
        }
        [HttpPost]
        public async Task<Models.Customer> CreateCustomer(Models.Customer customer)
        {
            return await mediator.Send(new CreateCustomerCommand()
            {
                CustomerName = customer.CustomerName,
                Email = customer.Email,
                Phone = customer.Phone
            });
        }

        [HttpPut]
        public async Task<int> UpdateCustomer(Models.Customer customer)
        {
            return await mediator.Send(new UpdateCustomerCommand()
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                Email = customer.Email,
                Phone = customer.Phone
            });
        }
        [HttpDelete]
        public async Task<int> DeleteCustomer(int id) 
        {
            return await mediator.Send(new DeleteCustomerCommand()
            {
                CustomerId = id
            });
        }
    }
}
