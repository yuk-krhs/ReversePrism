using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchDisplayButton                      ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 028 SearchButton                             ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 RandomSelectButton                       ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 PlayMVButton                             ModelClassType PlayMVButton PlayMVButton PlayMVButton Pointer
    // 040 DownloadMusicButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 StartButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 StartButtonLocked                        ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 BackgroundImage                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 NextBackgroundImage                      ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 EventBannerImage                         ModelClassType UIImage UIImage UIImage Pointer
    // 070 EventBannerButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 078 SlideAnimation                           ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    // 080 switchDisplaySubject                     Subject`1<MusicListSwitchDisplayType> IL2CPP_TYPE_GENERICINST
    // 088 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveMusicSelectionView : DataModel
    {
        public ClickNumberCountedButton?                SwitchDisplayButton                     { get; set; }
        public ToggleButton?                            SearchButton                            { get; set; }
        public ButtonBase?                              RandomSelectButton                      { get; set; }
        public PlayMVButton?                            PlayMVButton                            { get; set; }
        public ButtonBase?                              DownloadMusicButton                     { get; set; }
        public ButtonBase?                              StartButton                             { get; set; }
        public ButtonBase?                              StartButtonLocked                       { get; set; }
        public UIRawImage?                              BackgroundImage                         { get; set; }
        public UIRawImage?                              NextBackgroundImage                     { get; set; }
        public UIImage?                                 EventBannerImage                        { get; set; }
        public UIButton?                                EventBannerButton                       { get; set; }
        public SimpleSlideAnimation?                    SlideAnimation                          { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveMusicSelectionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionView() { Pointer= p0 };

            value.SwitchDisplayButton                       = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0x20 SwitchDisplayButton         ( ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.SearchButton                              = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 SearchButton                ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.RandomSelectButton                        = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 RandomSelectButton          ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.PlayMVButton                              = GetObject<PlayMVButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayMVButton.FromPointer); // 0x38 PlayMVButton                ( ModelClassType PlayMVButton PlayMVButton PlayMVButton Pointer )
            value.DownloadMusicButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 DownloadMusicButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StartButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 StartButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StartButtonLocked                         = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 StartButtonLocked           ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x58 BackgroundImage             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.NextBackgroundImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x60 NextBackgroundImage         ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.EventBannerImage                          = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0x68 EventBannerImage            ( ModelClassType UIImage UIImage UIImage Pointer )
            value.EventBannerButton                         = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 EventBannerButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x078), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0x78 SlideAnimation              ( ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x088)); // 0x88 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
