using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Products.Queries
{
    public class DeleteProductsQuery : IRequest<bool>
    {
        public DeleteProductsQuery(int Id)
        {
            this.Id = Id;
        }
        public int Id { get; set; }
    }
}
