namespace Learn_Decorator
{
    public class IceCreamWithChocolate : IceCreamDecorator
    {
        public IceCreamWithChocolate(IceCream iceCream) : base(iceCream)
        {
        }
        public override int GetPrice()
        {
            return base.GetPrice() + (base.GetPrice() * 20 / 100);
        }
    }

}
