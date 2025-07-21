using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Score                                    ModelPrimitiveType int int int Int32
    // 014 Combo                                    ModelPrimitiveType int int int Int32
    // 018 RemainingLife                            ModelPrimitiveType int int int Int32
    // 020 BaseTimingJudgement                      ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer
    // 028 SkillBoostedTimingJudgement              ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer
    // 030 SkillBoostedToPerfectCount               ModelPrimitiveType int int int Int32
    // 034 SkillBoostedToGreatCount                 ModelPrimitiveType int int int Int32
    // 038 ActivatedSkillSlots                      ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 CharacterIds                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 OnStageIdols                             ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class LiveResultData : DataModel
    {
        public int                                      Score                                   { get; set; }
        public int                                      Combo                                   { get; set; }
        public int                                      RemainingLife                           { get; set; }
        public ILiveTimingJudgementStatus?              BaseTimingJudgement                     { get; set; }
        public ILiveTimingJudgementStatus?              SkillBoostedTimingJudgement             { get; set; }
        public int                                      SkillBoostedToPerfectCount              { get; set; }
        public int                                      SkillBoostedToGreatCount                { get; set; }
        public List<int>?                               ActivatedSkillSlots                     { get; set; }
        public List<int>?                               CharacterIds                            { get; set; }
        public List<UnitIdol>?                          OnStageIdols                            { get; set; }

        public static LiveResultData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultData() { Pointer= p0 };

            value.Score                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Score                       ( ModelPrimitiveType int int int Int32 )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Combo                       ( ModelPrimitiveType int int int Int32 )
            value.RemainingLife                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 RemainingLife               ( ModelPrimitiveType int int int Int32 )
            value.BaseTimingJudgement                       = GetObject<ILiveTimingJudgementStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILiveTimingJudgementStatus.FromPointer); // 0x20 BaseTimingJudgement         ( ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer )
            value.SkillBoostedTimingJudgement               = GetObject<ILiveTimingJudgementStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILiveTimingJudgementStatus.FromPointer); // 0x28 SkillBoostedTimingJudgement ( ModelClassType ILiveTimingJudgementStatus ILiveTimingJudgementStatus ILiveTimingJudgementStatus Pointer )
            value.SkillBoostedToPerfectCount                = GetInt32(new IntPtr(p + 0x030)); // 0x30 SkillBoostedToPerfectCount  ( ModelPrimitiveType int int int Int32 )
            value.SkillBoostedToGreatCount                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 SkillBoostedToGreatCount    ( ModelPrimitiveType int int int Int32 )
            value.ActivatedSkillSlots                       = GetInt32List(new IntPtr(p + 0x038)); // 0x38 ActivatedSkillSlots         ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CharacterIds                              = GetInt32List(new IntPtr(p + 0x040)); // 0x40 CharacterIds                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.OnStageIdols                              = GetObjectList<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x48 OnStageIdols                ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
