using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum EventModifiers
    {
        None,
        Shift,
        Control,
        Alt,
        Command,
        Numeric,
        CapsLock,
        FunctionKey,
    }
}
