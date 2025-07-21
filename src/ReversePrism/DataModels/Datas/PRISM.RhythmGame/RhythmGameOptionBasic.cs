using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  RhythmGameOptionBasic IL2CPP_TYPE_CLASS
    // 010 HighSpeed                                ModelPrimitiveType float float float Single
    // 014 NoteOffset                               ModelPrimitiveType float float float Single
    // 018 NoteDrawOffset                           ModelPrimitiveType float float float Single
    // 01C BackgroundBrightness                     ModelPrimitiveType float float float Single
    // 020 LaneAlpha                                ModelPrimitiveType float float float Single
    // 024 ShowSimultaneousLine                     ModelPrimitiveType bool bool bool Bool
    // 025 UseVibration                             ModelPrimitiveType bool bool bool Bool
    // 028 BackgroundMode                           ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 02C MVEffectLevel                            ModelEnumType RhythmGameMVEffectLevel RhythmGameMVEffectLevel RhythmGameMVEffectLevel Int32
    // 030 RenderSeconds                            ModelPrimitiveType float float float Single
    // 034 CurrentRenderSecondsHighSpeed            ModelPrimitiveType float float float Single
    public partial class RhythmGameOptionBasic : DataModel
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
            var value   = new RhythmGameOptionBasic() { Pointer= p0 };

            value.HighSpeed                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 HighSpeed                   ( ModelPrimitiveType float float float Single )
            value.NoteOffset                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 NoteOffset                  ( ModelPrimitiveType float float float Single )
            value.NoteDrawOffset                            = GetSingle(new IntPtr(p + 0x018)); // 0x18 NoteDrawOffset              ( ModelPrimitiveType float float float Single )
            value.BackgroundBrightness                      = GetSingle(new IntPtr(p + 0x01C)); // 0x1C BackgroundBrightness        ( ModelPrimitiveType float float float Single )
            value.LaneAlpha                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 LaneAlpha                   ( ModelPrimitiveType float float float Single )
            value.ShowSimultaneousLine                      = GetBool(new IntPtr(p + 0x024)); // 0x24 ShowSimultaneousLine        ( ModelPrimitiveType bool bool bool Bool )
            value.UseVibration                              = GetBool(new IntPtr(p + 0x025)); // 0x25 UseVibration                ( ModelPrimitiveType bool bool bool Bool )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 BackgroundMode              ( ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )
            value.MVEffectLevel                             = (RhythmGameMVEffectLevel)GetInt32(new IntPtr(p + 0x02C)); // 0x2C MVEffectLevel               ( ModelEnumType RhythmGameMVEffectLevel RhythmGameMVEffectLevel RhythmGameMVEffectLevel Int32 )
            value.RenderSeconds                             = GetSingle(new IntPtr(p + 0x030)); // 0x30 RenderSeconds               ( ModelPrimitiveType float float float Single )
            value.CurrentRenderSecondsHighSpeed             = GetSingle(new IntPtr(p + 0x034)); // 0x34 CurrentRenderSecondsHighSpeed ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
