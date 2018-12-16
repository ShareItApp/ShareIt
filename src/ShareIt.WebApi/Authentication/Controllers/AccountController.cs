using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShareIt.Core.Entities;
using ShareIt.WebApi.Authentication.ViewModels;
using System.Threading.Tasks;

namespace ShareIt.WebApi.Authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IMapper mapper;

        public AccountController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return new OkObjectResult("Gosho");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = this.mapper.Map<User>(model);

            return new OkObjectResult("Account created");
        }
    }
}