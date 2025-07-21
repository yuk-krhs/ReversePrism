using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 MusicBasicInfoView                       ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 030 CameraSettingButton                      ModelClassType CameraSettingButton CameraSettingButton CameraSettingButton Pointer
    // 038 VocalSettingButton                       ModelClassType VocalSettingButton VocalSettingButton VocalSettingButton Pointer
    // 040 LimitedVocalSeparateButton               ModelClassType LimitedVocalSeparateButton LimitedVocalSeparateButton LimitedVocalSeparateButton Pointer
    // 048 LiveBackgroundModeSelector               ModelClassType LiveBackgroundModeSelector LiveBackgroundModeSelector LiveBackgroundModeSelector Pointer
    // 050 StartButton                              ModelClassType GrayOutErrorModalButton GrayOutErrorModalButton GrayOutErrorModalButton Pointer
    public partial class LiveUnitConfirmationViewBase : DataModel
    {
        public UIRawImage?                              BackgroundImage                         { get; set; }
        public MusicBasicInfoView?                      MusicBasicInfoView                      { get; set; }
        public CameraSettingButton?                     CameraSettingButton                     { get; set; }
        public VocalSettingButton?                      VocalSettingButton                      { get; set; }
        public LimitedVocalSeparateButton?              LimitedVocalSeparateButton              { get; set; }
        public LiveBackgroundModeSelector?              LiveBackgroundModeSelector              { get; set; }
        public GrayOutErrorModalButton?                 StartButton                             { get; set; }

        public static LiveUnitConfirmationViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationViewBase() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 BackgroundImage             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicBasicInfoView                        = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x28 MusicBasicInfoView          ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.CameraSettingButton                       = GetObject<CameraSettingButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.CameraSettingButton.FromPointer); // 0x30 CameraSettingButton         ( ModelClassType CameraSettingButton CameraSettingButton CameraSettingButton Pointer )
            value.VocalSettingButton                        = GetObject<VocalSettingButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.VocalSettingButton.FromPointer); // 0x38 VocalSettingButton          ( ModelClassType VocalSettingButton VocalSettingButton VocalSettingButton Pointer )
            value.LimitedVocalSeparateButton                = GetObject<LimitedVocalSeparateButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.LimitedVocalSeparateButton.FromPointer); // 0x40 LimitedVocalSeparateButton  ( ModelClassType LimitedVocalSeparateButton LimitedVocalSeparateButton LimitedVocalSeparateButton Pointer )
            value.LiveBackgroundModeSelector                = GetObject<LiveBackgroundModeSelector>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveBackgroundModeSelector.FromPointer); // 0x48 LiveBackgroundModeSelector  ( ModelClassType LiveBackgroundModeSelector LiveBackgroundModeSelector LiveBackgroundModeSelector Pointer )
            value.StartButton                               = GetObject<GrayOutErrorModalButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.GrayOutErrorModalButton.FromPointer); // 0x50 StartButton                 ( ModelClassType GrayOutErrorModalButton GrayOutErrorModalButton GrayOutErrorModalButton Pointer )

            return value;
        }
    }
}
