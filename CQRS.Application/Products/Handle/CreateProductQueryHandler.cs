using CQRS.Application.DTOS;
using CQRS.Application.Interfaces;
using CQRS.Application.Products.Queries;
using CQRS.Domain.Entities;
using CQRS.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Application.Products.Handle
{
    public class CreateProductQueryHandler : IRequestHandler<CreateProductsQuery, Boolean>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(CreateProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.AddAsync(new Product() {Name = request.Name, Description = request.Description });
        }
    }
}
