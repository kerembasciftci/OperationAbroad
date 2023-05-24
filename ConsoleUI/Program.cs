using Service.Mapping;
using Service.Services;

ProductService productService = new ProductService(productRepository,MapProfile);