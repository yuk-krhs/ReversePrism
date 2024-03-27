using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TraceEventType
    {
        Critical,
        Error,
        Warning,
        Information,
        Verbose,
        Start,
        Stop,
        Suspend,
        Resume,
        Transfer,
    }
}
