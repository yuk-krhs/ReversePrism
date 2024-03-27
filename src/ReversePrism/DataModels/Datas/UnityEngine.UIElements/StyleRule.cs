using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Properties                             000185CA7728 ModelClassListType StyleProperty[] StyleProperty[] List<StyleProperty> Pointer
    // 018 Line                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C CustomPropertiesCount                    0001865F5530 ModelPrimitiveType int int int Int32
    public partial class StyleRule
    {
        public List<StyleProperty>?                     M_Properties                            { get; set; }
        public int                                      Line                                    { get; set; }
        public int                                      CustomPropertiesCount                   { get; set; }

        public static StyleRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleRule();

            value.M_Properties                              = GetObjectList<StyleProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleProperty.FromPointer); // 027006841ED0 0x10 M_Properties                ( 000185CA7728 ModelClassListType StyleProperty[] StyleProperty[] List<StyleProperty> Pointer )
            value.Line                                      = GetInt32(new IntPtr(p + 0x018)); // 027006841EF0 0x18 Line                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CustomPropertiesCount                     = GetInt32(new IntPtr(p + 0x01C)); // 027006841F10 0x1C CustomPropertiesCount       ( 0001865F5530 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
