using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 SettingsSectionInternal IL2CPP_TYPE_CLASS
    // 010 HttpListenerUnescapeRequestUrl           ModelPrimitiveType bool bool bool Bool
    // 014 IPProtectionLevel                        ModelEnumType IPProtectionLevel IPProtectionLevel IPProtectionLevel Int32
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

            value.HttpListenerUnescapeRequestUrl            = GetBool(new IntPtr(p + 0x010)); // 0x10 HttpListenerUnescapeRequestUrl ( ModelPrimitiveType bool bool bool Bool )
            value.IPProtectionLevel                         = (IPProtectionLevel)GetInt32(new IntPtr(p + 0x014)); // 0x14 IPProtectionLevel           ( ModelEnumType IPProtectionLevel IPProtectionLevel IPProtectionLevel Int32 )

            return value;
        }
    }
}
