using Customer.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Customer.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext dbContext;
        public CustomerRepository(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Models.Customer>> GetCustomers()
        {
            return await dbContext.Customers.ToListAsync();
        }

        public async Task<Models.Customer> GetCustomerById(int id)
        {
            return await dbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == id);
        }

        public async Task<Models.Customer> CreateCustomer(Models.Customer customer)
        {
            dbContext.Customers.Add(customer);
            await dbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<int> UpdateCustomer(Models.Customer customer)
        {
            dbContext.Customers.Update(customer);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteCustomer(int id)
        {
            var customer = dbContext.Customers
                .Where(c => c.CustomerId == id).FirstOrDefault();
            if (customer == null)
            {
                return 0;
            }
            dbContext.Customers.Remove(customer);
            return await dbContext.SaveChangesAsync();      
        }
    }
}
