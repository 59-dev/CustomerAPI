namespace System.Text.Json;

public class CustomerRepository : ICustomerRepository
{
    public IEnumerable<CustomerRecord> GetCustomers()
    {
        string fileName = "MOCK_DATA.json";
        string jsonString = File.ReadAllText(fileName);

        var records = JsonSerializer
                    .Deserialize<IEnumerable<CustomerRecord>>(jsonString);
        
        return records ?? Enumerable.Empty<CustomerRecord>();
    }
}
