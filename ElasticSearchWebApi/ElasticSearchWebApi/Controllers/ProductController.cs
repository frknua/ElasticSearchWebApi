using ElasticSearchWebApi.Entities;
using ElasticSearchWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElasticSearchWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IElasticsearchService _elasticsearch;

        public ProductController(ILogger<ProductController> logger, IElasticsearchService elasticsearch)
        {
            _logger = logger;
            _elasticsearch = elasticsearch;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAll()
        {
            await _elasticsearch.ChekIndex("product");           
            var model = await _elasticsearch.GetDocuments("product");
            return Ok(model);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddProduct(List<Product> products)
        {
            await _elasticsearch.InsertDocuments("product", products);
            return Ok();
        }
    }
}
