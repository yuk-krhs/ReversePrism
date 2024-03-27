using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PInvokeAttributes
    {
        NoMangle,
        CharSetMask,
        CharSetNotSpec,
        CharSetAnsi,
        CharSetUnicode,
        CharSetAuto,
        BestFitUseAssem,
        BestFitEnabled,
        BestFitDisabled,
        BestFitMask,
        ThrowOnUnmappableCharUseAssem,
        ThrowOnUnmappableCharEnabled,
        ThrowOnUnmappableCharDisabled,
        ThrowOnUnmappableCharMask,
        SupportsLastError,
        CallConvMask,
        CallConvWinapi,
        CallConvCdecl,
        CallConvStdcall,
        CallConvThiscall,
        CallConvFastcall,
        MaxValue,
    }
}
