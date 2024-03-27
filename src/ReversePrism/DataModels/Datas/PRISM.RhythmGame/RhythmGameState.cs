using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveStartData                            000186582060 ModelClassType LiveStartData LiveStartData LiveStartData Pointer
    // 018 NotJudgedTapNotes                        000185CF6588 ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer
    // 020 NotJudgedHoldNotes                       000185CF6588 ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer
    // 028 NotJudgedFlickNotes                      000185CF6588 ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer
    // 030 JudgmentResults                          000186768150 ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer
    // 038 SkillBoostedJudgmentResults              000186768150 ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer
    // 040 ReverseSortedNotes                       EnumerateOnlyList`1<NoteState> IL2CPP_TYPE_GENERICINST
    // 048 NoteLines                                EnumerateOnlyList`1<NoteLineState> IL2CPP_TYPE_GENERICINST
    // 050 SimultaneousLines                        000185D09F18 ModelEnumListType List`1<SimultaneousLineState> List`1<SimultaneousLineState> List<SimultaneousLineState> Pointer
    // 058 NoteTimeManager                          0001866B0320 ModelClassType NoteTimeManager NoteTimeManager NoteTimeManager Pointer
    // 060 NoteLineGroups                           Dictionary`2<NoteLineState, NoteLineGroup> IL2CPP_TYPE_GENERICINST
    // 068 CurrentCombo                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C MaxCombo                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 CurrentScore                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 CurrentLife                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 LiveSkillIndex                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 07C NoteCount                                0001865F4940 ModelPrimitiveType int int int Int32
    public partial class RhythmGameState
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
        public int                                      CurrentScore                            { get; set; }
        public int                                      CurrentLife                             { get; set; }
        public int                                      LiveSkillIndex                          { get; set; }
        public int                                      NoteCount                               { get; set; }

        public static RhythmGameState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameState();

            value.LiveStartData                             = GetObject<LiveStartData>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveStartData.FromPointer); // 0270D4F877D8 0x10 LiveStartData               ( 000186582060 ModelClassType LiveStartData LiveStartData LiveStartData Pointer )
            value.NotJudgedTapNotes                         = GetObjectList<NoteState>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteState.FromPointer); // 0270D4F877F8 0x18 NotJudgedTapNotes           ( 000185CF6588 ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer )
            value.NotJudgedHoldNotes                        = GetObjectList<NoteState>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteState.FromPointer); // 0270D4F87818 0x20 NotJudgedHoldNotes          ( 000185CF6588 ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer )
            value.NotJudgedFlickNotes                       = GetObjectList<NoteState>(new IntPtr(p + 0x028), ReversePrism.DataModels.NoteState.FromPointer); // 0270D4F87838 0x28 NotJudgedFlickNotes         ( 000185CF6588 ModelClassListType List`1<NoteState> List`1<NoteState> List<NoteState> Pointer )
            value.JudgmentResults                           = GetObject<JudgmentResultList>(new IntPtr(p + 0x030), ReversePrism.DataModels.JudgmentResultList.FromPointer); // 0270D4F87858 0x30 JudgmentResults             ( 000186768150 ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer )
            value.SkillBoostedJudgmentResults               = GetObject<JudgmentResultList>(new IntPtr(p + 0x038), ReversePrism.DataModels.JudgmentResultList.FromPointer); // 0270D4F87878 0x38 SkillBoostedJudgmentResults ( 000186768150 ModelClassType JudgmentResultList JudgmentResultList JudgmentResultList Pointer )
            value.SimultaneousLines                         = GetEnumList<SimultaneousLineState>(new IntPtr(p + 0x050)); // 0270D4F878D8 0x50 SimultaneousLines           ( 000185D09F18 ModelEnumListType List`1<SimultaneousLineState> List`1<SimultaneousLineState> List<SimultaneousLineState> Pointer )
            value.NoteTimeManager                           = GetObject<NoteTimeManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.NoteTimeManager.FromPointer); // 0270D4F878F8 0x58 NoteTimeManager             ( 0001866B0320 ModelClassType NoteTimeManager NoteTimeManager NoteTimeManager Pointer )
            value.CurrentCombo                              = GetInt32(new IntPtr(p + 0x068)); // 0270D4F87938 0x68 CurrentCombo                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxCombo                                  = GetInt32(new IntPtr(p + 0x06C)); // 0270D4F87958 0x6C MaxCombo                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentScore                              = GetInt32(new IntPtr(p + 0x070)); // 0270D4F87978 0x70 CurrentScore                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentLife                               = GetInt32(new IntPtr(p + 0x074)); // 0270D4F87998 0x74 CurrentLife                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveSkillIndex                            = GetInt32(new IntPtr(p + 0x078)); // 0270D4F879B8 0x78 LiveSkillIndex              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NoteCount                                 = GetInt32(new IntPtr(p + 0x07C)); // 0270D4F879D8 0x7C NoteCount                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
