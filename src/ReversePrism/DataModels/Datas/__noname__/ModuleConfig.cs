using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumInstallers                            ModelPrimitiveType uint uint uint UInt32
    // 018 ProxyHost                                ModelPrimitiveType string string string String
    // 020 ProxyPort                                ModelPrimitiveType ushort ushort ushort UInt16
    // 028 UserAgent                                ModelPrimitiveType string string string String
    // 030 InactiveTimeoutSec                       ModelPrimitiveType uint uint uint UInt32
    // 034 AllowInsecureSSL                         ModelPrimitiveType bool bool bool Bool
    // 035 CrcEnabled                               ModelPrimitiveType bool bool bool Bool
    // 036 PlatformConfig                           ModelEnumType ModulePlatformConfig ModulePlatformConfig ModulePlatformConfig Int32
    public partial class ModuleConfig : DataModel
    {
        public uint                                     NumInstallers                           { get; set; }
        public string                                   ProxyHost                               { get; set; }
        public ushort                                   ProxyPort                               { get; set; }
        public string                                   UserAgent                               { get; set; }
        public uint                                     InactiveTimeoutSec                      { get; set; }
        public bool                                     AllowInsecureSSL                        { get; set; }
        public bool                                     CrcEnabled                              { get; set; }
        public ModulePlatformConfig                     PlatformConfig                          { get; set; }

        public static ModuleConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModuleConfig() { Pointer= p0 };

            value.NumInstallers                             = GetUInt32(new IntPtr(p + 0x010)); // 0x10 NumInstallers               ( ModelPrimitiveType uint uint uint UInt32 )
            value.ProxyHost                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ProxyHost                   ( ModelPrimitiveType string string string String )
            value.ProxyPort                                 = GetUInt16(new IntPtr(p + 0x020)); // 0x20 ProxyPort                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UserAgent                                 = GetString(new IntPtr(p + 0x028)); // 0x28 UserAgent                   ( ModelPrimitiveType string string string String )
            value.InactiveTimeoutSec                        = GetUInt32(new IntPtr(p + 0x030)); // 0x30 InactiveTimeoutSec          ( ModelPrimitiveType uint uint uint UInt32 )
            value.AllowInsecureSSL                          = GetBool(new IntPtr(p + 0x034)); // 0x34 AllowInsecureSSL            ( ModelPrimitiveType bool bool bool Bool )
            value.CrcEnabled                                = GetBool(new IntPtr(p + 0x035)); // 0x35 CrcEnabled                  ( ModelPrimitiveType bool bool bool Bool )
            value.PlatformConfig                            = (ModulePlatformConfig)GetInt32(new IntPtr(p + 0x036)); // 0x36 PlatformConfig              ( ModelEnumType ModulePlatformConfig ModulePlatformConfig ModulePlatformConfig Int32 )

            return value;
        }
    }
}
