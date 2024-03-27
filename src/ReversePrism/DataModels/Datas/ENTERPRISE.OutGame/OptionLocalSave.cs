using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Orientation                              0001866F2CF0 ModelEnumType ScreenOrientation ScreenOrientation ScreenOrientation Int32
    // 024 GpuDetectedOnce                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 Graphic                                  000186693970 ModelEnumType GraphicProperty GraphicProperty GraphicProperty Int32
    // 02C AllResolution                            0001866A3160 ModelEnumType AllResolution AllResolution AllResolution Int32
    // 030 Quality3D                                0001865FAA90 ModelEnumType QualityType QualityType QualityType Int32
    // 034 ShadowQuality                            0001865FAA90 ModelEnumType QualityType QualityType QualityType Int32
    // 038 AntiAliasing                             0001866C4B00 ModelEnumType AntiAliasing AntiAliasing AntiAliasing Int32
    // 03C PowerSaving                              000186772B30 ModelEnumType PowerSaving PowerSaving PowerSaving Int32
    // 040 StoryVoice                               0001865B3210 ModelEnumType StoryVoiceSetting StoryVoiceSetting StoryVoiceSetting Int32
    // 044 Skip                                     000186518360 ModelEnumType SkipSetting SkipSetting SkipSetting Int32
    // 048 ShowDownloadUIOnGasha                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 BgmSettings                              0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 058 SeSettings                               0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 060 VoiceSettings                            0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 068 IsTitleCall                              000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class OptionLocalSave
    {
        public ScreenOrientation                        Orientation                             { get; set; }
        public bool                                     GpuDetectedOnce                         { get; set; }
        public GraphicProperty                          Graphic                                 { get; set; }
        public AllResolution                            AllResolution                           { get; set; }
        public QualityType                              Quality3D                               { get; set; }
        public QualityType                              ShadowQuality                           { get; set; }
        public AntiAliasing                             AntiAliasing                            { get; set; }
        public PowerSaving                              PowerSaving                             { get; set; }
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
            var value   = new OptionLocalSave();

            value.Orientation                               = (ScreenOrientation)GetInt32(new IntPtr(p + 0x020)); // 027003A7C040 0x20 Orientation                 ( 0001866F2CF0 ModelEnumType ScreenOrientation ScreenOrientation ScreenOrientation Int32 )
            value.GpuDetectedOnce                           = GetBool(new IntPtr(p + 0x024)); // 027003A7C060 0x24 GpuDetectedOnce             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Graphic                                   = (GraphicProperty)GetInt32(new IntPtr(p + 0x028)); // 027003A7C080 0x28 Graphic                     ( 000186693970 ModelEnumType GraphicProperty GraphicProperty GraphicProperty Int32 )
            value.AllResolution                             = (AllResolution)GetInt32(new IntPtr(p + 0x02C)); // 027003A7C0A0 0x2C AllResolution               ( 0001866A3160 ModelEnumType AllResolution AllResolution AllResolution Int32 )
            value.Quality3D                                 = (QualityType)GetInt32(new IntPtr(p + 0x030)); // 027003A7C0C0 0x30 Quality3D                   ( 0001865FAA90 ModelEnumType QualityType QualityType QualityType Int32 )
            value.ShadowQuality                             = (QualityType)GetInt32(new IntPtr(p + 0x034)); // 027003A7C0E0 0x34 ShadowQuality               ( 0001865FAA90 ModelEnumType QualityType QualityType QualityType Int32 )
            value.AntiAliasing                              = (AntiAliasing)GetInt32(new IntPtr(p + 0x038)); // 027003A7C100 0x38 AntiAliasing                ( 0001866C4B00 ModelEnumType AntiAliasing AntiAliasing AntiAliasing Int32 )
            value.PowerSaving                               = (PowerSaving)GetInt32(new IntPtr(p + 0x03C)); // 027003A7C120 0x3C PowerSaving                 ( 000186772B30 ModelEnumType PowerSaving PowerSaving PowerSaving Int32 )
            value.StoryVoice                                = (StoryVoiceSetting)GetInt32(new IntPtr(p + 0x040)); // 027003A7C140 0x40 StoryVoice                  ( 0001865B3210 ModelEnumType StoryVoiceSetting StoryVoiceSetting StoryVoiceSetting Int32 )
            value.Skip                                      = (SkipSetting)GetInt32(new IntPtr(p + 0x044)); // 027003A7C160 0x44 Skip                        ( 000186518360 ModelEnumType SkipSetting SkipSetting SkipSetting Int32 )
            value.ShowDownloadUIOnGasha                     = GetBool(new IntPtr(p + 0x048)); // 027003A7C180 0x48 ShowDownloadUIOnGasha       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BgmSettings                               = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x050), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 027003A7C1A0 0x50 BgmSettings                 ( 0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.SeSettings                                = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x058), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 027003A7C1C0 0x58 SeSettings                  ( 0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.VoiceSettings                             = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x060), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 027003A7C1E0 0x60 VoiceSettings               ( 0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.IsTitleCall                               = GetBool(new IntPtr(p + 0x068)); // 027003A7C200 0x68 IsTitleCall                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
