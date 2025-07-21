using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defAttr                                  CategoryAttribute IL2CPP_TYPE_CLASS
    // 010 Localized                                ModelPrimitiveType bool bool bool Bool
    // 018 CategoryValue                            ModelPrimitiveType string string string String
    public partial class CategoryAttribute : DataModel
    {
        public bool                                     Localized                               { get; set; }
        public string                                   CategoryValue                           { get; set; }

        public static CategoryAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CategoryAttribute() { Pointer= p0 };

            value.Localized                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 Localized                   ( ModelPrimitiveType bool bool bool Bool )
            value.CategoryValue                             = GetString(new IntPtr(p + 0x018)); // 0x18 CategoryValue               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
