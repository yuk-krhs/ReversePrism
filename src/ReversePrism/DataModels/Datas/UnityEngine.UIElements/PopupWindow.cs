using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 4A0 M_ContentContainer                       0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 contentUssClassName                      string IL2CPP_TYPE_STRING
    public partial class PopupWindow
    {
        public VisualElement?                           M_ContentContainer                      { get; set; }

        public static PopupWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupWindow();

            value.M_ContentContainer                        = GetObject<VisualElement>(new IntPtr(p + 0x4A0), ReversePrism.DataModels.VisualElement.FromPointer); // 02700672E448 0x4A0 M_ContentContainer          ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
