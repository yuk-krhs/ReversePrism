using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UserButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 IconButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 IconImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 UserNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NoticeBadge                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ChainTopUserButton
    {
        public UIButton?                                UserButton                              { get; set; }
        public UIButton?                                IconButton                              { get; set; }
        public UIImage?                                 IconImage                               { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }
        public GameObject?                              NoticeBadge                             { get; set; }

        public static ChainTopUserButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTopUserButton();

            value.UserButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB116EA8 0x20 UserButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB116EC8 0x28 IconButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB116EE8 0x30 IconImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB116F08 0x38 UserNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadge                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB116F28 0x40 NoticeBadge                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
