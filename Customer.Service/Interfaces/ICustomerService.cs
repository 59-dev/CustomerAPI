
public interface ICustomerService
{
    CustomerRecord? GetCustomer(int customerId);
    IEnumerable<CustomerRecord> Search(CustomerSearchModel customerSearchModel);
}