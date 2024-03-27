using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SslProtocols
    {
        None,
        Ssl2,
        Ssl3,
        Tls,
        Tls11,
        Tls12,
        Tls13,
        Default,
    }
}
