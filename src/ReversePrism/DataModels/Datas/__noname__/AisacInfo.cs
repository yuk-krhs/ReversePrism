using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 DefaultControlFlag                       ModelPrimitiveType bool bool bool Bool
    // 01C DefaultControlValue                      ModelPrimitiveType float float float Single
    // 020 ControlId                                ModelPrimitiveType uint uint uint UInt32
    // 028 ControlName                              ModelPrimitiveType string string string String
    public partial class AisacInfo : DataModel
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
            var value   = new AisacInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.DefaultControlFlag                        = GetBool(new IntPtr(p + 0x018)); // 0x18 DefaultControlFlag          ( ModelPrimitiveType bool bool bool Bool )
            value.DefaultControlValue                       = GetSingle(new IntPtr(p + 0x01C)); // 0x1C DefaultControlValue         ( ModelPrimitiveType float float float Single )
            value.ControlId                                 = GetUInt32(new IntPtr(p + 0x020)); // 0x20 ControlId                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.ControlName                               = GetString(new IntPtr(p + 0x028)); // 0x28 ControlName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
