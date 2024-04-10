using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Score                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Combo                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 RemainingLife                            0001865F4260 ModelPrimitiveType int int int Int32
    // 020 BaseTimingJudgement                      00018659BBC0 ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer
    // 028 SkillBoostedTimingJudgement              00018659BBC0 ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer
    // 030 <ActivatedSkills>k__BackingField         IEnumerable`1<ILiveActivatedSkillStatus> IL2CPP_TYPE_GENERICINST
    // 038 CharacterIds                             000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 OnStageIdols                             000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class LiveResultData : DataModel
    {
        public int                                      Score                                   { get; set; }
        public int                                      Combo                                   { get; set; }
        public int                                      RemainingLife                           { get; set; }
        public ILiveTimingJudgementStatus?              BaseTimingJudgement                     { get; set; }
        public ILiveTimingJudgementStatus?              SkillBoostedTimingJudgement             { get; set; }
        public List<int>?                               CharacterIds                            { get; set; }
        public List<UnitIdol>?                          OnStageIdols                            { get; set; }

        public static LiveResultData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultData() { Pointer= p0 };

            value.Score                                     = GetInt32(new IntPtr(p + 0x010)); // 0246652BBB98 0x10 Score                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x014)); // 0246652BBBB8 0x14 Combo                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RemainingLife                             = GetInt32(new IntPtr(p + 0x018)); // 0246652BBBD8 0x18 RemainingLife               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BaseTimingJudgement                       = GetObject<ILiveTimingJudgementStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILiveTimingJudgementStatus.FromPointer); // 0246652BBBF8 0x20 BaseTimingJudgement         ( 00018659BBC0 ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer )
            value.SkillBoostedTimingJudgement               = GetObject<ILiveTimingJudgementStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILiveTimingJudgementStatus.FromPointer); // 0246652BBC18 0x28 SkillBoostedTimingJudgement ( 00018659BBC0 ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer )
            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x038)); // 0246652BBC58 0x38 CharacterIds                ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.OnStageIdols                              = GetObjectList<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0246652BBC78 0x40 OnStageIdols                ( 000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
