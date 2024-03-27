using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Element                                0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class VisualElementStyleSheetSet
    {
        public VisualElement?                           M_Element                               { get; set; }

        public static VisualElementStyleSheetSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementStyleSheetSet();

            value.M_Element                                 = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 02700685C748 0x10 M_Element                   ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
