using AbbyWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbbyWeb.Model;

namespace AbbyWeb.Pages.Category
{
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;

		public Category Category { get; set; }
		public CreateModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
        {
        }
    }
}
