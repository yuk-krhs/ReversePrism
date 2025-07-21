using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelPrimitiveType string string string String
    // 018 M_Type                                   ModelEnumType StyleSelectorType StyleSelectorType StyleSelectorType Int32
    // 020 tempData                                 <object> IL2CPP_TYPE_OBJECT
    public partial class StyleSelectorPart : DataModel
    {
        public string                                   M_Value                                 { get; set; }
        public StyleSelectorType                        M_Type                                  { get; set; }

        public static StyleSelectorPart? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleSelectorPart() { Pointer= p0 };

            value.M_Value                                   = GetString(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelPrimitiveType string string string String )
            value.M_Type                                    = (StyleSelectorType)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Type                      ( ModelEnumType StyleSelectorType StyleSelectorType StyleSelectorType Int32 )

            return value;
        }
    }
}
