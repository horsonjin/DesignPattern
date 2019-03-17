namespace DecoratePattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _Description = "Espresso";
        }
        public override int Cost()
        {
            return 2;
        }
    }
}
