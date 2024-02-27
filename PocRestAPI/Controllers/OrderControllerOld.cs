using Microsoft.AspNetCore.Mvc;
using PocRestAPI.Models;
using System.Net;
using SecuringWebApiUsingApiKey.Attributes;

namespace PocRestAPI.Controllers
{
    [ApiController]
    [ApiKey]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "ImportOrder")]
        public async Task<ActionResult<HttpResponseMessage>> ImportOrder(JsonOrder jsonOrder)
        {
            return await CreateOrder(jsonOrder);
        }

        private Task<HttpResponseMessage> CreateOrder(JsonOrder jsonOrder)
        {
            Order order = new(jsonOrder);
            return Task.FromResult(order.isValid ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.UnprocessableEntity));
        }
    }
}