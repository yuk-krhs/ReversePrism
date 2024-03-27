using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 EmptyViewText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class StoryEmptyView
    {
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }

        public static StoryEmptyView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryEmptyView();

            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9549E0 0x20 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB954A00 0x28 EmptyViewText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
