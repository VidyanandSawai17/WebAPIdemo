using WebAPIdemo.Models;

namespace WebAPIdemo.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);

    }
}
