using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Web.Pages;

public class CustomerDetailsModel : PageModel
{
    private NorthwindContext db;

    [Parameter]
    public string? Id { get; set; }

    [BindProperty]
    public Customer? Customer { get; set; }
    
    public CustomerDetailsModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }

    public void OnGet()
    {
        //Customer = db.Customers.FirstOrDefault(c => c.CustomerId == Id);
        
        //ViewData["Title"] = $"Northwind B2B - {Customer!.CompanyName}";

        ViewData["Title"] = $"Northwind B2B - CustomerDetails for {Id}";
    }
}

