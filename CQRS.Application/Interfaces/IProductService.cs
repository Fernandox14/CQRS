using CQRS.Application.DTOS;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetById(int id);
        Task<bool> Add(ProductDTO productDto);
        Task<bool> Update(ProductDTO productDto);
        Task<bool> Remove(int id);
    }
}
