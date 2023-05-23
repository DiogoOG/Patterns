using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Car
    {
        private ICarState _carState = new TurnedOff();

        public void TurnKey() => _carState = _carState.Next();

        public void PressPedal()
        {
            _carState.Pedal();
        }
    }

    public interface ICarState
    {
        void Pedal();
        ICarState Next();
    }

    public class TurnedOff : ICarState
    {
        public void Pedal()
        {
            Console.WriteLine("Nothing happens...");
        }

        public ICarState Next() => new TurnedMildlyOn();
    }

    public class TurnedMildlyOn : ICarState
    {
        public void Pedal()
        {
            Console.WriteLine("The car mildly vrooms");
        }

        public ICarState Next() => new TurnedOn();
    }

    public class TurnedOn : ICarState
    {
        public void Pedal()
        {
            Console.WriteLine("The car vrooms");
        }

        public ICarState Next() => new TurnedOff();
    }
}
