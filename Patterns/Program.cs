namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Singleton

            Tree tree_a = Tree.Instance;
            Tree tree_b = Tree.Instance;

            Console.WriteLine(tree_a.HasLeaves);
            tree_b.CutLeaves();
            Console.WriteLine(tree_a.HasLeaves);

            // Factory

            CarFactory fact_a = new RedCarFactory();
            CarFactory fact_b = new BlueCarFactory();

            ICar car_x = fact_a.Fabricate();
            ICar car_y = fact_b.Fabricate();

            car_x.Vroom();
            car_y.Vroom();

            // Builder
            
            PcShop coolmatica = new PcShop();
            coolmatica.Builder = new LaptopBuilder();

            Pc pc_a = coolmatica.BuildNoLightPc();

            coolmatica.Builder = new DesktopBuilder();

            pc_a = coolmatica.BuildNoLightPc();

            // State

            Automobile pijo = new Automobile();

            pijo.PressPedal();
            pijo.TurnKey();
            pijo.PressPedal();
            pijo.TurnKey();
            pijo.PressPedal();

            // Observer

            FastFoodPlace burgerKing = new FastFoodPlace();

            burgerKing.TakeOrder(new Client());
            burgerKing.TakeOrder(new Client());

            burgerKing.AnnounceOrder(42);

            burgerKing.TakeOrder(new Client());
            burgerKing.TakeOrder(new Client());
            burgerKing.TakeOrder(new Client());
            burgerKing.TakeOrder(new Client());

            burgerKing.AnnounceOrder(62);

            // Strategy

            Player player = new Player();

            player.Attack();

            player.Strategy = new ShootStrategy();
            player.Attack();

            player.Strategy = new StabbyStrategy();
            player.Attack();
        }
    }
}
