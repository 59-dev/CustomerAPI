public interface ICustomerRepository
{
    IEnumerable<CustomerRecord> GetCustomers();
}