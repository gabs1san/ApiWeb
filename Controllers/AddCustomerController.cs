using ApiWeb.Models.AddCostumer;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            return Created("", input);
        }
    }
}
