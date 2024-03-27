using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RfcChar
    {
        High,
        Reg,
        Ctl,
        CR,
        LF,
        WS,
        Colon,
        Delim,
    }
}
