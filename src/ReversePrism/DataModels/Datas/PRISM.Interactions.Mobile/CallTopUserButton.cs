using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UserButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 028 IconImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 030 UserNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NoticeBadge                              ModelClassType GameObject GameObject GameObject Pointer
    public partial class CallTopUserButton : DataModel
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
            var value   = new CallTopUserButton() { Pointer= p0 };

            value.UserButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 UserButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 IconImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 UserNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadge                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NoticeBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
