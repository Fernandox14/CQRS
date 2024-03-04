using CQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Products.Commands
{
    public class ProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
    }
}
