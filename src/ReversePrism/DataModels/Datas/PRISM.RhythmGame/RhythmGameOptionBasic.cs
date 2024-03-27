using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  RhythmGameOptionBasic IL2CPP_TYPE_CLASS
    // 010 HighSpeed                                000186666050 ModelPrimitiveType float float float Single
    // 014 NoteOffset                               000186666050 ModelPrimitiveType float float float Single
    // 018 NoteDrawOffset                           000186666050 ModelPrimitiveType float float float Single
    // 01C BackgroundBrightness                     000186666050 ModelPrimitiveType float float float Single
    // 020 LaneAlpha                                000186666050 ModelPrimitiveType float float float Single
    // 024 ShowSimultaneousLine                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 025 UseVibration                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 BackgroundMode                           00018653FB60 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 02C MVEffectLevel                            000186683990 ModelEnumType RhythmGameMVEffectLevel RhythmGameMVEffectLevel RhythmGameMVEffectLevel Int32
    // 030 RenderSeconds                            0001866656B0 ModelPrimitiveType float float float Single
    // 034 CurrentRenderSecondsHighSpeed            0001866656B0 ModelPrimitiveType float float float Single
    public partial class RhythmGameOptionBasic
    {
        public float                                    HighSpeed                               { get; set; }
        public float                                    NoteOffset                              { get; set; }
        public float                                    NoteDrawOffset                          { get; set; }
        public float                                    BackgroundBrightness                    { get; set; }
        public float                                    LaneAlpha                               { get; set; }
        public bool                                     ShowSimultaneousLine                    { get; set; }
        public bool                                     UseVibration                            { get; set; }
        public LiveBackgroundMode                       BackgroundMode                          { get; set; }
        public RhythmGameMVEffectLevel                  MVEffectLevel                           { get; set; }
        public float                                    RenderSeconds                           { get; set; }
        public float                                    CurrentRenderSecondsHighSpeed           { get; set; }

        public static RhythmGameOptionBasic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameOptionBasic();

            value.HighSpeed                                 = GetSingle(new IntPtr(p + 0x010)); // 027003A802B8 0x10 HighSpeed                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.NoteOffset                                = GetSingle(new IntPtr(p + 0x014)); // 027003A802D8 0x14 NoteOffset                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.NoteDrawOffset                            = GetSingle(new IntPtr(p + 0x018)); // 027003A802F8 0x18 NoteDrawOffset              ( 000186666050 ModelPrimitiveType float float float Single )
            value.BackgroundBrightness                      = GetSingle(new IntPtr(p + 0x01C)); // 027003A80318 0x1C BackgroundBrightness        ( 000186666050 ModelPrimitiveType float float float Single )
            value.LaneAlpha                                 = GetSingle(new IntPtr(p + 0x020)); // 027003A80338 0x20 LaneAlpha                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.ShowSimultaneousLine                      = GetBool(new IntPtr(p + 0x024)); // 027003A80358 0x24 ShowSimultaneousLine        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseVibration                              = GetBool(new IntPtr(p + 0x025)); // 027003A80378 0x25 UseVibration                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x028)); // 027003A80398 0x28 BackgroundMode              ( 00018653FB60 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )
            value.MVEffectLevel                             = (RhythmGameMVEffectLevel)GetInt32(new IntPtr(p + 0x02C)); // 027003A803B8 0x2C MVEffectLevel               ( 000186683990 ModelEnumType RhythmGameMVEffectLevel RhythmGameMVEffectLevel RhythmGameMVEffectLevel Int32 )
            value.RenderSeconds                             = GetSingle(new IntPtr(p + 0x030)); // 027003A803D8 0x30 RenderSeconds               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentRenderSecondsHighSpeed             = GetSingle(new IntPtr(p + 0x034)); // 027003A803F8 0x34 CurrentRenderSecondsHighSpeed ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
