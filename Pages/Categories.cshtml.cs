using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages {
    public class CategoriesModel : PageModel {
        public List<Category> Categories { get; set; } = [];

        public void OnGet(int skip = 0) {
            //await Task.Delay(5000);
            List<Category> categories = [];

            for (int i = 1; i <= 200; i++)
                categories.Add(new Category(i, $"Categoria {i}", 1.25 * i));
            
            Categories = categories.Skip(skip).Take(25).ToList();
        }

        public void OnPost() { }
    }

    public record Category(int Id, string Title, double Price);
}
