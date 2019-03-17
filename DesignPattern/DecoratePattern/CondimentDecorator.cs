namespace DecoratePattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _Beverage;
        public CondimentDecorator(Beverage beverage)
        {
            _Beverage = beverage;
        }
        public override string GetDescription()
        {
            return _Beverage.GetDescription() + ", " + _Description;
        }
    }
}
