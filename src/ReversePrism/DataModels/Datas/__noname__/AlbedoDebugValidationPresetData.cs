using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Color                                    ModelEnumType Color Color Color Int32
    // 028 MinLuminance                             ModelPrimitiveType float float float Single
    // 02C MaxLuminance                             ModelPrimitiveType float float float Single
    public partial class AlbedoDebugValidationPresetData : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Color                                    Color                                   { get; set; }
        public float                                    MinLuminance                            { get; set; }
        public float                                    MaxLuminance                            { get; set; }

        public static AlbedoDebugValidationPresetData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AlbedoDebugValidationPresetData() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x018)); // 0x18 Color                       ( ModelEnumType Color Color Color Int32 )
            value.MinLuminance                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 MinLuminance                ( ModelPrimitiveType float float float Single )
            value.MaxLuminance                              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MaxLuminance                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
