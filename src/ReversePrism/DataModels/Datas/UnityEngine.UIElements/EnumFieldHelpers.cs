using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 type                                     UxmlTypeAttributeDescription`1<Enum> IL2CPP_TYPE_GENERICINST
    // 008 value                                    UxmlStringAttributeDescription IL2CPP_TYPE_CLASS
    // 010 IncludeObsoleteValues                    00018675BBC0 ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer
    public partial class EnumFieldHelpers : DataModel
    {
        public UxmlBoolAttributeDescription?            IncludeObsoleteValues                   { get; set; }

        public static EnumFieldHelpers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumFieldHelpers() { Pointer= p0 };

            value.IncludeObsoleteValues                     = GetObject<UxmlBoolAttributeDescription>(new IntPtr(p + 0x010), ReversePrism.DataModels.UxmlBoolAttributeDescription.FromPointer); // 0245A66CE540 0x10 IncludeObsoleteValues       ( 00018675BBC0 ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer )

            return value;
        }
    }
}
