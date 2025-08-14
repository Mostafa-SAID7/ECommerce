public interface IProductService {
    Task<IEnumerable<Product>> GetAllProductsAsync();
}

public class ProductService : IProductService {
    private readonly IProductRepository _repo;
    public ProductService(IProductRepository repo) {
        _repo = repo;
    }
    public Task<IEnumerable<Product>> GetAllProductsAsync() => _repo.GetAllAsync();
}
