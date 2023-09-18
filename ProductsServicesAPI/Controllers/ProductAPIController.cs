using Microsoft.AspNetCore.Mvc;
using ProductsServicesAPI.Models.DTO;
using ProductsServicesAPI.Repository;
using System.Security.Cryptography.X509Certificates;

namespace ProductsServicesAPI.Controllers
{
    [Route("api/product")]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDTO _response;
        private IProductRepository _productRepository;

        public ProductAPIController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _response = new ResponseDTO();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDTO> productDtos = await _productRepository.GetProducts();
                _response.Result = productDtos;

            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }
            return _response;
        }


    }
}
