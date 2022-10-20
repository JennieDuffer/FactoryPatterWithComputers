using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternWithComputers
{
    public static class ComputerFactory
    {
        public static IComputer GetComputer(string computerSelection)
        {
            switch (computerSelection)
            {
                case "laptop":
                    return new Laptop();
                case "desktop":
                    return new Desktop();
                default:
                    return new Desktop();   
            }
        }
    }
}
