namespace Customer.API.Repositories
{
    public interface ICustomerRepository
    {
        public Task<List<Models.Customer>> GetCustomers();
        public Task<Models.Customer> GetCustomerById(int id);
        public Task<Models.Customer> CreateCustomer(Models.Customer customer);
        public Task<int> UpdateCustomer(Models.Customer customer);
        public Task<int> DeleteCustomer(int id);
    }
}
