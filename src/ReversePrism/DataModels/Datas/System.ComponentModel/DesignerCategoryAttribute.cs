using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Component                                DesignerCategoryAttribute IL2CPP_TYPE_CLASS
    // 008 Default                                  DesignerCategoryAttribute IL2CPP_TYPE_CLASS
    // 010 Form                                     0001866C7900 ModelClassType DesignerCategoryAttribute DesignerCategoryAttribute DesignerCategoryAttribute Pointer
    // 018 Generic                                  0001866C7900 ModelClassType DesignerCategoryAttribute DesignerCategoryAttribute DesignerCategoryAttribute Pointer
    // 010 Category                                 000186672F10 ModelPrimitiveType string string string String
    public partial class DesignerCategoryAttribute
    {
        public DesignerCategoryAttribute?               Form                                    { get; set; }
        public DesignerCategoryAttribute?               Generic                                 { get; set; }
        public string                                   Category                                { get; set; }

        public static DesignerCategoryAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DesignerCategoryAttribute();

            value.Form                                      = GetObject<DesignerCategoryAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignerCategoryAttribute.FromPointer); // 0270D7B13D38 0x10 Form                        ( 0001866C7900 ModelClassType DesignerCategoryAttribute DesignerCategoryAttribute DesignerCategoryAttribute Pointer )
            value.Generic                                   = GetObject<DesignerCategoryAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.DesignerCategoryAttribute.FromPointer); // 0270D7B13D58 0x18 Generic                     ( 0001866C7900 ModelClassType DesignerCategoryAttribute DesignerCategoryAttribute DesignerCategoryAttribute Pointer )
            value.Category                                  = GetString(new IntPtr(p + 0x010)); // 0270D7B13D78 0x10 Category                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
