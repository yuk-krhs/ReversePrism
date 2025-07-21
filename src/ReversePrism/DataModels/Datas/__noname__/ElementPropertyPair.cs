using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Comparer                                 IEqualityComparer`1<ElementPropertyPair> IL2CPP_TYPE_GENERICINST
    // 010 Element                                  ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 Property                                 ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32
    public partial class ElementPropertyPair : DataModel
    {
        public VisualElement?                           Element                                 { get; set; }
        public StylePropertyId                          Property                                { get; set; }

        public static ElementPropertyPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementPropertyPair() { Pointer= p0 };

            value.Element                                   = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 Element                     ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Property                                  = (StylePropertyId)GetInt32(new IntPtr(p + 0x018)); // 0x18 Property                    ( ModelEnumType StylePropertyId StylePropertyId StylePropertyId Int32 )

            return value;
        }
    }
}
