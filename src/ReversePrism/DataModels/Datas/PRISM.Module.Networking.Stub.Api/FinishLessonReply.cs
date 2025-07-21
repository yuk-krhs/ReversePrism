using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishLessonReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 020 UnitParameterVariation                   ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceCardList                          ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 ChallengeMissionParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 030 ChallengeMissionParameterVariation       ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 038 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ClearSecondFieldNumber                   int IL2CPP_TYPE_I4
    // 03C ClearSecond                              ModelPrimitiveType int int int Int32
    // 000 ClearRankFieldNumber                     int IL2CPP_TYPE_I4
    // 040 ClearRank                                ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 044 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 000 ChallengeMissionFieldNumber              int IL2CPP_TYPE_I4
    // 048 ChallengeMission                         ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 050 GettableProduceCardAmount                ModelPrimitiveType int int int Int32
    // 000 ScheduleRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_scheduleRewardList_codec       FieldCodec`1<ScheduleRewardStatus> IL2CPP_TYPE_GENERICINST
    // 058 ScheduleRewardList                       ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 060 ExertSupportEffectList                   ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    public partial class FinishLessonReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public List<ProduceCardStatus>?                 ProduceCardList                         { get; set; }
        public ParameterVariationStatus?                ChallengeMissionParameterVariation      { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ClearSecond                             { get; set; }
        public ProduceClearRank                         ClearRank                               { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public ChallengeMissionStatus?                  ChallengeMission                        { get; set; }
        public int                                      GettableProduceCardAmount               { get; set; }
        public List<ScheduleRewardStatus>?              ScheduleRewardList                      { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }

        public static FinishLessonReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLessonReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x20 UnitParameterVariation      ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0x28 ProduceCardList             ( ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.ChallengeMissionParameterVariation        = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x30 ChallengeMissionParameterVariation ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x038)); // 0x38 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ClearSecond                 ( ModelPrimitiveType int int int Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x040)); // 0x40 ClearRank                   ( ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.ChallengeMission                          = GetObject<ChallengeMissionStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeMissionStatus.FromPointer); // 0x48 ChallengeMission            ( ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x050)); // 0x50 GettableProduceCardAmount   ( ModelPrimitiveType int int int Int32 )
            value.ScheduleRewardList                        = GetObjectList<ScheduleRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduleRewardStatus.FromPointer); // 0x58 ScheduleRewardList          ( ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0x60 ExertSupportEffectList      ( ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
