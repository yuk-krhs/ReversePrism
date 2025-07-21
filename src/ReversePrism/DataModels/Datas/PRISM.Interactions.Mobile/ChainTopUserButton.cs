using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UserButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 028 IconButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 IconImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 038 UserNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 NoticeBadge                              ModelClassType GameObject GameObject GameObject Pointer
    public partial class ChainTopUserButton : DataModel
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
            var value   = new ChainTopUserButton() { Pointer= p0 };

            value.UserButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 UserButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IconButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 IconButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 IconImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 UserNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NoticeBadge                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NoticeBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
