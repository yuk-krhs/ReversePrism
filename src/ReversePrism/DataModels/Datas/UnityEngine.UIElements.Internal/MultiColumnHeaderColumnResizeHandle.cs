using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 dragAreaUssClassName                     string IL2CPP_TYPE_STRING
    // 3C8 DragArea                                 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class MultiColumnHeaderColumnResizeHandle : DataModel
    {
        public VisualElement?                           DragArea                                { get; set; }

        public static MultiColumnHeaderColumnResizeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnHeaderColumnResizeHandle() { Pointer= p0 };

            value.DragArea                                  = GetObject<VisualElement>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A68641F0 0x3C8 DragArea                    ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
