using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Tree
    {
        public bool HasLeaves { get; set; }

        private static Tree _instance;

        public static Tree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tree();
                }
                
                return _instance;
            }
        }

        private Tree() { HasLeaves = true; }

        public void CutLeaves()
        {
            HasLeaves = false;
        }
    }
}
