namespace Patterns
{
    public interface ICar
    {
        void Vroom();
    }

    public class RedCar : ICar
    {
        public void Vroom()
        {
            Console.WriteLine("Red Vroom");
        }
    }

    public class BlueCar : ICar
    {
        public void Vroom()
        {
            Console.WriteLine("Blue Vroom");
        }
    }

    public abstract class CarFactory
    {
        public abstract ICar Fabricate();
    }

    public class RedCarFactory : CarFactory
    {
        public override ICar Fabricate()
        {
            return new RedCar();
        }
    }

    public class BlueCarFactory : CarFactory
    {
        public override ICar Fabricate()
        {
            return new BlueCar();
        }
    }
}
