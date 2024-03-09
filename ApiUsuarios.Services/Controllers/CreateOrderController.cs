using Delivery.Notification.Application.Interfaces;
using Delivery.Order.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateOrderController : ControllerBase
    {
        //atributo
        private readonly IOrderAppService? _orderAppService;

        public CreateOrderController(IOrderAppService? orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpPost]
        public IActionResult Post(CreateOrderPostModel model)
        {
            try
            {
                Order order = new Order();
                order = _orderAppService.CreateOrder(model);

                return StatusCode(201, new
                {
                    message = "Pedido cadastrado com sucesso",
                    order
                });
            }
            catch (ArgumentException e)
            {
                return StatusCode(400, new
                {
                    error = e.Message
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    error = e.Message
                });
            }
        }
    }
}
