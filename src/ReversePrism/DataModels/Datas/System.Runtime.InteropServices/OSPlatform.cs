using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OsPlatform                               000186672F10 ModelPrimitiveType string string string String
    // 000 <Linux>k__BackingField                   OSPlatform IL2CPP_TYPE_VALUETYPE
    // 008 <OSX>k__BackingField                     OSPlatform IL2CPP_TYPE_VALUETYPE
    // 010 Windows                                  0001866C4B20 ModelEnumType OSPlatform OSPlatform OSPlatform Int32
    public partial class OSPlatform
    {
        public string                                   OsPlatform                              { get; set; }
        public OSPlatform                               Windows                                 { get; set; }

        public static OSPlatform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OSPlatform();

            value.OsPlatform                                = GetString(new IntPtr(p + 0x010)); // 0270040848D8 0x10 OsPlatform                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.Windows                                   = (OSPlatform)GetInt32(new IntPtr(p + 0x010)); // 027004084938 0x10 Windows                     ( 0001866C4B20 ModelEnumType OSPlatform OSPlatform OSPlatform Int32 )

            return value;
        }
    }
}
