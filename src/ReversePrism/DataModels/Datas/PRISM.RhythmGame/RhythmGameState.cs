using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveStartData                            ModelClassType LiveStartData LiveStartData LiveStartData Pointer
    // 018 NotJudgedTapNotes                        ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer
    // 020 NotJudgedHoldNotes                       ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer
    // 028 NotJudgedFlickNotes                      ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer
    // 030 JudgmentResults                          ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer
    // 038 SkillBoostedJudgmentResults              ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer
    // 040 ReverseSortedNotes                       EnumerateOnlyList`1<NoteState> IL2CPP_TYPE_GENERICINST
    // 048 NoteLines                                EnumerateOnlyList`1<NoteLineState> IL2CPP_TYPE_GENERICINST
    // 050 SimultaneousLines                        ModelEnumListType List`1<SimultaneousLineState> List`1<SimultaneousLineState> List<SimultaneousLineState> Pointer
    // 058 NoteTimeManager                          ModelClassType NoteTimeManager NoteTimeManager NoteTimeManager Pointer
    // 060 NoteLineGroups                           Dictionary`2<NoteLineState, NoteLineGroup> IL2CPP_TYPE_GENERICINST
    // 068 CurrentCombo                             ModelPrimitiveType int int int Int32
    // 06C MaxCombo                                 ModelPrimitiveType int int int Int32
    // 070 SkillBoostedToPerfectCount               ModelPrimitiveType int int int Int32
    // 074 SkillBoostedToGreatCount                 ModelPrimitiveType int int int Int32
    // 078 CurrentScore                             ModelPrimitiveType int int int Int32
    // 07C CurrentLife                              ModelPrimitiveType int int int Int32
    // 080 LiveSkillIndex                           ModelPrimitiveType int int int Int32
    // 084 NoteCount                                ModelPrimitiveType int int int Int32
    public partial class RhythmGameState : DataModel
    {
        public LiveStartData?                           LiveStartData                           { get; set; }
        public List<NoteState>?                         NotJudgedTapNotes                       { get; set; }
        public List<NoteState>?                         NotJudgedHoldNotes                      { get; set; }
        public List<NoteState>?                         NotJudgedFlickNotes                     { get; set; }
        public JudgmentResultList?                      JudgmentResults                         { get; set; }
        public JudgmentResultList?                      SkillBoostedJudgmentResults             { get; set; }
        public List<SimultaneousLineState>?             SimultaneousLines                       { get; set; }
        public NoteTimeManager?                         NoteTimeManager                         { get; set; }
        public int                                      CurrentCombo                            { get; set; }
        public int                                      MaxCombo                                { get; set; }
        public int                                      SkillBoostedToPerfectCount              { get; set; }
        public int                                      SkillBoostedToGreatCount                { get; set; }
        public int                                      CurrentScore                            { get; set; }
        public int                                      CurrentLife                             { get; set; }
        public int                                      LiveSkillIndex                          { get; set; }
        public int                                      NoteCount                               { get; set; }

        public static RhythmGameState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameState() { Pointer= p0 };

            value.LiveStartData                             = GetObject<LiveStartData>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveStartData.FromPointer); // 0x10 LiveStartData               ( ModelClassType LiveStartData LiveStartData LiveStartData Pointer )
            value.NotJudgedTapNotes                         = GetObjectList<NoteState>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteState.FromPointer); // 0x18 NotJudgedTapNotes           ( ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer )
            value.NotJudgedHoldNotes                        = GetObjectList<NoteState>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteState.FromPointer); // 0x20 NotJudgedHoldNotes          ( ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer )
            value.NotJudgedFlickNotes                       = GetObjectList<NoteState>(new IntPtr(p + 0x028), ReversePrism.DataModels.NoteState.FromPointer); // 0x28 NotJudgedFlickNotes         ( ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer )
            value.JudgmentResults                           = GetObject<JudgmentResultList>(new IntPtr(p + 0x030), ReversePrism.DataModels.JudgmentResultList.FromPointer); // 0x30 JudgmentResults             ( ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer )
            value.SkillBoostedJudgmentResults               = GetObject<JudgmentResultList>(new IntPtr(p + 0x038), ReversePrism.DataModels.JudgmentResultList.FromPointer); // 0x38 SkillBoostedJudgmentResults ( ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer )
            value.SimultaneousLines                         = GetEnumList<SimultaneousLineState>(new IntPtr(p + 0x050)); // 0x50 SimultaneousLines           ( ModelEnumListType List`1<SimultaneousLineState> List`1<SimultaneousLineState> List<SimultaneousLineState> Pointer )
            value.NoteTimeManager                           = GetObject<NoteTimeManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.NoteTimeManager.FromPointer); // 0x58 NoteTimeManager             ( ModelClassType NoteTimeManager NoteTimeManager NoteTimeManager Pointer )
            value.CurrentCombo                              = GetInt32(new IntPtr(p + 0x068)); // 0x68 CurrentCombo                ( ModelPrimitiveType int int int Int32 )
            value.MaxCombo                                  = GetInt32(new IntPtr(p + 0x06C)); // 0x6C MaxCombo                    ( ModelPrimitiveType int int int Int32 )
            value.SkillBoostedToPerfectCount                = GetInt32(new IntPtr(p + 0x070)); // 0x70 SkillBoostedToPerfectCount  ( ModelPrimitiveType int int int Int32 )
            value.SkillBoostedToGreatCount                  = GetInt32(new IntPtr(p + 0x074)); // 0x74 SkillBoostedToGreatCount    ( ModelPrimitiveType int int int Int32 )
            value.CurrentScore                              = GetInt32(new IntPtr(p + 0x078)); // 0x78 CurrentScore                ( ModelPrimitiveType int int int Int32 )
            value.CurrentLife                               = GetInt32(new IntPtr(p + 0x07C)); // 0x7C CurrentLife                 ( ModelPrimitiveType int int int Int32 )
            value.LiveSkillIndex                            = GetInt32(new IntPtr(p + 0x080)); // 0x80 LiveSkillIndex              ( ModelPrimitiveType int int int Int32 )
            value.NoteCount                                 = GetInt32(new IntPtr(p + 0x084)); // 0x84 NoteCount                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
