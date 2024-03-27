using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 LogoImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 NewBadge                                 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 040 UnreadBadge                              0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MainStoryFirstCategoryCell
    {
        public UIButton?                                Button                                  { get; set; }
        public UIImage?                                 LogoImage                               { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public GameObject?                              NewBadge                                { get; set; }
        public GameObject?                              UnreadBadge                             { get; set; }
        public UITextMeshProUGUI?                       Title                                   { get; set; }

        public static MainStoryFirstCategoryCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainStoryFirstCategoryCell();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB99EA28 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LogoImage                                 = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB99EA48 0x28 LogoImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB99EA68 0x30 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB99EA88 0x38 NewBadge                    ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnreadBadge                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB99EAA8 0x40 UnreadBadge                 ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB99EAC8 0x48 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
