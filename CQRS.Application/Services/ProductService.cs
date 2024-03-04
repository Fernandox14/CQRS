using AutoMapper;
using CQRS.Application.DTOS;
using CQRS.Application.Interfaces;
using CQRS.Application.Products.Queries;
using CQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Services
{
    public class ProductService : IProductService
    {

        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public ProductService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var productsQuery = new GetProductsByIdQuery(id);

            if (productsQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(productsQuery);

            return _mapper.Map<ProductDTO>(result);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if (productsQuery == null)
                throw new Exception($"Entity could not be loaded.");

            var result = await _mediator.Send(productsQuery);

            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

        public async Task<bool> Add(ProductDTO productDto)
        {
            var Query = new CreateProductsQuery();

            if (Query == null)
                throw new Exception($"Entity could not be loaded.");

            return await _mediator.Send(Query);
        }

        public async Task<bool> Remove(int id)
        {
            var Query = new DeleteProductsQuery(id);

            if (Query == null)
                throw new Exception($"Entity could not be loaded.");

            return await _mediator.Send(Query);
        }

        public async Task<bool> Update(ProductDTO productDto)
        {
            var Query = new UpdateProductsQuery();

            if (Query == null)
                throw new Exception($"Entity could not be loaded.");

            return await _mediator.Send(Query);
        }
    }
}
