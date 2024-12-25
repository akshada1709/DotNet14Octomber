using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace API.Model
{
    public class MaintenanceModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Transaction Transaction { get; set; }

        public MaintenanceModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // Handle page load if needed
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Transactions.Add(Transaction);
                await _context.SaveChangesAsync();
                return RedirectToPage("/ViewData");  // Redirect to ViewData page after adding the transaction
            }

            return Page();
        }
    }
}