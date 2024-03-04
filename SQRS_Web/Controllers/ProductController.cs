using AutoMapper;
using CQRS.Application.DTOS;
using CQRS.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SQRS_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productAppService)
        {
            _productService = productAppService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Get()
        {
            return await _productService.GetProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productService.GetById(id);
            return product !=null ? Ok(product) : NotFound();
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var IsRemoved = await _productService.Remove(id);
            return IsRemoved ? Ok() : NotFound();
        }
    }
}
