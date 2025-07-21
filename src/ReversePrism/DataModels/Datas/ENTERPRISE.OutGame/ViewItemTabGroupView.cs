using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentTabGroupObj                       ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 ContentTabButtonObj                      ModelClassType UITabButton UITabButton UITabButton Pointer
    // 030 ScrollRectButton                         ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 038 Tabs                                     ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer
    // 040 clickSubject                             Subject`1<ValueTuple`2<int, UITabGroup>> IL2CPP_TYPE_GENERICINST
    public partial class ViewItemTabGroupView : DataModel
    {
        public UITabGroup?                              ContentTabGroupObj                      { get; set; }
        public UITabButton?                             ContentTabButtonObj                     { get; set; }
        public ScrollRect?                              ScrollRectButton                        { get; set; }
        public List<UITabButton>?                       Tabs                                    { get; set; }

        public static ViewItemTabGroupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewItemTabGroupView() { Pointer= p0 };

            value.ContentTabGroupObj                        = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 ContentTabGroupObj          ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.ContentTabButtonObj                       = GetObject<UITabButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabButton.FromPointer); // 0x28 ContentTabButtonObj         ( ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.ScrollRectButton                          = GetObject<ScrollRect>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x30 ScrollRectButton            ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.Tabs                                      = GetObjectList<UITabButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabButton.FromPointer); // 0x38 Tabs                        ( ModelClassListType List`1<UITabButton> List`1<UITabButton> List<UITabButton> Pointer )

            return value;
        }
    }
}
