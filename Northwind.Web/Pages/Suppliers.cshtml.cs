using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{
    private NorthwindContext db;
    
    [BindProperty]
    public Supplier? Supplier { get; set; }
    public IEnumerable<Supplier?> Suppliers { get; set; } = null!;

    public SuppliersModel(NorthwindContext injectedContext)
    {
        db = injectedContext;
    }

    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";

        Suppliers = db.Suppliers.OrderBy(c => c.Country)
                                .ThenBy(c => c.CompanyName);
    }

    public IActionResult OnPost()
    {
        if ((Supplier is not null) && ModelState.IsValid)
        {
            db.Suppliers.Add(Supplier);
            db.SaveChanges();
            return RedirectToPage("/suppliers");
        }
        else
        {
            return Page();  // return to original page
        }
    }
}
