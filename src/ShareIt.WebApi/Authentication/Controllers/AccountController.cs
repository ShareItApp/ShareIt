using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShareIt.Data.Auth;
using ShareIt.Data.Auth.Entities;
using ShareIt.WebApi.Authentication.ViewModels;
using System.Threading.Tasks;

namespace ShareIt.WebApi.Authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly IAuthManager authManager;

        public AccountController(IMapper mapper, IAuthManager authManager)
        {
            this.mapper = mapper;
            this.authManager = authManager;
        }

        public IActionResult Index()
        {
            return new OkObjectResult("Gosho");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = this.mapper.Map<User>(model);
            var isSuccessful = await this.authManager.CreateUserAsync(userIdentity, model.Password);

            if (!isSuccessful)
            {
                return new BadRequestObjectResult(ModelState);
            }

            this.authManager.SaveChangesAsync();

            return new OkObjectResult("Account created");
        }
    }
}