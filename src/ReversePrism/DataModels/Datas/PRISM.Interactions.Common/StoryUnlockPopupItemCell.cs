using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CategoryText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 TitleText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class StoryUnlockPopupItemCell
    {
        public TextMeshProUGUI?                         CategoryText                            { get; set; }
        public TextMeshProUGUI?                         TitleText                               { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }

        public static StoryUnlockPopupItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryUnlockPopupItemCell();

            value.CategoryText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DB5992C8 0x20 CategoryText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.TitleText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DB5992E8 0x28 TitleText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB599308 0x30 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
