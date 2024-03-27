using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  RhythmGameOptionDetail IL2CPP_TYPE_CLASS
    // 010 NoteDesignIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 NoteEffectDesignIndex                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ShowNoteEffect                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 ShowLifeGauge                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 01A ShowLifeWarning                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 01B ShowScoreGauge                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C ComboShowType                            000186686D10 ModelEnumType RhythmGameOptionComboShowType RhythmGameOptionComboShowType RhythmGameOptionComboShowType Int32
    // 020 ShowPerfectComboEffect                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 JudgementShowType                        0001866889A0 ModelEnumType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType Int32
    // 028 JudgementShowPositionType                000186688240 ModelEnumType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType Int32
    // 02C ShowJudgementLagType                     000186687B90 ModelEnumType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType Int32
    // 030 ShowSkillCutin                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 ShowSkillEffect                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 032 ShowKeyBeam                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 034 LaneCutRate                              000186666050 ModelPrimitiveType float float float Single
    // 038 IsMirror                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameOptionDetail
    {
        public int                                      NoteDesignIndex                         { get; set; }
        public int                                      NoteEffectDesignIndex                   { get; set; }
        public bool                                     ShowNoteEffect                          { get; set; }
        public bool                                     ShowLifeGauge                           { get; set; }
        public bool                                     ShowLifeWarning                         { get; set; }
        public bool                                     ShowScoreGauge                          { get; set; }
        public RhythmGameOptionComboShowType            ComboShowType                           { get; set; }
        public bool                                     ShowPerfectComboEffect                  { get; set; }
        public RhythmGameOptionJudgementShowType        JudgementShowType                       { get; set; }
        public RhythmGameOptionJudgementShowPositionType JudgementShowPositionType               { get; set; }
        public RhythmGameOptionJudgementShowJudgementLagType ShowJudgementLagType                    { get; set; }
        public bool                                     ShowSkillCutin                          { get; set; }
        public bool                                     ShowSkillEffect                         { get; set; }
        public bool                                     ShowKeyBeam                             { get; set; }
        public float                                    LaneCutRate                             { get; set; }
        public bool                                     IsMirror                                { get; set; }

        public static RhythmGameOptionDetail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameOptionDetail();

            value.NoteDesignIndex                           = GetInt32(new IntPtr(p + 0x010)); // 027003A80648 0x10 NoteDesignIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NoteEffectDesignIndex                     = GetInt32(new IntPtr(p + 0x014)); // 027003A80668 0x14 NoteEffectDesignIndex       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ShowNoteEffect                            = GetBool(new IntPtr(p + 0x018)); // 027003A80688 0x18 ShowNoteEffect              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowLifeGauge                             = GetBool(new IntPtr(p + 0x019)); // 027003A806A8 0x19 ShowLifeGauge               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowLifeWarning                           = GetBool(new IntPtr(p + 0x01A)); // 027003A806C8 0x1A ShowLifeWarning             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowScoreGauge                            = GetBool(new IntPtr(p + 0x01B)); // 027003A806E8 0x1B ShowScoreGauge              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ComboShowType                             = (RhythmGameOptionComboShowType)GetInt32(new IntPtr(p + 0x01C)); // 027003A80708 0x1C ComboShowType               ( 000186686D10 ModelEnumType RhythmGameOptionComboShowType RhythmGameOptionComboShowType RhythmGameOptionComboShowType Int32 )
            value.ShowPerfectComboEffect                    = GetBool(new IntPtr(p + 0x020)); // 027003A80728 0x20 ShowPerfectComboEffect      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.JudgementShowType                         = (RhythmGameOptionJudgementShowType)GetInt32(new IntPtr(p + 0x024)); // 027003A80748 0x24 JudgementShowType           ( 0001866889A0 ModelEnumType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType Int32 )
            value.JudgementShowPositionType                 = (RhythmGameOptionJudgementShowPositionType)GetInt32(new IntPtr(p + 0x028)); // 027003A80768 0x28 JudgementShowPositionType   ( 000186688240 ModelEnumType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType Int32 )
            value.ShowJudgementLagType                      = (RhythmGameOptionJudgementShowJudgementLagType)GetInt32(new IntPtr(p + 0x02C)); // 027003A80788 0x2C ShowJudgementLagType        ( 000186687B90 ModelEnumType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType Int32 )
            value.ShowSkillCutin                            = GetBool(new IntPtr(p + 0x030)); // 027003A807A8 0x30 ShowSkillCutin              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowSkillEffect                           = GetBool(new IntPtr(p + 0x031)); // 027003A807C8 0x31 ShowSkillEffect             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShowKeyBeam                               = GetBool(new IntPtr(p + 0x032)); // 027003A807E8 0x32 ShowKeyBeam                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LaneCutRate                               = GetSingle(new IntPtr(p + 0x034)); // 027003A80808 0x34 LaneCutRate                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsMirror                                  = GetBool(new IntPtr(p + 0x038)); // 027003A80828 0x38 IsMirror                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
