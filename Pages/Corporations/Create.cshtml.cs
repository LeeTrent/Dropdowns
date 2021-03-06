using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dropdowns.Data;
using Dropdowns.Models;

namespace Dropdowns.Pages.Corporations
{
    public class CreateModel : PageModel
    {
        private readonly Dropdowns.Data.DropdownContext _context;

        public CreateModel(Dropdowns.Data.DropdownContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ContinentID"] = new SelectList(_context.Continents, "ContinentID", "ContinentName");
        ViewData["CountryID"] = new SelectList(_context.Contries, "CountryID", "CountryName");
            return Page();
        }

        [BindProperty]
        public Corporation Corporation { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Corporations.Add(Corporation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

       public JsonResult OnGetCountiesInContinent(int contID) 
        {
            List<Country> countryList = _context.Contries.Where( c => c.ContinentID == contID ).ToList();
            return new JsonResult(new SelectList(countryList, "CountryID", "CountryName"));
        }        
    }
}