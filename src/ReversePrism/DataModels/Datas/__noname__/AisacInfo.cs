using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186675150 ModelPrimitiveType string string string String
    // 018 DefaultControlFlag                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C DefaultControlValue                      000186666050 ModelPrimitiveType float float float Single
    // 020 ControlId                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 ControlName                              000186675150 ModelPrimitiveType string string string String
    public partial class AisacInfo
    {
        public string                                   Name                                    { get; set; }
        public bool                                     DefaultControlFlag                      { get; set; }
        public float                                    DefaultControlValue                     { get; set; }
        public uint                                     ControlId                               { get; set; }
        public string                                   ControlName                             { get; set; }

        public static AisacInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AisacInfo();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270DAC6C890 0x10 Name                        ( 000186675150 ModelPrimitiveType string string string String )
            value.DefaultControlFlag                        = GetBool(new IntPtr(p + 0x018)); // 0270DAC6C8B0 0x18 DefaultControlFlag          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DefaultControlValue                       = GetSingle(new IntPtr(p + 0x01C)); // 0270DAC6C8D0 0x1C DefaultControlValue         ( 000186666050 ModelPrimitiveType float float float Single )
            value.ControlId                                 = GetUInt32(new IntPtr(p + 0x020)); // 0270DAC6C8F0 0x20 ControlId                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ControlName                               = GetString(new IntPtr(p + 0x028)); // 0270DAC6C910 0x28 ControlName                 ( 000186675150 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
