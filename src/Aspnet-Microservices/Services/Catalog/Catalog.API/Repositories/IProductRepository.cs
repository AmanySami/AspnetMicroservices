using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        //GetProduct()-->list
        Task<IEnumerable<Product>> GetProducts();
        //GetProductById(string id)-->return one product based Id
        Task<Product> GetProductById(string id);
        //GetProductByName(string productName)---> return list from products based Product Name
        Task<IEnumerable<Product>> GetProductByName(string productName);
        //GetProductByCategoryName(string categoryName)---> return list from products based Category Name
        Task<IEnumerable<Product>> GetProductByCategoryName(string categoryName);
        //CreateProduct(Product productObject) -->Task
        Task CreateProduct(Product product);
        //UpdateProduct(Product product)-->return bool
        Task<bool> UpdateProduct(Product product);
        //DeleteProduct(string id)-->return bool
        Task<bool> DeleteProduct(string id);

    }
}
