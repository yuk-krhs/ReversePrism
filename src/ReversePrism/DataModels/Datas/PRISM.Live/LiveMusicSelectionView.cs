using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchDisplayButton                      0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 028 SearchButton                             000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 PlayMVButton                             000186749DF0 ModelClassType PlayMVButton PlayMVButton PlayMVButton Pointer
    // 038 DownloadMusicButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 StartButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 StartButtonLocked                        000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 BackgroundImage                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 058 NextBackgroundImage                      0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 EventBannerImage                         0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 068 EventBannerButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 SlideAnimation                           00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    // 078 switchDisplaySubject                     Subject`1<MusicListSwitchDisplayType> IL2CPP_TYPE_GENERICINST
    // 080 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveMusicSelectionView : DataModel
    {
        public ClickNumberCountedButton?                SwitchDisplayButton                     { get; set; }
        public ToggleButton?                            SearchButton                            { get; set; }
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

            value.SwitchDisplayButton                       = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0246651E51E0 0x20 SwitchDisplayButton         ( 0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.SearchButton                              = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246651E5200 0x28 SearchButton                ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.PlayMVButton                              = GetObject<PlayMVButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayMVButton.FromPointer); // 0246651E5220 0x30 PlayMVButton                ( 000186749DF0 ModelClassType PlayMVButton PlayMVButton PlayMVButton Pointer )
            value.DownloadMusicButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246651E5240 0x38 DownloadMusicButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StartButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246651E5260 0x40 StartButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StartButtonLocked                         = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246651E5280 0x48 StartButtonLocked           ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246651E52A0 0x50 BackgroundImage             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.NextBackgroundImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246651E52C0 0x58 NextBackgroundImage         ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.EventBannerImage                          = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0246651E52E0 0x60 EventBannerImage            ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.EventBannerButton                         = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0246651E5300 0x68 EventBannerButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x070), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0246651E5320 0x70 SlideAnimation              ( 00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x080)); // 0246651E5360 0x80 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
