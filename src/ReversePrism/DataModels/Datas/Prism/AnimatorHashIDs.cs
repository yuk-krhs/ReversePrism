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
    public partial class AnimatorHashIDs : DataModel
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
            var value   = new AnimatorHashIDs() { Pointer= p0 };

            value.Start                                     = GetInt32(new IntPtr(p + 0x09C)); // 0245A5F67588 0x9C Start                       ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Skill_on                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A5F67148 0x14 Skill_on                    ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Skill_off                                 = GetInt32(new IntPtr(p + 0x018)); // 0245A5F67168 0x18 Skill_off                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SpaceKeepOff                              = GetInt32(new IntPtr(p + 0x01C)); // 0245A5F67188 0x1C SpaceKeepOff                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Draw                                      = GetInt32(new IntPtr(p + 0x020)); // 0245A5F671A8 0x20 Draw                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.UseOn                                     = GetInt32(new IntPtr(p + 0x024)); // 0245A5F671C8 0x24 UseOn                       ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.UseOff                                    = GetInt32(new IntPtr(p + 0x028)); // 0245A5F671E8 0x28 UseOff                      ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.R                                         = GetInt32(new IntPtr(p + 0x02C)); // 0245A5F67208 0x2C R                           ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SR                                        = GetInt32(new IntPtr(p + 0x030)); // 0245A5F67228 0x30 SR                          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SSR                                       = GetInt32(new IntPtr(p + 0x034)); // 0245A5F67248 0x34 SSR                         ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ShakeOff                                  = GetInt32(new IntPtr(p + 0x038)); // 0245A5F67268 0x38 ShakeOff                    ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_up                                   = GetInt32(new IntPtr(p + 0x03C)); // 0245A5F67288 0x3C Rate_up                     ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_stay                                 = GetInt32(new IntPtr(p + 0x040)); // 0245A5F672A8 0x40 Rate_stay                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_up_loop                              = GetInt32(new IntPtr(p + 0x044)); // 0245A5F672C8 0x44 Rate_up_loop                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Rate_stay_loop                            = GetInt32(new IntPtr(p + 0x048)); // 0245A5F672E8 0x48 Rate_stay_loop              ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.On                                        = GetInt32(new IntPtr(p + 0x04C)); // 0245A5F67308 0x4C On                          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.None                                      = GetInt32(new IntPtr(p + 0x050)); // 0245A5F67328 0x50 None                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Loop                                      = GetInt32(new IntPtr(p + 0x054)); // 0245A5F67348 0x54 Loop                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Stamp                                     = GetInt32(new IntPtr(p + 0x058)); // 0245A5F67368 0x58 Stamp                       ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x05C)); // 0245A5F67388 0x5C Star                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Idle                                      = GetInt32(new IntPtr(p + 0x060)); // 0245A5F673A8 0x60 Idle                        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Player_to_player                          = GetInt32(new IntPtr(p + 0x064)); // 0245A5F673C8 0x64 Player_to_player            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Player_to_enemy                           = GetInt32(new IntPtr(p + 0x068)); // 0245A5F673E8 0x68 Player_to_enemy             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.FanAreaOn                                 = GetInt32(new IntPtr(p + 0x06C)); // 0245A5F67408 0x6C FanAreaOn                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ParameterAreaOn                           = GetInt32(new IntPtr(p + 0x070)); // 0245A5F67428 0x70 ParameterAreaOn             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.SlideOn                                   = GetInt32(new IntPtr(p + 0x074)); // 0245A5F67448 0x74 SlideOn                     ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Count_up                                  = GetInt32(new IntPtr(p + 0x078)); // 0245A5F67468 0x78 Count_up                    ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Exclusion                                 = GetInt32(new IntPtr(p + 0x07C)); // 0245A5F67488 0x7C Exclusion                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.CounterEffectOn                           = GetInt32(new IntPtr(p + 0x080)); // 0245A5F674A8 0x80 CounterEffectOn             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.AnimStart                                 = GetInt32(new IntPtr(p + 0x084)); // 0245A5F674C8 0x84 AnimStart                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.AnimStart2                                = GetInt32(new IntPtr(p + 0x088)); // 0245A5F674E8 0x88 AnimStart2                  ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ResultValue                               = GetInt32(new IntPtr(p + 0x08C)); // 0245A5F67508 0x8C ResultValue                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CountTrigger                              = GetInt32(new IntPtr(p + 0x090)); // 0245A5F67528 0x90 CountTrigger                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CountNum                                  = GetInt32(new IntPtr(p + 0x094)); // 0245A5F67548 0x94 CountNum                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Other                                     = GetInt32(new IntPtr(p + 0x098)); // 0245A5F67568 0x98 Other                       ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CutInType                                 = GetInt32(new IntPtr(p + 0x0A0)); // 0245A5F675A8 0xA0 CutInType                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Reload                                    = GetInt32(new IntPtr(p + 0x0A4)); // 0245A5F675C8 0xA4 Reload                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ReloadEnd                                 = GetInt32(new IntPtr(p + 0x0A8)); // 0245A5F675E8 0xA8 ReloadEnd                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_A                                   = GetInt32(new IntPtr(p + 0x0AC)); // 0245A5F67608 0xAC Mouth_A                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_I                                   = GetInt32(new IntPtr(p + 0x0B0)); // 0245A5F67628 0xB0 Mouth_I                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_U                                   = GetInt32(new IntPtr(p + 0x0B4)); // 0245A5F67648 0xB4 Mouth_U                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_E                                   = GetInt32(new IntPtr(p + 0x0B8)); // 0245A5F67668 0xB8 Mouth_E                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_O                                   = GetInt32(new IntPtr(p + 0x0BC)); // 0245A5F67688 0xBC Mouth_O                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_SA                                  = GetInt32(new IntPtr(p + 0x0C0)); // 0245A5F676A8 0xC0 Mouth_SA                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_SI                                  = GetInt32(new IntPtr(p + 0x0C4)); // 0245A5F676C8 0xC4 Mouth_SI                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_SE                                  = GetInt32(new IntPtr(p + 0x0C8)); // 0245A5F676E8 0xC8 Mouth_SE                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthSerious                              = GetInt32(new IntPtr(p + 0x0CC)); // 0245A5F67708 0xCC MouthSerious                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthSurprise                             = GetInt32(new IntPtr(p + 0x0D0)); // 0245A5F67728 0xD0 MouthSurprise               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthShy                                  = GetInt32(new IntPtr(p + 0x0D4)); // 0245A5F67748 0xD4 MouthShy                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.MouthAnger                                = GetInt32(new IntPtr(p + 0x0D8)); // 0245A5F67768 0xD8 MouthAnger                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeLClose                                 = GetInt32(new IntPtr(p + 0x0DC)); // 0245A5F67788 0xDC EyeLClose                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeRClose                                 = GetInt32(new IntPtr(p + 0x0E0)); // 0245A5F677A8 0xE0 EyeRClose                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeLSmile                                 = GetInt32(new IntPtr(p + 0x0E4)); // 0245A5F677C8 0xE4 EyeLSmile                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeRSmile                                 = GetInt32(new IntPtr(p + 0x0E8)); // 0245A5F677E8 0xE8 EyeRSmile                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowSerious                            = GetInt32(new IntPtr(p + 0x0EC)); // 0245A5F67808 0xEC EyeBrowSerious              ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowSad                                = GetInt32(new IntPtr(p + 0x0F0)); // 0245A5F67828 0xF0 EyeBrowSad                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowUnique                             = GetInt32(new IntPtr(p + 0x0F4)); // 0245A5F67848 0xF4 EyeBrowUnique               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowUp                                 = GetInt32(new IntPtr(p + 0x0F8)); // 0245A5F67868 0xF8 EyeBrowUp                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.EyeBrowDown                               = GetInt32(new IntPtr(p + 0x0FC)); // 0245A5F67888 0xFC EyeBrowDown                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.LipSyncRate                               = GetInt32(new IntPtr(p + 0x100)); // 0245A5F678A8 0x100 LipSyncRate                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.FaceExtend                                = GetInt32(new IntPtr(p + 0x104)); // 0245A5F678C8 0x104 FaceExtend                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.FaceFlatten                               = GetInt32(new IntPtr(p + 0x108)); // 0245A5F678E8 0x108 FaceFlatten                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mouth_Tongue                              = GetInt32(new IntPtr(p + 0x10C)); // 0245A5F67908 0x10C Mouth_Tongue                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
