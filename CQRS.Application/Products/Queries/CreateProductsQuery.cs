using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Products.Queries
{
    public class CreateProductsQuery : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
