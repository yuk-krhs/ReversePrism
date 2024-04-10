using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 isEnabled                                Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 granularOptions                          Dictionary`2<string, List`1<string>> IL2CPP_TYPE_GENERICINST
    // 020 partnerSharingSettings                   Dictionary`2<string, List`1<string>> IL2CPP_TYPE_GENERICINST
    public partial class AdjustThirdPartySharing : DataModel
    {

        public static AdjustThirdPartySharing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustThirdPartySharing() { Pointer= p0 };


            return value;
        }
    }
}
