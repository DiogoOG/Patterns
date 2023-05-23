using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Patterns
{
    public class Pc
    {
        public string PowerSupply { get; set; }
        public string Motherboard { get; set; }
        public string CentralProcessingUnit { get; set; }
        public string RandomAccessMemory { get; set; }
        public string SkittleGangLights { get; set; }
    }

    public interface IPcBuilder
    {
        void Reset();
        void AddPowerSupply();
        void AddMotherboard();
        void AddCentralProcessingUnit();
        void AddRandomAccessMemory();
        void AddSkittleGangLights();
        Pc Result { get;}
    }

    public class LaptopBuilder : IPcBuilder
    {
        private Pc _result = new Pc();

        public Pc Result { get { return _result; } }

        public LaptopBuilder() { Reset(); }

        public void AddCentralProcessingUnit()
        {
            _result.CentralProcessingUnit = "Clerenona 209G";
        }

        public void AddMotherboard()
        {
            _result.Motherboard = "GIgabyte M9292";
        }

        public void AddPowerSupply()
        {
            _result.PowerSupply = "No";
        }

        public void AddRandomAccessMemory()
        {
            _result.RandomAccessMemory = "Maybe";
        }

        public void AddSkittleGangLights()
        {
            _result.SkittleGangLights = "Happy Pride";
        }

        public void Reset()
        {
            _result = new Pc();
        }
    }

    public class DesktopBuilder : IPcBuilder
    {
        private Pc _result;

        public Pc Result { get { return _result; } }

        public DesktopBuilder() { _result = new Pc(); }

        public void AddCentralProcessingUnit()
        {
            _result.CentralProcessingUnit = "Clerenona 209G";
        }

        public void AddMotherboard()
        {
            _result.Motherboard = "Very big M9292";
        }

        public void AddPowerSupply()
        {
            _result.PowerSupply = "No";
        }

        public void AddRandomAccessMemory()
        {
            _result.RandomAccessMemory = "Sometimes";
        }

        public void AddSkittleGangLights()
        {
            _result.SkittleGangLights = "Fuck no";
        }

        public void Reset()
        {
            _result = new Pc();
        }
    }

    public class Coolmatica
    {
        public IPcBuilder Builder { get; set; }

        public Coolmatica()
        {
            Builder = new LaptopBuilder();
        }

        public Pc BuildNoLightPc()
        {
            Builder.AddCentralProcessingUnit();
            Builder.AddMotherboard();
            return Builder.Result;
        }

        public Pc BuildWithLightPc()
        {
            Builder.AddCentralProcessingUnit();
            Builder.AddMotherboard();
            Builder.AddSkittleGangLights();
            return Builder.Result;
        }
    }
}
