using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 EnhKeyUsage                              ModelClassType OidCollection OidCollection OidCollection Pointer
    // 030 Status                                   ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32
    public partial class X509EnhancedKeyUsageExtension : DataModel
    {
        public OidCollection?                           EnhKeyUsage                             { get; set; }
        public AsnDecodeStatus                          Status                                  { get; set; }

        public static X509EnhancedKeyUsageExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509EnhancedKeyUsageExtension() { Pointer= p0 };

            value.EnhKeyUsage                               = GetObject<OidCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.OidCollection.FromPointer); // 0x28 EnhKeyUsage                 ( ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Status                                    = (AsnDecodeStatus)GetInt32(new IntPtr(p + 0x030)); // 0x30 Status                      ( ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32 )

            return value;
        }
    }
}
