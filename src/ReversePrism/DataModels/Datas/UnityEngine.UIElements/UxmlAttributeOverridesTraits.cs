using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_ElementName                            00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    public partial class UxmlAttributeOverridesTraits
    {
        public UxmlStringAttributeDescription?          M_ElementName                           { get; set; }

        public static UxmlAttributeOverridesTraits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlAttributeOverridesTraits();

            value.M_ElementName                             = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x018), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 02700684DF38 0x18 M_ElementName               ( 00018675F2E0 ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )

            return value;
        }
    }
}
