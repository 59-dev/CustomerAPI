using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Customer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger)
    {
        _customerService = customerService;
        _logger = logger;
    }

    [HttpGet(Name = "GetCustomer")]
    public CustomerRecord? Get(int customerId)
    {
        return _customerService.GetCustomer(customerId);
    }

    [HttpPost(Name = "SearchCustomer")]
    public IEnumerable<CustomerRecord> Post(CustomerSearchModel search)
    {
        return _customerService.Search(search);
    }
}
