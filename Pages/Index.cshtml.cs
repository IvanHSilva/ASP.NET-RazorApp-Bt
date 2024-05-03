using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages {
    public class IndexModel : PageModel {

        public List<Category> Categories { get; set; } = [];

        public async Task OnGet() {
            await Task.Delay(5000);
            for (int i = 1; i <= 100; i++)
                Categories.Add(new Category(i, $"Categoria {i}", 1.25 * i));
        }

        public void OnPost() { }
    }

    public record Category(int Id, string Title, double Price);
}
