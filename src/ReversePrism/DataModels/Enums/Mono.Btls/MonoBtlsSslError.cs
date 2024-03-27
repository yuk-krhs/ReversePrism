using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MonoBtlsSslError
    {
        None,
        Ssl,
        WantRead,
        WantWrite,
        WantX509Lookup,
        Syscall,
        ZeroReturn,
        WantConnect,
        WantAccept,
        WantChannelIdLookup,
        PendingSession,
        PendingCertificate,
        WantPrivateKeyOperation,
    }
}
