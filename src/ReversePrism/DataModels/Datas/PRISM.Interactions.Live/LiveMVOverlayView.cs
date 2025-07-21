using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SetTimeDelayFrame                        ModelPrimitiveType int int int Int32
    // 024 SetTimeDelayTiming                       ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 028 BackgroundBlockerFadeDuration            ModelPrimitiveType float float float Single
    // 02C SeekWaitMilliSeconds                     ModelPrimitiveType int int int Int32
    // 030 BackgroundBlocker                        ModelClassType Image Image Image Pointer
    // 038 PauseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 PauseIcon                                ModelClassType Image Image Image Pointer
    // 048 PauseMenu                                ModelClassType GameObject GameObject GameObject Pointer
    // 050 ShowPauseMenuButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 HidePauseMenuButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 ResumeButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 068 ResumeIcon                               ModelClassType Image Image Image Pointer
    // 070 ForwardButton                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 BackwardButton                           ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 080 SeekBar                                  ModelClassType LiveMVSeekBar LiveMVSeekBar LiveMVSeekBar Pointer
    // 088 SkipButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 090 RetryButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 098 LyricsToggle                             ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0A0 LyricsText                               ModelClassType TextMeshProUguiBase TextMeshProUguiBase TextMeshProUguiBase Pointer
    // 0A8 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 Sequence                                 ModelClassType Sequence Sequence Sequence Pointer
    public partial class LiveMVOverlayView : DataModel
    {
        public int                                      SetTimeDelayFrame                       { get; set; }
        public PlayerLoopTiming                         SetTimeDelayTiming                      { get; set; }
        public float                                    BackgroundBlockerFadeDuration           { get; set; }
        public int                                      SeekWaitMilliSeconds                    { get; set; }
        public Image?                                   BackgroundBlocker                       { get; set; }
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

        public static LiveMVOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVOverlayView() { Pointer= p0 };

            value.SetTimeDelayFrame                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 SetTimeDelayFrame           ( ModelPrimitiveType int int int Int32 )
            value.SetTimeDelayTiming                        = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x024)); // 0x24 SetTimeDelayTiming          ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.BackgroundBlockerFadeDuration             = GetSingle(new IntPtr(p + 0x028)); // 0x28 BackgroundBlockerFadeDuration ( ModelPrimitiveType float float float Single )
            value.SeekWaitMilliSeconds                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C SeekWaitMilliSeconds        ( ModelPrimitiveType int int int Int32 )
            value.BackgroundBlocker                         = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 BackgroundBlocker           ( ModelClassType Image Image Image Pointer )
            value.PauseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 PauseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PauseIcon                                 = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 PauseIcon                   ( ModelClassType Image Image Image Pointer )
            value.PauseMenu                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 PauseMenu                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShowPauseMenuButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 ShowPauseMenuButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HidePauseMenuButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 HidePauseMenuButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResumeButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x60 ResumeButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ResumeIcon                                = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0x68 ResumeIcon                  ( ModelClassType Image Image Image Pointer )
            value.ForwardButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x70 ForwardButton               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackwardButton                            = GetObject<ButtonBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x78 BackwardButton              ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SeekBar                                   = GetObject<LiveMVSeekBar>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveMVSeekBar.FromPointer); // 0x80 SeekBar                     ( ModelClassType LiveMVSeekBar LiveMVSeekBar LiveMVSeekBar Pointer )
            value.SkipButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x88 SkipButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RetryButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x090), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x90 RetryButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.LyricsToggle                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x98 LyricsToggle                ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LyricsText                                = GetObject<TextMeshProUguiBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TextMeshProUguiBase.FromPointer); // 0xA0 LyricsText                  ( ModelClassType TextMeshProUguiBase TextMeshProUguiBase TextMeshProUguiBase Pointer )
            value.Sequence                                  = GetObject<Sequence>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Sequence.FromPointer); // 0xB0 Sequence                    ( ModelClassType Sequence Sequence Sequence Pointer )

            return value;
        }
    }
}
