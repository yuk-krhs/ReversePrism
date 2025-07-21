using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 018 UnitID                                   ModelPrimitiveType int int int Int32
    // 01C ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 020 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 024 IsExistSupportBonus                      ModelPrimitiveType bool bool bool Bool
    // 028 ClearRank                                ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 02C ClearSecond                              ModelPrimitiveType int int int Int32
    // 030 ScheduleRewards                          ModelClassListType IReadOnlyList`1<IScheduleRewardStatus> IReadOnlyList`1<IScheduleRewardStatus> List<IScheduleRewardStatus> Pointer
    // 038 UnitIdolCount                            ModelPrimitiveType int int int Int32
    // 040 UnitParameterVariation                   ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 048 ChallengeMission                         ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer
    // 050 ChallengeMissionIdol                     ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 058 ChallengeMissionParameterVariation       ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer
    // 060 IsChallengeMissionAchieved               ModelPrimitiveType bool bool bool Bool
    // 064 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 068 GettableProduceCards                     ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 070 DeckProduceCards                         ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 078 ExertSupportEffectList                   ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer
    // 080 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class LessonSuccessResultArgument : DataModel
    {
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public int                                      UnitID                                  { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public bool                                     IsExistSupportBonus                     { get; set; }
        public ProduceClearRank                         ClearRank                               { get; set; }
        public int                                      ClearSecond                             { get; set; }
        public List<IScheduleRewardStatus>?             ScheduleRewards                         { get; set; }
        public int                                      UnitIdolCount                           { get; set; }
        public IParameterVariationStatus?               UnitParameterVariation                  { get; set; }
        public IChallengeMissionStatus?                 ChallengeMission                        { get; set; }
        public IInProduceIdolStatus?                    ChallengeMissionIdol                    { get; set; }
        public IParameterVariationStatus?               ChallengeMissionParameterVariation      { get; set; }
        public bool                                     IsChallengeMissionAchieved              { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public List<IProduceCardStatus>?                GettableProduceCards                    { get; set; }
        public List<IProduceCardStatus>?                DeckProduceCards                        { get; set; }
        public List<IExertSupportEffectStatus>?         ExertSupportEffectList                  { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }

        public static LessonSuccessResultArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonSuccessResultArgument() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x10 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitID                      ( ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.IsExistSupportBonus                       = GetBool(new IntPtr(p + 0x024)); // 0x24 IsExistSupportBonus         ( ModelPrimitiveType bool bool bool Bool )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x028)); // 0x28 ClearRank                   ( ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ClearSecond                 ( ModelPrimitiveType int int int Int32 )
            value.ScheduleRewards                           = GetObjectList<IScheduleRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IScheduleRewardStatus.FromPointer); // 0x30 ScheduleRewards             ( ModelClassListType IReadOnlyList`1<IScheduleRewardStatus> IReadOnlyList`1<IScheduleRewardStatus> List<IScheduleRewardStatus> Pointer )
            value.UnitIdolCount                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 UnitIdolCount               ( ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x40 UnitParameterVariation      ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.ChallengeMission                          = GetObject<IChallengeMissionStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IChallengeMissionStatus.FromPointer); // 0x48 ChallengeMission            ( ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer )
            value.ChallengeMissionIdol                      = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0x50 ChallengeMissionIdol        ( ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.ChallengeMissionParameterVariation        = GetObject<IParameterVariationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IParameterVariationStatus.FromPointer); // 0x58 ChallengeMissionParameterVariation ( ModelClassType IParameterVariationStatus IParameterVariationStatus IParameterVariationStatus Pointer )
            value.IsChallengeMissionAchieved                = GetBool(new IntPtr(p + 0x060)); // 0x60 IsChallengeMissionAchieved  ( ModelPrimitiveType bool bool bool Bool )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x064)); // 0x64 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.GettableProduceCards                      = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x68 GettableProduceCards        ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.DeckProduceCards                          = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x70 DeckProduceCards            ( ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<IExertSupportEffectStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IExertSupportEffectStatus.FromPointer); // 0x78 ExertSupportEffectList      ( ModelClassListType List`1<IExertSupportEffectStatus> List`1<IExertSupportEffectStatus> List<IExertSupportEffectStatus> Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x80 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
