using Core.Entities;
using Core.Interfaces;

namespace Application.Services;

public class ProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Product>> GetAllProducts() => _repository.GetAllAsync();
    public Task<Product> GetProductById(int id) => _repository.GetByIdAsync(id);
    public Task AddProduct(Product product) => _repository.AddAsync(product);
    public Task UpdateProduct(Product product) => _repository.UpdateAsync(product);
    public Task DeleteProduct(int id) => _repository.DeleteAsync(id); 

}
