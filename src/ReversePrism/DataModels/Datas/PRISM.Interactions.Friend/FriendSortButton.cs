using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 LabelText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IconImage                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 IconSprites                              000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    public partial class FriendSortButton
    {
        public UIButton?                                Button                                  { get; set; }
        public UITextMeshProUGUI?                       LabelText                               { get; set; }
        public Image?                                   IconImage                               { get; set; }
        public List<Sprite>?                            IconSprites                             { get; set; }

        public static FriendSortButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendSortButton();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBDE5ED8 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LabelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE5EF8 0x28 LabelText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconImage                                 = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270DBDE5F18 0x30 IconImage                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.IconSprites                               = GetObjectList<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0270DBDE5F38 0x38 IconSprites                 ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
