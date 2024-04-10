using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 SettingsSectionInternal IL2CPP_TYPE_CLASS
    // 010 HttpListenerUnescapeRequestUrl           000186596860 ModelPrimitiveType bool bool bool Bool
    // 014 IPProtectionLevel                        0001865D0960 ModelEnumType IPProtectionLevel IPProtectionLevel IPProtectionLevel Int32
    public partial class SettingsSectionInternal : DataModel
    {
        public bool                                     HttpListenerUnescapeRequestUrl          { get; set; }
        public IPProtectionLevel                        IPProtectionLevel                       { get; set; }

        public static SettingsSectionInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SettingsSectionInternal() { Pointer= p0 };

            value.HttpListenerUnescapeRequestUrl            = GetBool(new IntPtr(p + 0x010)); // 024667B4BDC8 0x10 HttpListenerUnescapeRequestUrl ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IPProtectionLevel                         = (IPProtectionLevel)GetInt32(new IntPtr(p + 0x014)); // 024667B4BDE8 0x14 IPProtectionLevel           ( 0001865D0960 ModelEnumType IPProtectionLevel IPProtectionLevel IPProtectionLevel Int32 )

            return value;
        }
    }
}
