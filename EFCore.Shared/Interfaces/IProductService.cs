using EFCore.Model;

namespace EFCore.Shared.Interfaces;
public interface IProductService
{
    Product Add(Product product);
    void Delete(Func<Product, bool> filter, bool loadRalatedData = false);
    void Edit(int productIdToChange, string productName, string productDescription, decimal productPrice);
    Product? GetProductById(int id);
    List<Product> GetProductsByName(string productName);
    int LoadCategories(Product product);
    List<Product> Search(Func<Product, bool> filter, bool loadRalatedData = false);
}