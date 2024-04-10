using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabButton                                0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 028 NewBadge                                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 UnreadBadge                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class StoryTopTabButton : DataModel
    {
        public UITabButton?                             TabButton                               { get; set; }
        public UIImage?                                 NewBadge                                { get; set; }
        public UIImage?                                 UnreadBadge                             { get; set; }

        public static StoryTopTabButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopTabButton() { Pointer= p0 };

            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabButton.FromPointer); // 02466BA1DE20 0x20 TabButton                   ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.NewBadge                                  = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466BA1DE40 0x28 NewBadge                    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UnreadBadge                               = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 02466BA1DE60 0x30 UnreadBadge                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
