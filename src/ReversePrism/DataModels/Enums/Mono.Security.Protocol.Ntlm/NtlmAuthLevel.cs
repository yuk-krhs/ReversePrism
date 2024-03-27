using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NtlmAuthLevel
    {
        LM_and_NTLM,
        LM_and_NTLM_and_try_NTLMv2_Session,
        NTLM_only,
        NTLMv2_only,
    }
}
