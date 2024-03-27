using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AssemblyHashAlgorithm
    {
        None,
        MD5,
        SHA1,
        SHA256,
        SHA384,
        SHA512,
    }
}
