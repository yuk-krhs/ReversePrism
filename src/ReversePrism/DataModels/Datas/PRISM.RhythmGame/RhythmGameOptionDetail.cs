using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  RhythmGameOptionDetail IL2CPP_TYPE_CLASS
    // 010 NoteDesignIndex                          ModelPrimitiveType int int int Int32
    // 014 NoteEffectDesignIndex                    ModelPrimitiveType int int int Int32
    // 018 ShowNoteEffect                           ModelPrimitiveType bool bool bool Bool
    // 019 ShowLifeGauge                            ModelPrimitiveType bool bool bool Bool
    // 01A ShowLifeWarning                          ModelPrimitiveType bool bool bool Bool
    // 01B ShowScoreGauge                           ModelPrimitiveType bool bool bool Bool
    // 01C ShowShinyEffect                          ModelPrimitiveType bool bool bool Bool
    // 020 ComboShowType                            ModelEnumType RhythmGameOptionComboShowType RhythmGameOptionComboShowType RhythmGameOptionComboShowType Int32
    // 024 ShowGreatComboEffect                     ModelPrimitiveType bool bool bool Bool
    // 025 ShowPerfectComboEffect                   ModelPrimitiveType bool bool bool Bool
    // 026 ShowShinyComboEffect                     ModelPrimitiveType bool bool bool Bool
    // 028 JudgementShowType                        ModelEnumType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType Int32
    // 02C JudgementShowPositionType                ModelEnumType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType Int32
    // 030 ShowJudgementLagType                     ModelEnumType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType Int32
    // 034 ShowPerfectJudgementLag                  ModelPrimitiveType bool bool bool Bool
    // 035 ShowSkillCutin                           ModelPrimitiveType bool bool bool Bool
    // 036 ShowSkillEffect                          ModelPrimitiveType bool bool bool Bool
    // 037 ShowKeyBeam                              ModelPrimitiveType bool bool bool Bool
    // 038 LaneCutRate                              ModelPrimitiveType float float float Single
    // 03C IsMirror                                 ModelPrimitiveType bool bool bool Bool
    public partial class RhythmGameOptionDetail : DataModel
    {
        public int                                      NoteDesignIndex                         { get; set; }
        public int                                      NoteEffectDesignIndex                   { get; set; }
        public bool                                     ShowNoteEffect                          { get; set; }
        public bool                                     ShowLifeGauge                           { get; set; }
        public bool                                     ShowLifeWarning                         { get; set; }
        public bool                                     ShowScoreGauge                          { get; set; }
        public bool                                     ShowShinyEffect                         { get; set; }
        public RhythmGameOptionComboShowType            ComboShowType                           { get; set; }
        public bool                                     ShowGreatComboEffect                    { get; set; }
        public bool                                     ShowPerfectComboEffect                  { get; set; }
        public bool                                     ShowShinyComboEffect                    { get; set; }
        public RhythmGameOptionJudgementShowType        JudgementShowType                       { get; set; }
        public RhythmGameOptionJudgementShowPositionType JudgementShowPositionType               { get; set; }
        public RhythmGameOptionJudgementShowJudgementLagType ShowJudgementLagType                    { get; set; }
        public bool                                     ShowPerfectJudgementLag                 { get; set; }
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
            var value   = new RhythmGameOptionDetail() { Pointer= p0 };

            value.NoteDesignIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 NoteDesignIndex             ( ModelPrimitiveType int int int Int32 )
            value.NoteEffectDesignIndex                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 NoteEffectDesignIndex       ( ModelPrimitiveType int int int Int32 )
            value.ShowNoteEffect                            = GetBool(new IntPtr(p + 0x018)); // 0x18 ShowNoteEffect              ( ModelPrimitiveType bool bool bool Bool )
            value.ShowLifeGauge                             = GetBool(new IntPtr(p + 0x019)); // 0x19 ShowLifeGauge               ( ModelPrimitiveType bool bool bool Bool )
            value.ShowLifeWarning                           = GetBool(new IntPtr(p + 0x01A)); // 0x1A ShowLifeWarning             ( ModelPrimitiveType bool bool bool Bool )
            value.ShowScoreGauge                            = GetBool(new IntPtr(p + 0x01B)); // 0x1B ShowScoreGauge              ( ModelPrimitiveType bool bool bool Bool )
            value.ShowShinyEffect                           = GetBool(new IntPtr(p + 0x01C)); // 0x1C ShowShinyEffect             ( ModelPrimitiveType bool bool bool Bool )
            value.ComboShowType                             = (RhythmGameOptionComboShowType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ComboShowType               ( ModelEnumType RhythmGameOptionComboShowType RhythmGameOptionComboShowType RhythmGameOptionComboShowType Int32 )
            value.ShowGreatComboEffect                      = GetBool(new IntPtr(p + 0x024)); // 0x24 ShowGreatComboEffect        ( ModelPrimitiveType bool bool bool Bool )
            value.ShowPerfectComboEffect                    = GetBool(new IntPtr(p + 0x025)); // 0x25 ShowPerfectComboEffect      ( ModelPrimitiveType bool bool bool Bool )
            value.ShowShinyComboEffect                      = GetBool(new IntPtr(p + 0x026)); // 0x26 ShowShinyComboEffect        ( ModelPrimitiveType bool bool bool Bool )
            value.JudgementShowType                         = (RhythmGameOptionJudgementShowType)GetInt32(new IntPtr(p + 0x028)); // 0x28 JudgementShowType           ( ModelEnumType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType RhythmGameOptionJudgementShowType Int32 )
            value.JudgementShowPositionType                 = (RhythmGameOptionJudgementShowPositionType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C JudgementShowPositionType   ( ModelEnumType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType RhythmGameOptionJudgementShowPositionType Int32 )
            value.ShowJudgementLagType                      = (RhythmGameOptionJudgementShowJudgementLagType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ShowJudgementLagType        ( ModelEnumType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType RhythmGameOptionJudgementShowJudgementLagType Int32 )
            value.ShowPerfectJudgementLag                   = GetBool(new IntPtr(p + 0x034)); // 0x34 ShowPerfectJudgementLag     ( ModelPrimitiveType bool bool bool Bool )
            value.ShowSkillCutin                            = GetBool(new IntPtr(p + 0x035)); // 0x35 ShowSkillCutin              ( ModelPrimitiveType bool bool bool Bool )
            value.ShowSkillEffect                           = GetBool(new IntPtr(p + 0x036)); // 0x36 ShowSkillEffect             ( ModelPrimitiveType bool bool bool Bool )
            value.ShowKeyBeam                               = GetBool(new IntPtr(p + 0x037)); // 0x37 ShowKeyBeam                 ( ModelPrimitiveType bool bool bool Bool )
            value.LaneCutRate                               = GetSingle(new IntPtr(p + 0x038)); // 0x38 LaneCutRate                 ( ModelPrimitiveType float float float Single )
            value.IsMirror                                  = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsMirror                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
