using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  0001866B0F60 ModelClassType Version Version Version Pointer
    // 018 Platform                                 0001867485E0 ModelEnumType PlatformID PlatformID PlatformID Int32
    // 020 ServicePack                              000186672F10 ModelPrimitiveType string string string String
    // 028 VersionString                            000186671910 ModelPrimitiveType string string string String
    public partial class OperatingSystem : DataModel
    {
        public Version?                                 Version                                 { get; set; }
        public PlatformID                               Platform                                { get; set; }
        public string                                   ServicePack                             { get; set; }
        public string                                   VersionString                           { get; set; }

        public static OperatingSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OperatingSystem() { Pointer= p0 };

            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x010), ReversePrism.DataModels.Version.FromPointer); // 0245A40C6B88 0x10 Version                     ( 0001866B0F60 ModelClassType Version Version Version Pointer )
            value.Platform                                  = (PlatformID)GetInt32(new IntPtr(p + 0x018)); // 0245A40C6BA8 0x18 Platform                    ( 0001867485E0 ModelEnumType PlatformID PlatformID PlatformID Int32 )
            value.ServicePack                               = GetString(new IntPtr(p + 0x020)); // 0245A40C6BC8 0x20 ServicePack                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.VersionString                             = GetString(new IntPtr(p + 0x028)); // 0245A40C6BE8 0x28 VersionString               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
