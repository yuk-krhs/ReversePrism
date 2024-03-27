using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ResultOn                                 int IL2CPP_TYPE_I4
    // 004 ResultSkip                               int IL2CPP_TYPE_I4
    // 008 TipsOn                                   int IL2CPP_TYPE_I4
    // 00C AppealOn                                 int IL2CPP_TYPE_I4
    // 010 Start                                    0001865F4040 ModelPrimitiveType int int int Int32
    // 014 Skill_on                                 0001865F4040 ModelPrimitiveType int int int Int32
    // 018 Skill_off                                0001865F4040 ModelPrimitiveType int int int Int32
    // 01C SpaceKeepOff                             0001865F4040 ModelPrimitiveType int int int Int32
    // 020 Draw                                     0001865F4040 ModelPrimitiveType int int int Int32
    // 024 UseOn                                    0001865F4040 ModelPrimitiveType int int int Int32
    // 028 UseOff                                   0001865F4040 ModelPrimitiveType int int int Int32
    // 02C R                                        0001865F4040 ModelPrimitiveType int int int Int32
    // 030 SR                                       0001865F4040 ModelPrimitiveType int int int Int32
    // 034 SSR                                      0001865F4040 ModelPrimitiveType int int int Int32
    // 038 ShakeOff                                 0001865F4040 ModelPrimitiveType int int int Int32
    // 03C Rate_up                                  0001865F4040 ModelPrimitiveType int int int Int32
    // 040 Rate_stay                                0001865F4040 ModelPrimitiveType int int int Int32
    // 044 Rate_up_loop                             0001865F4040 ModelPrimitiveType int int int Int32
    // 048 Rate_stay_loop                           0001865F4040 ModelPrimitiveType int int int Int32
    // 04C On                                       0001865F4040 ModelPrimitiveType int int int Int32
    // 050 None                                     0001865F4040 ModelPrimitiveType int int int Int32
    // 054 Loop                                     0001865F4040 ModelPrimitiveType int int int Int32
    // 058 Stamp                                    0001865F4040 ModelPrimitiveType int int int Int32
    // 05C Star                                     0001865F4040 ModelPrimitiveType int int int Int32
    // 060 Idle                                     0001865F4040 ModelPrimitiveType int int int Int32
    // 064 Player_to_player                         0001865F4040 ModelPrimitiveType int int int Int32
    // 068 Player_to_enemy                          0001865F4040 ModelPrimitiveType int int int Int32
    // 06C FanAreaOn                                0001865F4040 ModelPrimitiveType int int int Int32
    // 070 ParameterAreaOn                          0001865F4040 ModelPrimitiveType int int int Int32
    // 074 SlideOn                                  0001865F4040 ModelPrimitiveType int int int Int32
    // 078 Count_up                                 0001865F4040 ModelPrimitiveType int int int Int32
    // 07C Exclusion                                0001865F4040 ModelPrimitiveType int int int Int32
    // 080 CounterEffectOn                          0001865F4040 ModelPrimitiveType int int int Int32
    // 084 AnimStart                                0001865F4040 ModelPrimitiveType int int int Int32
    // 088 AnimStart2                               0001865F4040 ModelPrimitiveType int int int Int32
    // 08C ResultValue                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 090 CountTrigger                             0001865F50A0 ModelPrimitiveType int int int Int32
    // 094 CountNum                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 098 Other                                    0001865F50A0 ModelPrimitiveType int int int Int32
    // 09C Start                                    0001865F50A0 ModelPrimitiveType int int int Int32
    // 0A0 CutInType                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0A4 Reload                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 0A8 ReloadEnd                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0AC Mouth_A                                  0001865F50A0 ModelPrimitiveType int int int Int32
    // 0B0 Mouth_I                                  0001865F50A0 ModelPrimitiveType int int int Int32
    // 0B4 Mouth_U                                  0001865F50A0 ModelPrimitiveType int int int Int32
    // 0B8 Mouth_E                                  0001865F50A0 ModelPrimitiveType int int int Int32
    // 0BC Mouth_O                                  0001865F50A0 ModelPrimitiveType int int int Int32
    // 0C0 Mouth_SA                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 0C4 Mouth_SI                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 0C8 Mouth_SE                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 0CC MouthSerious                             0001865F50A0 ModelPrimitiveType int int int Int32
    // 0D0 MouthSurprise                            0001865F50A0 ModelPrimitiveType int int int Int32
    // 0D4 MouthShy                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 0D8 MouthAnger                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 0DC EyeLClose                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0E0 EyeRClose                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0E4 EyeLSmile                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0E8 EyeRSmile                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0EC EyeBrowSerious                           0001865F50A0 ModelPrimitiveType int int int Int32
    // 0F0 EyeBrowSad                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 0F4 EyeBrowUnique                            0001865F50A0 ModelPrimitiveType int int int Int32
    // 0F8 EyeBrowUp                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0FC EyeBrowDown                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 100 LipSyncRate                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 104 FaceExtend                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 108 FaceFlatten                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 10C Mouth_Tongue                             0001865F50A0 ModelPrimitiveType int int int Int32
    public partial class AnimatorHashIDs
    {
        public int                                      Start                                   { get; set; }
        public int                                      Skill_on                                { get; set; }
        public int                                      Skill_off                               { get; set; }
        public int                                      SpaceKeepOff                            { get; set; }
        public int                                      Draw                                    { get; set; }
        public int                                      UseOn                                   { get; set; }
        public int                                      UseOff                                  { get; set; }
        public int                                      R                                       { get; set; }
        public int                                      SR                                      { get; set; }
        public int                                      SSR                                     { get; set; }
        public int                                      ShakeOff                                { get; set; }
        public int                                      Rate_up                                 { get; set; }
        public int                                      Rate_stay                               { get; set; }
        public int                                      Rate_up_loop                            { get; set; }
        public int                                      Rate_stay_loop                          { get; set; }
        public int                                      On                                      { get; set; }
        public int                                      None                                    { get; set; }
        public int                                      Loop                                    { get; set; }
        public int                                      Stamp                                   { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      Idle                                    { get; set; }
        public int                                      Player_to_player                        { get; set; }
        public int                                      Player_to_enemy                         { get; set; }
        public int                                      FanAreaOn                               { get; set; }
        public int                                      ParameterAreaOn                         { get; set; }
        public int                                      SlideOn                                 { get; set; }
        public int                                      Count_up                                { get; set; }
        public int                                      Exclusion                               { get; set; }
        public int                                      CounterEffectOn                         { get; set; }
        public int                                      AnimStart                               { get; set; }
        public int                                      AnimStart2                              { get; set; }
        public int                                      ResultValue                             { get; set; }
        public int                                      CountTrigger                            { get; set; }
        public int                                      CountNum                                { get; set; }
        public int                                      Other                                   { get; set; }
        public int                                      CutInType                               { get; set; }
        public int                                      Reload                                  { get; set; }
        public int                                      ReloadEnd                               { get; set; }
        public int                                      Mouth_A                                 { get; set; }
        public int                                      Mouth_I                                 { get; set; }
        public int                                      Mouth_U                                 { get; set; }
        public int                                      Mouth_E                                 { get; set; }
        public int                                      Mouth_O                                 { get; set; }
        public int                                      Mouth_SA                                { get; set; }
        public int                                      Mouth_SI                                { get; set; }
        public int                                      Mouth_SE                                { get; set; }
        public int                                      MouthSerious                            { get; set; }
        public int                                      MouthSurprise                           { get; set; }
        public int                                      MouthShy                                { get; set; }
        public int                                      MouthAnger                              { get; set; }
        public int                                      EyeLClose                               { get; set; }
        public int                                      EyeRClose                               { get; set; }
        public int                                      EyeLSmile                               { get; set; }
        public int                                      EyeRSmile                               { get; set; }
        public int                                      EyeBrowSerious                          { get; set; }
        public int                                      EyeBrowSad                              { get; set; }
        public int                                      EyeBrowUnique                           { get; set; }
        public int                                      EyeBrowUp                               { get; set; }
        public int                                      EyeBrowDown                             { get; set; }
        public int                                      LipSyncRate                             { get; set; }
        public int                                      FaceExtend                              { get; set; }
        public int                                      FaceFlatten                             { get; set; }
        public int                                      Mouth_Tongue                            { get; set; }

        public static AnimatorHashIDs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorHashIDs();

            value.Start                                     = GetInt32(new IntPtr(p + 0x09C)); // 027005F8BEC8 0x9C Start                       ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Skill_on                                  = GetInt32(new IntPtr(p + 0x014)); // 027005F8BA88 0x14 Skill_on                    ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Skill_off                                 = GetInt32(new IntPtr(p + 0x018)); // 027005F8BAA8 0x18 Skill_off                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SpaceKeepOff                              = GetInt32(new IntPtr(p + 0x01C)); // 027005F8BAC8 0x1C SpaceKeepOff                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Draw                                      = GetInt32(new IntPtr(p + 0x020)); // 027005F8BAE8 0x20 Draw                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.UseOn                                     = GetInt32(new IntPtr(p + 0x024)); // 027005F8BB08 0x24 UseOn                       ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.UseOff                                    = GetInt32(new IntPtr(p + 0x028)); // 027005F8BB28 0x28 UseOff                      ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.R                                         = GetInt32(new IntPtr(p + 0x02C)); // 027005F8BB48 0x2C R                           ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SR                                        = GetInt32(new IntPtr(p + 0x030)); // 027005F8BB68 0x30 SR                          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SSR                                       = GetInt32(new IntPtr(p + 0x034)); // 027005F8BB88 0x34 SSR                         ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ShakeOff                                  = GetInt32(new IntPtr(p + 0x038)); // 027005F8BBA8 0x38 ShakeOff                    ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_up                                   = GetInt32(new IntPtr(p + 0x03C)); // 027005F8BBC8 0x3C Rate_up                     ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_stay                                 = GetInt32(new IntPtr(p + 0x040)); // 027005F8BBE8 0x40 Rate_stay                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_up_loop                              = GetInt32(new IntPtr(p + 0x044)); // 027005F8BC08 0x44 Rate_up_loop                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_stay_loop                            = GetInt32(new IntPtr(p + 0x048)); // 027005F8BC28 0x48 Rate_stay_loop              ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.On                                        = GetInt32(new IntPtr(p + 0x04C)); // 027005F8BC48 0x4C On                          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.None                                      = GetInt32(new IntPtr(p + 0x050)); // 027005F8BC68 0x50 None                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Loop                                      = GetInt32(new IntPtr(p + 0x054)); // 027005F8BC88 0x54 Loop                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Stamp                                     = GetInt32(new IntPtr(p + 0x058)); // 027005F8BCA8 0x58 Stamp                       ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x05C)); // 027005F8BCC8 0x5C Star                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Idle                                      = GetInt32(new IntPtr(p + 0x060)); // 027005F8BCE8 0x60 Idle                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Player_to_player                          = GetInt32(new IntPtr(p + 0x064)); // 027005F8BD08 0x64 Player_to_player            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Player_to_enemy                           = GetInt32(new IntPtr(p + 0x068)); // 027005F8BD28 0x68 Player_to_enemy             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.FanAreaOn                                 = GetInt32(new IntPtr(p + 0x06C)); // 027005F8BD48 0x6C FanAreaOn                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ParameterAreaOn                           = GetInt32(new IntPtr(p + 0x070)); // 027005F8BD68 0x70 ParameterAreaOn             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SlideOn                                   = GetInt32(new IntPtr(p + 0x074)); // 027005F8BD88 0x74 SlideOn                     ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Count_up                                  = GetInt32(new IntPtr(p + 0x078)); // 027005F8BDA8 0x78 Count_up                    ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Exclusion                                 = GetInt32(new IntPtr(p + 0x07C)); // 027005F8BDC8 0x7C Exclusion                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.CounterEffectOn                           = GetInt32(new IntPtr(p + 0x080)); // 027005F8BDE8 0x80 CounterEffectOn             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.AnimStart                                 = GetInt32(new IntPtr(p + 0x084)); // 027005F8BE08 0x84 AnimStart                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.AnimStart2                                = GetInt32(new IntPtr(p + 0x088)); // 027005F8BE28 0x88 AnimStart2                  ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ResultValue                               = GetInt32(new IntPtr(p + 0x08C)); // 027005F8BE48 0x8C ResultValue                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CountTrigger                              = GetInt32(new IntPtr(p + 0x090)); // 027005F8BE68 0x90 CountTrigger                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CountNum                                  = GetInt32(new IntPtr(p + 0x094)); // 027005F8BE88 0x94 CountNum                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Other                                     = GetInt32(new IntPtr(p + 0x098)); // 027005F8BEA8 0x98 Other                       ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CutInType                                 = GetInt32(new IntPtr(p + 0x0A0)); // 027005F8BEE8 0xA0 CutInType                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Reload                                    = GetInt32(new IntPtr(p + 0x0A4)); // 027005F8BF08 0xA4 Reload                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ReloadEnd                                 = GetInt32(new IntPtr(p + 0x0A8)); // 027005F8BF28 0xA8 ReloadEnd                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_A                                   = GetInt32(new IntPtr(p + 0x0AC)); // 027005F8BF48 0xAC Mouth_A                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_I                                   = GetInt32(new IntPtr(p + 0x0B0)); // 027005F8BF68 0xB0 Mouth_I                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_U                                   = GetInt32(new IntPtr(p + 0x0B4)); // 027005F8BF88 0xB4 Mouth_U                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_E                                   = GetInt32(new IntPtr(p + 0x0B8)); // 027005F8BFA8 0xB8 Mouth_E                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_O                                   = GetInt32(new IntPtr(p + 0x0BC)); // 027005F8BFC8 0xBC Mouth_O                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_SA                                  = GetInt32(new IntPtr(p + 0x0C0)); // 027005F8BFE8 0xC0 Mouth_SA                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_SI                                  = GetInt32(new IntPtr(p + 0x0C4)); // 027005F8C008 0xC4 Mouth_SI                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_SE                                  = GetInt32(new IntPtr(p + 0x0C8)); // 027005F8C028 0xC8 Mouth_SE                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthSerious                              = GetInt32(new IntPtr(p + 0x0CC)); // 027005F8C048 0xCC MouthSerious                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthSurprise                             = GetInt32(new IntPtr(p + 0x0D0)); // 027005F8C068 0xD0 MouthSurprise               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthShy                                  = GetInt32(new IntPtr(p + 0x0D4)); // 027005F8C088 0xD4 MouthShy                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthAnger                                = GetInt32(new IntPtr(p + 0x0D8)); // 027005F8C0A8 0xD8 MouthAnger                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeLClose                                 = GetInt32(new IntPtr(p + 0x0DC)); // 027005F8C0C8 0xDC EyeLClose                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeRClose                                 = GetInt32(new IntPtr(p + 0x0E0)); // 027005F8C0E8 0xE0 EyeRClose                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeLSmile                                 = GetInt32(new IntPtr(p + 0x0E4)); // 027005F8C108 0xE4 EyeLSmile                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeRSmile                                 = GetInt32(new IntPtr(p + 0x0E8)); // 027005F8C128 0xE8 EyeRSmile                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowSerious                            = GetInt32(new IntPtr(p + 0x0EC)); // 027005F8C148 0xEC EyeBrowSerious              ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowSad                                = GetInt32(new IntPtr(p + 0x0F0)); // 027005F8C168 0xF0 EyeBrowSad                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowUnique                             = GetInt32(new IntPtr(p + 0x0F4)); // 027005F8C188 0xF4 EyeBrowUnique               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowUp                                 = GetInt32(new IntPtr(p + 0x0F8)); // 027005F8C1A8 0xF8 EyeBrowUp                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowDown                               = GetInt32(new IntPtr(p + 0x0FC)); // 027005F8C1C8 0xFC EyeBrowDown                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.LipSyncRate                               = GetInt32(new IntPtr(p + 0x100)); // 027005F8C1E8 0x100 LipSyncRate                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.FaceExtend                                = GetInt32(new IntPtr(p + 0x104)); // 027005F8C208 0x104 FaceExtend                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.FaceFlatten                               = GetInt32(new IntPtr(p + 0x108)); // 027005F8C228 0x108 FaceFlatten                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_Tongue                              = GetInt32(new IntPtr(p + 0x10C)); // 027005F8C248 0x10C Mouth_Tongue                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
