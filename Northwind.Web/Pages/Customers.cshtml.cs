using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Web.Pages;

public class CustomersModel : PageModel
{
    private NorthwindContext db;

    [BindProperty]
    public Customer? Customer { get; set; }
    public IEnumerable<Customer?> Customers { get; set; } = null!;

    public CustomersModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }

    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Customers";

        Customers = db.Customers.OrderBy(c => c.Country);
    }
}

