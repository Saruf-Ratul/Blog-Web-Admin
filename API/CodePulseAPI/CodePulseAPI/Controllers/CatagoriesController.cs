using CodePulseAPI.Data;
using CodePulseAPI.Models.Domain;
using CodePulseAPI.Models.DTO;
using CodePulseAPI.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CodePulseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private readonly ICatagoryRepository catagoryRepository;

        public CatagoriesController(ICatagoryRepository catagoryRepository)
        {
            this.catagoryRepository = catagoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCatagoryRequestDto request)
        {
            //Map DTO to Domain Model
            var catagory = new Catagory
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };

            await catagoryRepository.CreateAsync(catagory);

            //Domain model to DTO
            var responce = new CatagoryDto
            {
                Id = catagory.Id,
                Name = catagory.Name,
                UrlHandle = catagory.UrlHandle,
            };

            return Ok(responce);
        }
    }
}
