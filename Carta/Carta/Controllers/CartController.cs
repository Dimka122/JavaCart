using Carta.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carta.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CartController
    {
        [HttpPost]
        public void Add(Cart cart)
        {
            AnimalContext uc = new AnimalContext();
            uc.Carts.Add(cart);
            uc.SaveChanges();
        }
        [HttpGet]
        public IEnumerable<Cart> Get() => new AnimalContext().Carts;
        [HttpDelete]
        public void Delete(int id)
        {
            AnimalContext uc = new AnimalContext();
            uc.Carts.Remove(uc.Carts.Find(id));
            uc.SaveChanges();
        }
        [HttpPut]]
    }

}

