using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MonoBtlsX509TrustKind
    {
        DEFAULT,
        TRUST_CLIENT,
        TRUST_SERVER,
        TRUST_ALL,
        REJECT_CLIENT,
        REJECT_SERVER,
        REJECT_ALL,
    }
}
