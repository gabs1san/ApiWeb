using ApiWeb.Models.AddCostumer;
using Domain.Contracts.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCurstomerUseCase _addCustomerUseCase;

        public AddCustomerController(IAddCurstomerUseCase addCustomerUseCase)
        {
            _addCustomerUseCase = addCustomerUseCase;
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            var customer = new Domain.Entities.Customer(input.Name, input.Email, input.Document);
            _addCustomerUseCase.AddCurstomerUseCase(customer);
            return Created("", customer);
        }
    }
}
