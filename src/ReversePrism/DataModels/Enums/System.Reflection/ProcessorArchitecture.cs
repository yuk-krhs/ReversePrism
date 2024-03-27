using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProcessorArchitecture
    {
        None,
        MSIL,
        X86,
        IA64,
        Amd64,
        Arm,
    }
}
