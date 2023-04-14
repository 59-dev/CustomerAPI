public class CustomerSearchModel
{
    public List<string> SearchValues {get; set;}
    public SortOrderEnum SortOrder {get; set;}
    public SearchCategoryEnum SearchCategory {get; set;}
    public SearchFilterEnum SearchFilter {get; set;}
    public int SearchOperationOrder {get; set;}
    List<CustomerSearchModel> NestedSearchOperations {get; set;}

}

public enum SortOrderEnum
{
    ASC,
    DESC
}

public enum SearchCategoryEnum
{
    ID,
    FirstName,
    LastName,
    Email,
    Address,
    ZipCode,
    State,
    ActiveStatus,
    MonthlyIncome,
    JobTitle,
    FavoriteColor
}

public enum SearchFilterEnum
{
    Equal,
    DoesNotEqual,
    GreaterThan,
    LessThan
}