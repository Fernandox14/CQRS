using CQRS.Domain.Entities;
using CQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private new List<Product> List { get; set; }
        public ProductRepository()
        {
            this.List = new List<Product>()
            {
                new Product() { Id = 1, Name = "Honda Civic 2010", Description = "Carro da Honda" }
            };
        }
  
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return this.List;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return this.List.Where(x=> x.Id == id ).FirstOrDefault();
        }

        public async Task<bool> AddAsync(Product product)
        {
            this.List.Add(product);
            return true;
        }

        public async Task<bool> UdpdateAsync(Product product)
        {
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return true;
        }
    }
}
