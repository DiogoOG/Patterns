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
            CarFactory a = new RedCarFactory();
            CarFactory b = new BlueCarFactory();

            ICar x = a.Fabricate();
            ICar y = b.Fabricate();

            x.Vroom();
            y.Vroom();
        }
    }
}
