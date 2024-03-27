using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastKnownOldProductId                    000186671910 ModelPrimitiveType string string string String
    // 018 LastKnownProductId                       000186671910 ModelPrimitiveType string string string String
    // 020 <LastKnownProrationMode>k__BackingField  Nullable`1<GooglePlayProrationMode> IL2CPP_TYPE_GENERICINST
    public partial class GoogleLastKnownProductService
    {
        public string                                   LastKnownOldProductId                   { get; set; }
        public string                                   LastKnownProductId                      { get; set; }

        public static GoogleLastKnownProductService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleLastKnownProductService();

            value.LastKnownOldProductId                     = GetString(new IntPtr(p + 0x010)); // 027006900F70 0x10 LastKnownOldProductId       ( 000186671910 ModelPrimitiveType string string string String )
            value.LastKnownProductId                        = GetString(new IntPtr(p + 0x018)); // 027006900F90 0x18 LastKnownProductId          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
