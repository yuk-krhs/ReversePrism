using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 028 EmptyViewText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class StoryEmptyView : DataModel
    {
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }

        public static StoryEmptyView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryEmptyView() { Pointer= p0 };

            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 EmptyViewText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
