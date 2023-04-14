using System.Linq;

namespace Customer.Service;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepo;
    public CustomerService(ICustomerRepository customerRepo) 
    {
        _customerRepo = customerRepo;
    }

    public CustomerRecord? GetCustomer(int customerId)
    {
        return _customerRepo.GetCustomers()?
                .SingleOrDefault(x => x.Id == customerId);
    }

    public IEnumerable<CustomerRecord> Search(CustomerSearchModel search)
    {
        var customers =  _customerRepo.GetCustomers();

        //if no customers return empty Ienumerable
        if(!customers.Any())
        {
            return Enumerable.Empty<CustomerRecord>();
        }

        //foreach search term lookup value
        //foreach value lookup operators and write out operation based on Enums selected
        
        return Enumerable.Empty<CustomerRecord>();
    }

}
