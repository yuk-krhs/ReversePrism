using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 NewBadge                                 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 038 UnreadBadge                              0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 040 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ExtraStorySecondCategoryCell
    {
        public UIButton?                                Button                                  { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public UITextMeshProUGUI?                       Title                                   { get; set; }

        public static ExtraStorySecondCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraStorySecondCategoryCell();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB93FD70 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB93FD90 0x28 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB93FDB0 0x30 NewBadge                    ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB93FDD0 0x38 UnreadBadge                 ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB93FDF0 0x40 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
