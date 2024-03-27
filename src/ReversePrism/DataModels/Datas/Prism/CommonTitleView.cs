using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 HowToPlayButton                          000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class CommonTitleView
    {
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public ButtonBase?                              HowToPlayButton                         { get; set; }

        public static CommonTitleView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonTitleView();

            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270040446B0 0x20 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HowToPlayButton                           = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270040446D0 0x28 HowToPlayButton             ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
