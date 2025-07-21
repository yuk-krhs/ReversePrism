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
    // 030 OrientationRoot                          ModelClassType GameObject GameObject GameObject Pointer
    // 038 OrientationGroup                         ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 040 StoryVoiceGroup                          ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 048 SkipGroup                                ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 050 TitleCallToggle                          ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 058 SetInitialSettingsButton                 ModelClassType UIButton UIButton UIButton Pointer
    // 060 RecommendedIconInGraphic                 ModelClassType UIImage UIImage UIImage Pointer
    // 068 RecommendedIconInPerformance             ModelClassType UIImage UIImage UIImage Pointer
    // 070 GraphicGroup                             ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 AllResolutionGroup                       ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 080 Quality3DGroup                           ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 088 ShadowQualityGroup                       ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 090 ReflectionQualityGroup                   ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 098 AntiAliasMSAAGroup                       ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 0A0 AntiAliasFXAAGroup                       ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 0A8 SubsurfaceScatteringGroup                ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 0B0 PowerSavingGroup                         ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    public partial class BasicSettings : DataModel
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
        public ToggleButtonGroup?                       ReflectionQualityGroup                  { get; set; }
        public ToggleButtonGroup?                       AntiAliasMSAAGroup                      { get; set; }
        public ToggleButtonGroup?                       AntiAliasFXAAGroup                      { get; set; }
        public ToggleButtonGroup?                       SubsurfaceScatteringGroup               { get; set; }
        public ToggleButtonGroup?                       PowerSavingGroup                        { get; set; }

        public static BasicSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasicSettings() { Pointer= p0 };

            value.OrientationRoot                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 OrientationRoot             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OrientationGroup                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x38 OrientationGroup            ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.StoryVoiceGroup                           = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x40 StoryVoiceGroup             ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SkipGroup                                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x48 SkipGroup                   ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.TitleCallToggle                           = GetObject<ToggleSwitch>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x50 TitleCallToggle             ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.SetInitialSettingsButton                  = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 SetInitialSettingsButton    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RecommendedIconInGraphic                  = GetObject<UIImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIImage.FromPointer); // 0x60 RecommendedIconInGraphic    ( ModelClassType UIImage UIImage UIImage Pointer )
            value.RecommendedIconInPerformance              = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0x68 RecommendedIconInPerformance ( ModelClassType UIImage UIImage UIImage Pointer )
            value.GraphicGroup                              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x70 GraphicGroup                ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.AllResolutionGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x78 AllResolutionGroup          ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.Quality3DGroup                            = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x80 Quality3DGroup              ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShadowQualityGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x88 ShadowQualityGroup          ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ReflectionQualityGroup                    = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x90 ReflectionQualityGroup      ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.AntiAliasMSAAGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x98 AntiAliasMSAAGroup          ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.AntiAliasFXAAGroup                        = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0xA0 AntiAliasFXAAGroup          ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.SubsurfaceScatteringGroup                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0xA8 SubsurfaceScatteringGroup   ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.PowerSavingGroup                          = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0xB0 PowerSavingGroup            ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )

            return value;
        }
    }
}
