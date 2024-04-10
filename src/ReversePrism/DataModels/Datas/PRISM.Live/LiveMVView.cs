using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundBlocker                        0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 BackgroundBlockerFadeDuration            0001866656B0 ModelPrimitiveType float float float Single
    // 030 PauseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PauseIcon                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 040 PauseMenu                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ShowPauseMenuButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 HidePauseMenuButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 ResumeButton                             000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 ResumeIcon                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 068 ForwardButton                            000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 BackwardButton                           000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 SeekBar                                  00018655C7A0 ModelClassType LiveMVSeekBar LiveMVSeekBar LiveMVSeekBar Pointer
    // 080 SkipButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 RetryButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 090 LyricsToggle                             0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 098 LyricsText                               0001866411C0 ModelClassType TextMeshProUguiBase TextMeshProUguiBase TextMeshProUguiBase Pointer
    // 0A0 Sequence                                 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer
    public partial class LiveMVView : DataModel
    {
        public Image?                                   BackgroundBlocker                       { get; set; }
        public float                                    BackgroundBlockerFadeDuration           { get; set; }
        public ButtonBase?                              PauseButton                             { get; set; }
        public Image?                                   PauseIcon                               { get; set; }
        public GameObject?                              PauseMenu                               { get; set; }
        public ButtonBase?                              ShowPauseMenuButton                     { get; set; }
        public ButtonBase?                              HidePauseMenuButton                     { get; set; }
        public ButtonBase?                              ResumeButton                            { get; set; }
        public Image?                                   ResumeIcon                              { get; set; }
        public ButtonBase?                              ForwardButton                           { get; set; }
        public ButtonBase?                              BackwardButton                          { get; set; }
        public LiveMVSeekBar?                           SeekBar                                 { get; set; }
        public ButtonBase?                              SkipButton                              { get; set; }
        public ButtonBase?                              RetryButton                             { get; set; }
        public ToggleSwitch?                            LyricsToggle                            { get; set; }
        public TextMeshProUguiBase?                     LyricsText                              { get; set; }
        public Sequence?                                Sequence                                { get; set; }

        public static LiveMVView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVView() { Pointer= p0 };

            value.BackgroundBlocker                         = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 02466515FC90 0x20 BackgroundBlocker           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.BackgroundBlockerFadeDuration             = GetSingle(new IntPtr(p + 0x028)); // 02466515FCB0 0x28 BackgroundBlockerFadeDuration ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PauseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FCD0 0x30 PauseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PauseIcon                                 = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 02466515FCF0 0x38 PauseIcon                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.PauseMenu                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466515FD10 0x40 PauseMenu                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ShowPauseMenuButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FD30 0x48 ShowPauseMenuButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HidePauseMenuButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FD50 0x50 HidePauseMenuButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResumeButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FD70 0x58 ResumeButton                ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResumeIcon                                = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 02466515FD90 0x60 ResumeIcon                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ForwardButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FDB0 0x68 ForwardButton               ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackwardButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FDD0 0x70 BackwardButton              ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SeekBar                                   = GetObject<LiveMVSeekBar>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveMVSeekBar.FromPointer); // 02466515FDF0 0x78 SeekBar                     ( 00018655C7A0 ModelClassType LiveMVSeekBar LiveMVSeekBar LiveMVSeekBar Pointer )
            value.SkipButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FE10 0x80 SkipButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RetryButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466515FE30 0x88 RetryButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LyricsToggle                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466515FE50 0x90 LyricsToggle                ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LyricsText                                = GetObject<TextMeshProUguiBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.TextMeshProUguiBase.FromPointer); // 02466515FE70 0x98 LyricsText                  ( 0001866411C0 ModelClassType TextMeshProUguiBase TextMeshProUguiBase TextMeshProUguiBase Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Sequence.FromPointer); // 02466515FE90 0xA0 Sequence                    ( 0001867264E0 ModelClassType Sequence Sequence Sequence Pointer )

            return value;
        }
    }
}
