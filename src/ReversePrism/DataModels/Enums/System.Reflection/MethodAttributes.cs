using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MethodAttributes
    {
        MemberAccessMask,
        PrivateScope,
        Private,
        FamANDAssem,
        Assembly,
        Family,
        FamORAssem,
        Public,
        Static,
        Final,
        Virtual,
        HideBySig,
        CheckAccessOnOverride,
        VtableLayoutMask,
        ReuseSlot,
        NewSlot,
        Abstract,
        SpecialName,
        PinvokeImpl,
        UnmanagedExport,
        RTSpecialName,
        HasSecurity,
        RequireSecObject,
        ReservedMask,
    }
}
