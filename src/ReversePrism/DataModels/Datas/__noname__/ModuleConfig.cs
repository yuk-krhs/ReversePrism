using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumInstallers                            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 ProxyHost                                000186674C50 ModelPrimitiveType string string string String
    // 020 ProxyPort                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 028 UserAgent                                000186674C50 ModelPrimitiveType string string string String
    // 030 InactiveTimeoutSec                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 034 AllowInsecureSSL                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 035 CrcEnabled                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 036 PlatformConfig                           00018655C3A0 ModelEnumType ModulePlatformConfig ModulePlatformConfig ModulePlatformConfig Int32
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

            value.NumInstallers                             = GetUInt32(new IntPtr(p + 0x010)); // 02466AD25538 0x10 NumInstallers               ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ProxyHost                                 = GetString(new IntPtr(p + 0x018)); // 02466AD25558 0x18 ProxyHost                   ( 000186674C50 ModelPrimitiveType string string string String )
            value.ProxyPort                                 = GetUInt16(new IntPtr(p + 0x020)); // 02466AD25578 0x20 ProxyPort                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.UserAgent                                 = GetString(new IntPtr(p + 0x028)); // 02466AD25598 0x28 UserAgent                   ( 000186674C50 ModelPrimitiveType string string string String )
            value.InactiveTimeoutSec                        = GetUInt32(new IntPtr(p + 0x030)); // 02466AD255B8 0x30 InactiveTimeoutSec          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.AllowInsecureSSL                          = GetBool(new IntPtr(p + 0x034)); // 02466AD255D8 0x34 AllowInsecureSSL            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CrcEnabled                                = GetBool(new IntPtr(p + 0x035)); // 02466AD255F8 0x35 CrcEnabled                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PlatformConfig                            = (ModulePlatformConfig)GetInt32(new IntPtr(p + 0x036)); // 02466AD25618 0x36 PlatformConfig              ( 00018655C3A0 ModelEnumType ModulePlatformConfig ModulePlatformConfig ModulePlatformConfig Int32 )

            return value;
        }
    }
}
