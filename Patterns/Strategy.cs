using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IBattleStrategy
    {
        public abstract void Execute();
    }

    public class BonkStrategy : IBattleStrategy
    {
        public void Execute()
        {
            Console.WriteLine("I bonk the monster.");
        }
    }

    public class ShootStrategy : IBattleStrategy
    {
        public void Execute()
        {
            Console.WriteLine("I shoot the monster.");
        }
    }

    public class StabbyStrategy : IBattleStrategy
    {
        public void Execute()
        {
            Console.WriteLine("I stab the monster.");
        }
    }

    public class Player
    {
        public IBattleStrategy Strategy { get; set; }

        public Player () { Strategy = new BonkStrategy(); }

        public void Attack()
        {
            Strategy.Execute();
        }
    }
}
