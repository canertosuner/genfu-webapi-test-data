using GenFu;
using Genfu_Sample.Dto;
using Genfu_Sample.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Genfu_Sample.Controller
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public GetAllProductResponse Get()
        {
            //var product = A.New<ProductDto>();

            var listOfProduct = A.ListOf<ProductDto>(5);

            return new GetAllProductResponse
            {
                ProductList = listOfProduct
            };
        }
    }
}
