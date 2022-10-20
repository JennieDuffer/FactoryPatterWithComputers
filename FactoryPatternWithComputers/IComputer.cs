using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternWithComputers
{
    public interface IComputer
    {
        public bool hasStorageDrive { get; set; }

        public int StorageAmount { get; set; }

        public int ScreenCount { get; set; }

        public void Compute();
    }
}
