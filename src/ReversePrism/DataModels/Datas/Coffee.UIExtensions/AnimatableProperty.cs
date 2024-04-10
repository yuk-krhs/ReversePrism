using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_Type                                   0001866A2200 ModelEnumType ShaderPropertyType ShaderPropertyType ShaderPropertyType Int32
    // 01C Id                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AnimatableProperty : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public ShaderPropertyType                       M_Type                                  { get; set; }
        public int                                      Id                                      { get; set; }

        public static AnimatableProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatableProperty() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0245A4FA2C70 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Type                                    = (ShaderPropertyType)GetInt32(new IntPtr(p + 0x018)); // 0245A4FA2C90 0x18 M_Type                      ( 0001866A2200 ModelEnumType ShaderPropertyType ShaderPropertyType ShaderPropertyType Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x01C)); // 0245A4FA2CB0 0x1C Id                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
