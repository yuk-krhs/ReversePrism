using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Type                                   ModelEnumType ShaderPropertyType ShaderPropertyType ShaderPropertyType Int32
    // 01C Id                                       ModelPrimitiveType int int int Int32
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

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Type                                    = (ShaderPropertyType)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Type                      ( ModelEnumType ShaderPropertyType ShaderPropertyType ShaderPropertyType Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Id                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
