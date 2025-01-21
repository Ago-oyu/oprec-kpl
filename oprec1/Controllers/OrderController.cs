using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace oprec1.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        Orders orders = new Orders();

        [HttpGet]
        public IEnumerable<Order> Get() 
        {
            return orders.Data;
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orders.Data[id];
        }

        [HttpPost]
        public void Post([FromBody] Order order)
        {
            orders.Data.Add(order);
            orders.writeJSON();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order order)
        {
            orders.Data[id] = order;
            orders.writeJSON();
        }


        [HttpDelete]
        public void Delete(int id)
        {
            orders.Data.RemoveAt(id);
            orders.writeJSON();
        }
    }
}
