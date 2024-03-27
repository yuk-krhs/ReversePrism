using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum BurstTargetCpu
    {
        Auto,
        X86_SSE2,
        X86_SSE4,
        X64_SSE2,
        X64_SSE4,
        AVX,
        AVX2,
        WASM32,
        ARMV7A_NEON32,
        ARMV8A_AARCH64,
        THUMB2_NEON32,
        ARMV8A_AARCH64_HALFFP,
        ARMV9A,
    }
}
