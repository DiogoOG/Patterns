namespace Patterns
{
    public abstract class Pasta
    {
        public abstract string ShowPlate();
    }

    public class Spaghetti : Pasta
    {
        public override string ShowPlate()
        {
            return "Spaghetti";
        }
    }

    public abstract class Ingredient : Pasta
    {
        public Pasta Plate { get; }

        public Ingredient(Pasta pasta)
        {
            Plate = pasta;
        }
    }

    public class FreshShrooms : Ingredient
    {
        public FreshShrooms(Pasta pasta) : base(pasta) { }

        public override string ShowPlate()
        {
            return Plate.ShowPlate() + " with fresh shrooms";
        }
    }

    public class Cream : Ingredient
    {
        public Cream(Pasta pasta) : base(pasta) { }

        public override string ShowPlate()
        {
            return Plate.ShowPlate() + " with cream";
        }
    }
}
