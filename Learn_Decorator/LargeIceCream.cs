namespace Learn_Decorator
{
    public class LargeIceCream : IceCream
    {
        public LargeIceCream()
        {
        }

        public override int GetPrice()
        {
            return 200;
        }
    }

}
