using ProjectBusinessLogicLayer.DTOs;
using ProjectEntities.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewDto>> GetAllProduct();
        Task AddProduct(ProductAddDto productAddDto);
        Task Remove(int id);
        Task<ProductAddDto> GetProductByIdAsync(int id);

    }
}
