using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Orientation                              ModelEnumType ScreenOrientation ScreenOrientation ScreenOrientation Int32
    // 024 GpuDetectedOnce                          ModelPrimitiveType bool bool bool Bool
    // 028 Graphic                                  ModelEnumType GraphicProperty GraphicProperty GraphicProperty Int32
    // 02C AllResolution                            ModelEnumType AllResolution AllResolution AllResolution Int32
    // 030 Quality3D                                ModelEnumType QualityType QualityType QualityType Int32
    // 034 ShadowQuality                            ModelEnumType QualityType QualityType QualityType Int32
    // 038 ReflectionQuality                        ModelEnumType QualityType QualityType QualityType Int32
    // 03C AntiAliasingMSAA                         ModelEnumType AntiAliasingMSAA AntiAliasingMSAA AntiAliasingMSAA Int32
    // 040 AntiAliasingFXAA                         ModelEnumType AntiAliasingFXAA AntiAliasingFXAA AntiAliasingFXAA Int32
    // 044 PowerSaving                              ModelEnumType PowerSaving PowerSaving PowerSaving Int32
    // 048 SubsurfaceScattering                     ModelEnumType SubsurfaceScattering SubsurfaceScattering SubsurfaceScattering Int32
    // 04C StoryVoice                               ModelEnumType StoryVoiceSetting StoryVoiceSetting StoryVoiceSetting Int32
    // 050 Skip                                     ModelEnumType SkipSetting SkipSetting SkipSetting Int32
    // 054 ShowDownloadUIOnGasha                    ModelPrimitiveType bool bool bool Bool
    // 058 BgmSettings                              ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 060 SeSettings                               ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 068 VoiceSettings                            ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 070 IsTitleCall                              ModelPrimitiveType bool bool bool Bool
    public partial class OptionLocalSave : DataModel
    {
        public ScreenOrientation                        Orientation                             { get; set; }
        public bool                                     GpuDetectedOnce                         { get; set; }
        public GraphicProperty                          Graphic                                 { get; set; }
        public AllResolution                            AllResolution                           { get; set; }
        public QualityType                              Quality3D                               { get; set; }
        public QualityType                              ShadowQuality                           { get; set; }
        public QualityType                              ReflectionQuality                       { get; set; }
        public AntiAliasingMSAA                         AntiAliasingMSAA                        { get; set; }
        public AntiAliasingFXAA                         AntiAliasingFXAA                        { get; set; }
        public PowerSaving                              PowerSaving                             { get; set; }
        public SubsurfaceScattering                     SubsurfaceScattering                    { get; set; }
        public StoryVoiceSetting                        StoryVoice                              { get; set; }
        public SkipSetting                              Skip                                    { get; set; }
        public bool                                     ShowDownloadUIOnGasha                   { get; set; }
        public EachSoundSettingsLocalSaveType?          BgmSettings                             { get; set; }
        public EachSoundSettingsLocalSaveType?          SeSettings                              { get; set; }
        public EachSoundSettingsLocalSaveType?          VoiceSettings                           { get; set; }
        public bool                                     IsTitleCall                             { get; set; }

        public static OptionLocalSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OptionLocalSave() { Pointer= p0 };

            value.Orientation                               = (ScreenOrientation)GetInt32(new IntPtr(p + 0x020)); // 0x20 Orientation                 ( ModelEnumType ScreenOrientation ScreenOrientation ScreenOrientation Int32 )
            value.GpuDetectedOnce                           = GetBool(new IntPtr(p + 0x024)); // 0x24 GpuDetectedOnce             ( ModelPrimitiveType bool bool bool Bool )
            value.Graphic                                   = (GraphicProperty)GetInt32(new IntPtr(p + 0x028)); // 0x28 Graphic                     ( ModelEnumType GraphicProperty GraphicProperty GraphicProperty Int32 )
            value.AllResolution                             = (AllResolution)GetInt32(new IntPtr(p + 0x02C)); // 0x2C AllResolution               ( ModelEnumType AllResolution AllResolution AllResolution Int32 )
            value.Quality3D                                 = (QualityType)GetInt32(new IntPtr(p + 0x030)); // 0x30 Quality3D                   ( ModelEnumType QualityType QualityType QualityType Int32 )
            value.ShadowQuality                             = (QualityType)GetInt32(new IntPtr(p + 0x034)); // 0x34 ShadowQuality               ( ModelEnumType QualityType QualityType QualityType Int32 )
            value.ReflectionQuality                         = (QualityType)GetInt32(new IntPtr(p + 0x038)); // 0x38 ReflectionQuality           ( ModelEnumType QualityType QualityType QualityType Int32 )
            value.AntiAliasingMSAA                          = (AntiAliasingMSAA)GetInt32(new IntPtr(p + 0x03C)); // 0x3C AntiAliasingMSAA            ( ModelEnumType AntiAliasingMSAA AntiAliasingMSAA AntiAliasingMSAA Int32 )
            value.AntiAliasingFXAA                          = (AntiAliasingFXAA)GetInt32(new IntPtr(p + 0x040)); // 0x40 AntiAliasingFXAA            ( ModelEnumType AntiAliasingFXAA AntiAliasingFXAA AntiAliasingFXAA Int32 )
            value.PowerSaving                               = (PowerSaving)GetInt32(new IntPtr(p + 0x044)); // 0x44 PowerSaving                 ( ModelEnumType PowerSaving PowerSaving PowerSaving Int32 )
            value.SubsurfaceScattering                      = (SubsurfaceScattering)GetInt32(new IntPtr(p + 0x048)); // 0x48 SubsurfaceScattering        ( ModelEnumType SubsurfaceScattering SubsurfaceScattering SubsurfaceScattering Int32 )
            value.StoryVoice                                = (StoryVoiceSetting)GetInt32(new IntPtr(p + 0x04C)); // 0x4C StoryVoice                  ( ModelEnumType StoryVoiceSetting StoryVoiceSetting StoryVoiceSetting Int32 )
            value.Skip                                      = (SkipSetting)GetInt32(new IntPtr(p + 0x050)); // 0x50 Skip                        ( ModelEnumType SkipSetting SkipSetting SkipSetting Int32 )
            value.ShowDownloadUIOnGasha                     = GetBool(new IntPtr(p + 0x054)); // 0x54 ShowDownloadUIOnGasha       ( ModelPrimitiveType bool bool bool Bool )
            value.BgmSettings                               = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x058), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 0x58 BgmSettings                 ( ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.SeSettings                                = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x060), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 0x60 SeSettings                  ( ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.VoiceSettings                             = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x068), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 0x68 VoiceSettings               ( ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.IsTitleCall                               = GetBool(new IntPtr(p + 0x070)); // 0x70 IsTitleCall                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
