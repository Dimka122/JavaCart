namespace Carta.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string CVV { get; set; }
        public List<Animal> Carts { get; set; }

    }
}
