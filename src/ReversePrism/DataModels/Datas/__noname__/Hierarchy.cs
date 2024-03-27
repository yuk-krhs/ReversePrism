using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_InvalidHierarchyChangeMsg              string IL2CPP_TYPE_STRING
    // 010 M_Owner                                  0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class Hierarchy
    {
        public VisualElement?                           M_Owner                                 { get; set; }

        public static Hierarchy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hierarchy();

            value.M_Owner                                   = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 027003F09BA0 0x10 M_Owner                     ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
