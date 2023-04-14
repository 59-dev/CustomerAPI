public class CustomerRecord
{
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}
    public Address BillingAddress {get; set;}
    public bool? IsActive {get; set;}
    public decimal MonthlyIncome {get; set;}
    public string JobTitle {get; set;}
    public string? FavoriteColor {get; set;}
}