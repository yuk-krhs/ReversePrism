using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Target
    {
        Vertex,
        Index,
        CopySource,
        CopyDestination,
        Structured,
        Raw,
        Append,
        Counter,
        IndirectArguments,
        Constant,
    }
}
