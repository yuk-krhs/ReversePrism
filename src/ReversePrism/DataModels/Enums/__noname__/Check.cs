using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Check
    {
        None,
        EscapedCanonical,
        DisplayCanonical,
        DotSlashAttn,
        DotSlashEscaped,
        BackslashInPath,
        ReservedFound,
        NotIriCanonical,
        FoundNonAscii,
    }
}
