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
    public partial class ChainGroupMemberButton
    {
        public UIButton?                                UserButton                              { get; set; }
        public UIImage?                                 IconImage                               { get; set; }
        public UITextMeshProUGUI?                       UserNameText                            { get; set; }

        public static ChainGroupMemberButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainGroupMemberButton();

            value.UserButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB0E40D0 0x20 UserButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IconImage                                 = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E40F0 0x28 IconImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UserNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E4110 0x30 UserNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
