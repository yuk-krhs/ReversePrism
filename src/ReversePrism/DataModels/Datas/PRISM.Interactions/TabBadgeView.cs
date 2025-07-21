using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 CgTabBadges                              ModelClassListType CanvasGroup[] CanvasGroup[] List<CanvasGroup> Pointer
    public partial class TabBadgeView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<CanvasGroup>?                       CgTabBadges                             { get; set; }

        public static TabBadgeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TabBadgeView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.CgTabBadges                               = GetObjectList<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgTabBadges                 ( ModelClassListType CanvasGroup[] CanvasGroup[] List<CanvasGroup> Pointer )

            return value;
        }
    }
}
