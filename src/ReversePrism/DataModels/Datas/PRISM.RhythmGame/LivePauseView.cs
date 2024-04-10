using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HowToPlayButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 RetryButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 EndButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 ResumeButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 SettingButton                            000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 HideButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class LivePauseView : DataModel
    {
        public UIButton?                                HowToPlayButton                         { get; set; }
        public UIButton?                                RetryButton                             { get; set; }
        public UIButton?                                EndButton                               { get; set; }
        public UIButton?                                ResumeButton                            { get; set; }
        public ButtonBase?                              SettingButton                           { get; set; }
        public ButtonBase?                              HideButton                              { get; set; }

        public static LivePauseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LivePauseView() { Pointer= p0 };

            value.HowToPlayButton                           = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0246650A3678 0x20 HowToPlayButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RetryButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0246650A3698 0x28 RetryButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EndButton                                 = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0246650A36B8 0x30 EndButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ResumeButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0246650A36D8 0x38 ResumeButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SettingButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246650A36F8 0x40 SettingButton               ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HideButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246650A3718 0x48 HideButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
