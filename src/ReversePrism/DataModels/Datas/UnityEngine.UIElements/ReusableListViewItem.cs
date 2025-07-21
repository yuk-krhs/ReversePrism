using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_Container                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 050 M_DragHandle                             ModelClassType VisualElement VisualElement VisualElement Pointer
    // 058 M_ItemContainer                          ModelClassType VisualElement VisualElement VisualElement Pointer
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

            value.M_Container                               = GetObject<VisualElement>(new IntPtr(p + 0x048), ReversePrism.DataModels.VisualElement.FromPointer); // 0x48 M_Container                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragHandle                              = GetObject<VisualElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualElement.FromPointer); // 0x50 M_DragHandle                ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_ItemContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x058), ReversePrism.DataModels.VisualElement.FromPointer); // 0x58 M_ItemContainer             ( ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
