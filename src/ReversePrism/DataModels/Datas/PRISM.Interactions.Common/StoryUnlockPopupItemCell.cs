using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CategoryText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 TitleText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    public partial class StoryUnlockPopupItemCell : DataModel
    {
        public TextMeshProUGUI?                         CategoryText                            { get; set; }
        public TextMeshProUGUI?                         TitleText                               { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }

        public static StoryUnlockPopupItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryUnlockPopupItemCell() { Pointer= p0 };

            value.CategoryText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 CategoryText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.TitleText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 TitleText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
