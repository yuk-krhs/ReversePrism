using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_lateBoundOidToFriendlyName             ConcurrentDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 008 s_lateBoundFriendlyNameToOid             ConcurrentDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 010 s_friendlyNameToOid                      Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 018 s_oidToFriendlyName                      Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 020 s_compatOids                             Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class OidLookup
    {

        public static OidLookup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OidLookup();


            return value;
        }
    }
}
