using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Element                                ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class VisualElementStyleSheetSet : DataModel
    {
        public VisualElement?                           M_Element                               { get; set; }

        public static VisualElementStyleSheetSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementStyleSheetSet() { Pointer= p0 };

            value.M_Element                                 = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 M_Element                   ( ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
