using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  RhythmGameOptionSound IL2CPP_TYPE_CLASS
    // 010 Bgm                                      0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 018 SE                                       0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 020 Voice                                    0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer
    // 028 StartVoiceType                           000186689820 ModelEnumType RhythmGameOptionStartVoiceType RhythmGameOptionStartVoiceType RhythmGameOptionStartVoiceType Int32
    // 02C TapSEIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 FlickSEIndex                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class RhythmGameOptionSound
    {
        public EachSoundSettingsLocalSaveType?          Bgm                                     { get; set; }
        public EachSoundSettingsLocalSaveType?          SE                                      { get; set; }
        public EachSoundSettingsLocalSaveType?          Voice                                   { get; set; }
        public RhythmGameOptionStartVoiceType           StartVoiceType                          { get; set; }
        public int                                      TapSEIndex                              { get; set; }
        public int                                      FlickSEIndex                            { get; set; }

        public static RhythmGameOptionSound? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameOptionSound();

            value.Bgm                                       = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x010), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 027003A80AC0 0x10 Bgm                         ( 0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.SE                                        = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x018), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 027003A80AE0 0x18 SE                          ( 0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.Voice                                     = GetObject<EachSoundSettingsLocalSaveType>(new IntPtr(p + 0x020), ReversePrism.DataModels.EachSoundSettingsLocalSaveType.FromPointer); // 027003A80B00 0x20 Voice                       ( 0001867162C0 ModelClassType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType EachSoundSettingsLocalSaveType Pointer )
            value.StartVoiceType                            = (RhythmGameOptionStartVoiceType)GetInt32(new IntPtr(p + 0x028)); // 027003A80B20 0x28 StartVoiceType              ( 000186689820 ModelEnumType RhythmGameOptionStartVoiceType RhythmGameOptionStartVoiceType RhythmGameOptionStartVoiceType Int32 )
            value.TapSEIndex                                = GetInt32(new IntPtr(p + 0x02C)); // 027003A80B40 0x2C TapSEIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FlickSEIndex                              = GetInt32(new IntPtr(p + 0x030)); // 027003A80B60 0x30 FlickSEIndex                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
