using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MonoBtlsX509StoreType
    {
        Custom,
        MachineTrustedRoots,
        MachineIntermediateCA,
        MachineUntrusted,
        UserTrustedRoots,
        UserIntermediateCA,
        UserUntrusted,
    }
}
