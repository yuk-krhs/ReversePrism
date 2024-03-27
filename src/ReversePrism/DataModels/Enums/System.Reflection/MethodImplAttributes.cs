using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MethodImplAttributes
    {
        CodeTypeMask,
        IL,
        Native,
        OPTIL,
        Runtime,
        ManagedMask,
        Unmanaged,
        Managed,
        ForwardRef,
        PreserveSig,
        InternalCall,
        Synchronized,
        NoInlining,
        AggressiveInlining,
        NoOptimization,
        MaxMethodImplVal,
        SecurityMitigations,
    }
}
