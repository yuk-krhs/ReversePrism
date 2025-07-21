using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundBlocker                        ModelClassType Image Image Image Pointer
    // 028 BackgroundBlockerFadeDuration            ModelPrimitiveType float float float Single
    // 030 PauseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PauseIcon                                ModelClassType Image Image Image Pointer
    // 040 PauseMenu                                ModelClassType GameObject GameObject GameObject Pointer
    // 048 ShowPauseMenuButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 HidePauseMenuButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 ResumeButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 ResumeIcon                               ModelClassType Image Image Image Pointer
    // 068 ForwardButton                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 BackwardButton                           ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 SeekBar                                  ModelClassType LiveMVSeekBar LiveMVSeekBar LiveMVSeekBar Pointer
    // 080 SkipButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 RetryButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 090 LyricsToggle                             ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 098 LyricsText                               ModelClassType TextMeshProUguiBase TextMeshProUguiBase TextMeshProUguiBase Pointer
    // 0A0 Sequence                                 ModelClassType Sequence Sequence Sequence Pointer
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

            value.BackgroundBlocker                         = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 BackgroundBlocker           ( ModelClassType Image Image Image Pointer )
            value.BackgroundBlockerFadeDuration             = GetSingle(new IntPtr(p + 0x028)); // 0x28 BackgroundBlockerFadeDuration ( ModelPrimitiveType float float float Single )
            value.PauseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 PauseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PauseIcon                                 = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 PauseIcon                   ( ModelClassType Image Image Image Pointer )
            value.PauseMenu                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 PauseMenu                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShowPauseMenuButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 ShowPauseMenuButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HidePauseMenuButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 HidePauseMenuButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResumeButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 ResumeButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResumeIcon                                = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0x60 ResumeIcon                  ( ModelClassType Image Image Image Pointer )
            value.ForwardButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x68 ForwardButton               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackwardButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x70 BackwardButton              ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SeekBar                                   = GetObject<LiveMVSeekBar>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveMVSeekBar.FromPointer); // 0x78 SeekBar                     ( ModelClassType LiveMVSeekBar LiveMVSeekBar LiveMVSeekBar Pointer )
            value.SkipButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x80 SkipButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RetryButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x88 RetryButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LyricsToggle                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x90 LyricsToggle                ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LyricsText                                = GetObject<TextMeshProUguiBase>(new IntPtr(p + 0x098), ReversePrism.DataModels.TextMeshProUguiBase.FromPointer); // 0x98 LyricsText                  ( ModelClassType TextMeshProUguiBase TextMeshProUguiBase TextMeshProUguiBase Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Sequence.FromPointer); // 0xA0 Sequence                    ( ModelClassType Sequence Sequence Sequence Pointer )

            return value;
        }
    }
}
