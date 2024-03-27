using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          0001866EFB70 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 MusicBasicInfoView                       000186663300 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 030 CameraSettingButton                      000186538310 ModelClassType CameraSettingButton CameraSettingButton CameraSettingButton Pointer
    // 038 VocalSettingButton                       0001865337E0 ModelClassType VocalSettingButton VocalSettingButton VocalSettingButton Pointer
    // 040 LiveBackgroundModeSelector               000186540590 ModelClassType LiveBackgroundModeSelector LiveBackgroundModeSelector LiveBackgroundModeSelector Pointer
    // 048 StartButton                              0001866985D0 ModelClassType GrayOutErrorModalButton GrayOutErrorModalButton GrayOutErrorModalButton Pointer
    public partial class LiveUnitConfirmationViewBase
    {
        public UIRawImage?                              BackgroundImage                         { get; set; }
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public CameraSettingButton?                     CameraSettingButton                     { get; set; }
        public VocalSettingButton?                      VocalSettingButton                      { get; set; }
        public LiveBackgroundModeSelector?              LiveBackgroundModeSelector              { get; set; }
        public GrayOutErrorModalButton?                 StartButton                             { get; set; }

        public static LiveUnitConfirmationViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationViewBase();

            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D51130C0 0x20 BackgroundImage             ( 0001866EFB70 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270D51130E0 0x28 MusicBasicInfoView          ( 000186663300 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.CameraSettingButton                       = GetObject<CameraSettingButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.CameraSettingButton.FromPointer); // 0270D5113100 0x30 CameraSettingButton         ( 000186538310 ModelClassType CameraSettingButton CameraSettingButton CameraSettingButton Pointer )
            value.VocalSettingButton                        = GetObject<VocalSettingButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.VocalSettingButton.FromPointer); // 0270D5113120 0x38 VocalSettingButton          ( 0001865337E0 ModelClassType VocalSettingButton VocalSettingButton VocalSettingButton Pointer )
            value.LiveBackgroundModeSelector                = GetObject<LiveBackgroundModeSelector>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveBackgroundModeSelector.FromPointer); // 0270D5113140 0x40 LiveBackgroundModeSelector  ( 000186540590 ModelClassType LiveBackgroundModeSelector LiveBackgroundModeSelector LiveBackgroundModeSelector Pointer )
            value.StartButton                               = GetObject<GrayOutErrorModalButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.GrayOutErrorModalButton.FromPointer); // 0270D5113160 0x48 StartButton                 ( 0001866985D0 ModelClassType GrayOutErrorModalButton GrayOutErrorModalButton GrayOutErrorModalButton Pointer )

            return value;
        }
    }
}
