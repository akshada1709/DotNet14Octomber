using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Transactions;

namespace API.Model
{
    public class ViewDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Transaction> Transactions { get; set; }

        public ViewDataModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Transactions = _context.Transactions.ToList();
        }
    }
