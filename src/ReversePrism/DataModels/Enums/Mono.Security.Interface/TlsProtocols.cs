using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TlsProtocols
    {
        Zero,
        Tls10Client,
        Tls10Server,
        Tls10,
        Tls11Client,
        Tls11Server,
        Tls11,
        Tls12Client,
        Tls12Server,
        Tls12,
        ClientMask,
        ServerMask,
    }
}
