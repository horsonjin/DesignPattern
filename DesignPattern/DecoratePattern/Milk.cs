namespace DecoratePattern
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            _Description = "Milk";
        }
        public override int Cost()
        {
            return 1;
        }
    }
}
