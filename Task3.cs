using System;
using System.Collections.Generic;
using System.Linq; //Methods for querying objects

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public static class ProductSorting
{
    public static List<Product> SortProducts(List<Product> productList, bool ascending)
    {
        if (ascending)
        {
            return productList.OrderBy(p => p.Price).ThenBy(p => p.Name).ToList();
        }
        else
        {
            return productList.OrderByDescending(p => p.Price).ThenBy(p => p.Name).ToList();
        }
    }
}




/*
Now, to use this function in your testing process to verify the sorting functionality of the e-commerce platform, you can follow these steps:

1.Test Data Setup: Prepare a list of products with various price values and names that represent different scenarios for testing the sorting functionality.

2.Invoke the Sorting Function: In your test cases, invoke the SortProducts function with the test data and the sorting order (ascending or descending) you want to test.

3.Expected Results: Determine the expected order of products based on the sorting criteria specified in your test case. You can manually sort the test data in the expected order.

4.Assert the Results: Use assertions (e.g., NUnit assertions or custom assertions) to compare the actual sorted list of products returned by the function with the expected order of products. If they match, the sorting functionality is working correctly; otherwise, there may be a bug.

5.Repeat for Various Scenarios: Repeat these steps for various scenarios, including edge cases, to thoroughly test the sorting functionality.

6.Regression Testing: Include these test cases in your regression test suite to ensure that any changes or updates to the sorting functionality do not introduce new issues.

By using this function in your testing process, you can automate the verification of the sorting functionality, ensuring that products are correctly sorted based on their prices in both ascending and descending orders, and quickly detect any issues or regressions in the e-commerce platform.
*/