using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Comparer                                 IEqualityComparer`1<ElementPropertyPair> IL2CPP_TYPE_GENERICINST
    // 010 Element                                  0001866B39A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 Property                                 0001865C9FC0 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    public partial class ElementPropertyPair
    {
        public VisualElement?                           Element                                 { get; set; }
        public StylePropertyId                          Property                                { get; set; }

        public static ElementPropertyPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementPropertyPair();

            value.Element                                   = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067FC468 0x10 Element                     ( 0001866B39A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Property                                  = (StylePropertyId)GetInt32(new IntPtr(p + 0x018)); // 0270067FC488 0x18 Property                    ( 0001865C9FC0 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )

            return value;
        }
    }
}
