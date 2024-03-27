using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 EnhKeyUsage                              0001866D8AE0 ModelClassType OidCollection OidCollection OidCollection Pointer
    // 030 Status                                   0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32
    public partial class X509EnhancedKeyUsageExtension
    {
        public OidCollection?                           EnhKeyUsage                             { get; set; }
        public AsnDecodeStatus                          Status                                  { get; set; }

        public static X509EnhancedKeyUsageExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509EnhancedKeyUsageExtension();

            value.EnhKeyUsage                               = GetObject<OidCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.OidCollection.FromPointer); // 0270D79EDA00 0x28 EnhKeyUsage                 ( 0001866D8AE0 ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Status                                    = (AsnDecodeStatus)GetInt32(new IntPtr(p + 0x030)); // 0270D79EDA20 0x30 Status                      ( 0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32 )

            return value;
        }
    }
}
