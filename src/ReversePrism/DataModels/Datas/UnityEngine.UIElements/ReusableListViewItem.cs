using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_Container                              0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 048 M_DragHandle                             0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 050 M_ItemContainer                          0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class ReusableListViewItem : DataModel
    {
        public VisualElement?                           M_Container                             { get; set; }
        public VisualElement?                           M_DragHandle                            { get; set; }
        public VisualElement?                           M_ItemContainer                         { get; set; }

        public static ReusableListViewItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableListViewItem() { Pointer= p0 };

            value.M_Container                               = GetObject<VisualElement>(new IntPtr(p + 0x040), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B0018 0x40 M_Container                 ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragHandle                              = GetObject<VisualElement>(new IntPtr(p + 0x048), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B0038 0x48 M_DragHandle                ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_ItemContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B0058 0x50 M_ItemContainer             ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
