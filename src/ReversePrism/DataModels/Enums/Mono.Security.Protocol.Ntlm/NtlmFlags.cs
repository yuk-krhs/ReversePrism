using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NtlmFlags
    {
        NegotiateUnicode,
        NegotiateOem,
        RequestTarget,
        NegotiateNtlm,
        NegotiateDomainSupplied,
        NegotiateWorkstationSupplied,
        NegotiateAlwaysSign,
        NegotiateNtlm2Key,
        Negotiate128,
        Negotiate56,
    }
}
