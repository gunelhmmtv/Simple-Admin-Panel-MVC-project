using AutoMapper;
using ProjectBusinessLogicLayer.Abstract;
using ProjectBusinessLogicLayer.DTOs;
using ProjectDataAccessLayer.Abstract;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        //public ProductService(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        //public ProductService(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;



        //}

        public  async Task AddProduct(ProductAddDto productAddDto)
        {
            if (productAddDto is null)
            {
                throw new Exception("Product can't be null");
            }



            if (productAddDto.Id != 0)
            {
                var product = await _productRepository.GetByIdAsync(productAddDto.Id);
                if (product != null)
                {
                    try
                    {
                        product.ProductName = productAddDto.ProductName;
                        product.Price = productAddDto.Price;
                        product.StockCount = productAddDto.StockCount;
                    }
                    catch (Exception e)
                    {
                        var message = e.Message;
                        throw;
                    }
                }
            }
            else
            {
                var product = _mapper.Map<Product>(productAddDto);
                bool result = await _productRepository.AddAsync(product);
                if (result is false)
                {
                    throw new Exception("Product can't add");
                }
            }
            await _productRepository.SaveChangesAsync();

        }

        public async Task<IEnumerable<ProductViewDto>> GetAllProduct()
        {
            var productList = await _productRepository.GetAllAsync();
            var productViewDtos = _mapper.Map<IEnumerable<ProductViewDto>>(productList);
           
            return productViewDtos;
        }
        public async Task<ProductAddDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductAddDto>(product);
        }
        public async Task Remove(int id)
        {
            var deletedProduct = await _productRepository.GetByIdAsync(id);

            if (deletedProduct is null)
            {
                throw new Exception("Product cant found");
            }
            _productRepository.Remove(deletedProduct);
            await _productRepository.SaveChangesAsync();

        }
    }
}
