﻿using CQRS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Products.Queries
{
    public class GetProductsByIdQuery : IRequest<Product>
    {
        public GetProductsByIdQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
