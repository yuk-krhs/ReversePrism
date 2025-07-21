using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HowToPlayButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 028 RetryButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 030 EndButton                                ModelClassType UIButton UIButton UIButton Pointer
    // 038 ResumeButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 040 SettingButton                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 HideButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 loadingMiniCharaView                     SerializableInterface`1<ILoadingMiniCharaViewForLegacy> IL2CPP_TYPE_GENERICINST
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

            value.HowToPlayButton                           = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 HowToPlayButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RetryButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 RetryButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EndButton                                 = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 EndButton                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ResumeButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ResumeButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SettingButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 SettingButton               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HideButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 HideButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
