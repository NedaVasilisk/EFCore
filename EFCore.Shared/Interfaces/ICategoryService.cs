using EFCore.Model;

namespace EFCore.Shared.Interfaces;
public interface ICategoryService
{
    Category? Add(string name);
    void Delete(Func<Category, bool> filter, bool loadRalatedData = false);
    public void Edit(int categoryIdToChange, string categoryName);
    bool Exists(string name);
    List<Category> GetCategoriesByName(string name);
    Category? GetCategoryById(int id);
    Category? GetCategoryByName(string name);
    List<Category> Search(Func<Category, bool> filter, bool loadRalatedData = false);
    int LoadProducts(Category category);
    
}