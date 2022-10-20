using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternWithComputers
{
    internal class Desktop : IComputer
    {
        public int StorageAmount { get; set; } = 256;

        public bool isPortable { get; set; } = false;
        public bool hasStorageDrive { get; set; }
        public int ScreenCount { get; set; }

        public void Compute()
        {
            Console.WriteLine($"The desktop has {StorageAmount}GB of storage.");
        }
    }
}
