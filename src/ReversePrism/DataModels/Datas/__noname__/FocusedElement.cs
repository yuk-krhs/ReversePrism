using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SubTreeRoot                            0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 M_FocusedElement                         0001865D4190 ModelClassType Focusable Focusable Focusable Pointer
    public partial class FocusedElement : DataModel
    {
        public VisualElement?                           M_SubTreeRoot                           { get; set; }
        public Focusable?                               M_FocusedElement                        { get; set; }

        public static FocusedElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusedElement() { Pointer= p0 };

            value.M_SubTreeRoot                             = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A679C3E8 0x10 M_SubTreeRoot               ( 0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_FocusedElement                          = GetObject<Focusable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Focusable.FromPointer); // 0245A679C408 0x18 M_FocusedElement            ( 0001865D4190 ModelClassType Focusable Focusable Focusable Pointer )

            return value;
        }
    }
}
