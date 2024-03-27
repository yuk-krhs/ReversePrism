using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OrientationSettigns                      ScreenOrientation[] IL2CPP_TYPE_SZARRAY
    // 000 initialOrientationButtonIndex            int IL2CPP_TYPE_I4
    // 000 initialTitleCall                         bool IL2CPP_TYPE_BOOLEAN
    // 030 OrientationRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 OrientationGroup                         000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 040 StoryVoiceGroup                          000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 048 SkipGroup                                000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 050 TitleCallToggle                          0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 058 SetInitialSettingsButton                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 RecommendedIconInGraphic                 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 068 RecommendedIconInPerformance             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 070 GraphicGroup                             000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 AllResolutionGroup                       000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 080 Quality3DGroup                           000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 088 ShadowQualityGroup                       000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 090 AntiAliasGroup                           000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 098 PowerSavingGroup                         000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    public partial class BasicSettings
    {
        public GameObject?                              OrientationRoot                         { get; set; }
        public ToggleButtonGroup?                       OrientationGroup                        { get; set; }
        public ToggleButtonGroup?                       StoryVoiceGroup                         { get; set; }
        public ToggleButtonGroup?                       SkipGroup                               { get; set; }
        public ToggleSwitch?                            TitleCallToggle                         { get; set; }
        public UIButton?                                SetInitialSettingsButton                { get; set; }
        public UIImage?                                 RecommendedIconInGraphic                { get; set; }
        public UIImage?                                 RecommendedIconInPerformance            { get; set; }
        public ToggleButtonGroup?                       GraphicGroup                            { get; set; }
        public ToggleButtonGroup?                       AllResolutionGroup                      { get; set; }
        public ToggleButtonGroup?                       Quality3DGroup                          { get; set; }
        public ToggleButtonGroup?                       ShadowQualityGroup                      { get; set; }
        public ToggleButtonGroup?                       AntiAliasGroup                          { get; set; }
        public ToggleButtonGroup?                       PowerSavingGroup                        { get; set; }

        public static BasicSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasicSettings();

            value.OrientationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D55535F8 0x30 OrientationRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OrientationGroup                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553618 0x38 OrientationGroup            ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.StoryVoiceGroup                           = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553638 0x40 StoryVoiceGroup             ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SkipGroup                                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553658 0x48 SkipGroup                   ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.TitleCallToggle                           = GetObject<ToggleSwitch>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0270D5553678 0x50 TitleCallToggle             ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.SetInitialSettingsButton                  = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5553698 0x58 SetInitialSettingsButton    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RecommendedIconInGraphic                  = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0270D55536B8 0x60 RecommendedIconInGraphic    ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.RecommendedIconInPerformance              = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0270D55536D8 0x68 RecommendedIconInPerformance ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.GraphicGroup                              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D55536F8 0x70 GraphicGroup                ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.AllResolutionGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553718 0x78 AllResolutionGroup          ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.Quality3DGroup                            = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553738 0x80 Quality3DGroup              ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShadowQualityGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553758 0x88 ShadowQualityGroup          ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.AntiAliasGroup                            = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553778 0x90 AntiAliasGroup              ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.PowerSavingGroup                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D5553798 0x98 PowerSavingGroup            ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )

            return value;
        }
    }
}
