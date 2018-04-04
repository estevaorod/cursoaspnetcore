using StoreOfBuild.Domain.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class ProductStorer
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductStorer(IRepository<Product> productRepository, 
                             IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public void Store(ProductDto productDto)
        {
            var category = _categoryRepository.GetById(productDto.Category);
            DomainException.When(category == null, "Category invalid");

            var product = _productRepository.GetById(productDto.Id);

            if(product == null)
            {
                product = new Product(productDto.Name, category, productDto.Price, productDto.StockQuantity);
                _productRepository.Save(product);
            } else 
            {
                product.Update(productDto.Name, category, productDto.Price, productDto.StockQuantity);
            }
        }
    }
}