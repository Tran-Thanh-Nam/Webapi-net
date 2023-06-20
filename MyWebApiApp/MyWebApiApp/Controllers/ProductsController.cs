using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Services;
using System.Globalization;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IHangHoaResposity _hanghoaResposity;

        public ProductsController(IHangHoaResposity hangHoaResposity)
        {
            _hanghoaResposity = hangHoaResposity;
        }

        [HttpGet]
        public IActionResult GetAllProducts(string search,double? from,double? to,
            string sortBy, int page = 1)
        {
            try
            {
                var result = _hanghoaResposity.GetAll(search, from,to, sortBy,page);
                return Ok(result);
            }
            catch 
            {
                return BadRequest("We can't get product.");
            }
        }


    }
}
