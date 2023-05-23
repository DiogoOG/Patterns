using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            Coolmatica coolmatica = new Coolmatica();
            coolmatica.Builder = new LaptopBuilder();

            Pc pc_a = coolmatica.BuildNoLightPc();

            coolmatica.Builder = new DesktopBuilder();

            pc_a = coolmatica.BuildNoLightPc();

            // State

            Car pijo = new Car();

            pijo.PressPedal();
            pijo.TurnKey();
            pijo.PressPedal();
            pijo.TurnKey();
            pijo.PressPedal();

        }
    }
}
