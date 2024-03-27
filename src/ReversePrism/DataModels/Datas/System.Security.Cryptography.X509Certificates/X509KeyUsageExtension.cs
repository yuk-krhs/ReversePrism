using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 oid                                      string IL2CPP_TYPE_STRING
    // 000 friendlyName                             string IL2CPP_TYPE_STRING
    // 000 all                                      X509KeyUsageFlags IL2CPP_TYPE_VALUETYPE
    // 028 KeyUsages                                00018656CDF0 ModelEnumType X509KeyUsageFlags X509KeyUsageFlags X509KeyUsageFlags Int32
    // 02C Status                                   0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32
    public partial class X509KeyUsageExtension
    {
        public X509KeyUsageFlags                        KeyUsages                               { get; set; }
        public AsnDecodeStatus                          Status                                  { get; set; }

        public static X509KeyUsageExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509KeyUsageExtension();

            value.KeyUsages                                 = (X509KeyUsageFlags)GetInt32(new IntPtr(p + 0x028)); // 0270D79EE1E0 0x28 KeyUsages                   ( 00018656CDF0 ModelEnumType X509KeyUsageFlags X509KeyUsageFlags X509KeyUsageFlags Int32 )
            value.Status                                    = (AsnDecodeStatus)GetInt32(new IntPtr(p + 0x02C)); // 0270D79EE200 0x2C Status                      ( 0001866DC700 ModelEnumType AsnDecodeStatus AsnDecodeStatus AsnDecodeStatus Int32 )

            return value;
        }
    }
}
