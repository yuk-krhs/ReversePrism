using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UserButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 IconImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 UserNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoticeBadge                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class CallTopUserButton
    {
        public UIButton?                                UserButton                              { get; set; }
        public UIImage?                                 IconImage                               { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }
        public GameObject?                              NoticeBadge                             { get; set; }

        public static CallTopUserButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallTopUserButton();

            value.UserButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB0E3FB0 0x20 UserButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E3FD0 0x28 IconImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E3FF0 0x30 UserNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadge                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB0E4010 0x38 NoticeBadge                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
