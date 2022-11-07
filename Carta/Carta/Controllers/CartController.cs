using Carta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        //[HttpGet]
        //public IEnumerable<Cart> Get() => new AnimalContext().Carts;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> Get()
        {
            return await new AnimalContext().Carts.ToListAsync();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            AnimalContext uc = new AnimalContext();
            uc.Carts.Remove(uc.Carts.Find(id));
            uc.SaveChanges();
        }
        [HttpPut]
        public void Update(Cart cart)
        {
            AnimalContext uc = new AnimalContext();
            uc.Carts.Update(cart);
            uc.SaveChanges();
        }
    }

}

