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
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 020 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ProduceCardListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardList_codec          FieldCodec`1<ProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceCardList                          000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer
    // 000 ChallengeMissionParameterVariationFieldNumber int IL2CPP_TYPE_I4
    // 030 ChallengeMissionParameterVariation       00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 038 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ClearSecondFieldNumber                   int IL2CPP_TYPE_I4
    // 03C ClearSecond                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ClearRankFieldNumber                     int IL2CPP_TYPE_I4
    // 040 ClearRank                                000186538BD0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 044 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ChallengeMissionFieldNumber              int IL2CPP_TYPE_I4
    // 048 ChallengeMission                         00018656C2A0 ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer
    // 000 GettableProduceCardAmountFieldNumber     int IL2CPP_TYPE_I4
    // 050 GettableProduceCardAmount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScheduleRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_scheduleRewardList_codec       FieldCodec`1<ScheduleRewardStatus> IL2CPP_TYPE_GENERICINST
    // 058 ScheduleRewardList                       000185CEF588 ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 018 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 060 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
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

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 024662514AD0 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 024662514B10 0x20 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ProduceCardList                           = GetObjectList<ProduceCardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 024662514B70 0x28 ProduceCardList             ( 000185CEB1C8 ModelClassListType RepeatedField`1<ProduceCardStatus> RepeatedField`1<ProduceCardStatus> List<ProduceCardStatus> Pointer )
            value.ChallengeMissionParameterVariation        = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 024662514BB0 0x30 ChallengeMissionParameterVariation ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x038)); // 024662514BF0 0x38 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x03C)); // 024662514C30 0x3C ClearSecond                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x040)); // 024662514C70 0x40 ClearRank                   ( 000186538BD0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x044)); // 024662514CB0 0x44 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChallengeMission                          = GetObject<ChallengeMissionStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeMissionStatus.FromPointer); // 024662514CF0 0x48 ChallengeMission            ( 00018656C2A0 ModelClassType ChallengeMissionStatus ChallengeMissionStatus ChallengeMissionStatus Pointer )
            value.GettableProduceCardAmount                 = GetInt32(new IntPtr(p + 0x050)); // 024662514D30 0x50 GettableProduceCardAmount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleRewardList                        = GetObjectList<ScheduleRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduleRewardStatus.FromPointer); // 024662514D90 0x58 ScheduleRewardList          ( 000185CEF588 ModelClassListType RepeatedField`1<ScheduleRewardStatus> RepeatedField`1<ScheduleRewardStatus> List<ScheduleRewardStatus> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 024662514DF0 0x60 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
