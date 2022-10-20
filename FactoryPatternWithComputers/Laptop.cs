using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternWithComputers
{
    internal class Laptop : IComputer
    {
        public int StorageAmount { get; set; } = 128;

        public bool isPortable { get; set; } = true;
        public bool hasStorageDrive { get; set; }
        public int ScreenCount { get; set; }

        public void Compute()
        {
            Console.WriteLine($"The laptop has {StorageAmount}GB of storage.");
        }
    }
}
