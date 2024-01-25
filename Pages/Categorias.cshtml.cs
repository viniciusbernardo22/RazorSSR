
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages
{
    public class CategoriasModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet(int skip = 0, int take = 50)
        {
            var temp = new List<Category>();
            for (int i = 0; i <= 800; i++)
            {
                temp.Add(new Category(i, $"Categoria {i}", i * 18.95M));
            }

            Categories = temp.Skip(skip).Take(take).ToList();
        }
    }
}

public record Category(int Id, string Title, decimal Price);

