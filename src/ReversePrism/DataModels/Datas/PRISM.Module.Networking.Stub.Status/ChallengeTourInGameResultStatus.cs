using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameResultStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsSuccessFieldNumber                     int IL2CPP_TYPE_I4
    // 018 IsSuccess                                ModelPrimitiveType bool bool bool Bool
    // 000 AppealPointFieldNumber                   int IL2CPP_TYPE_I4
    // 020 AppealPoint                              ModelClassType InGameAppealPointStatus InGameAppealPointStatus InGameAppealPointStatus Pointer
    // 000 ClearSecondFieldNumber                   int IL2CPP_TYPE_I4
    // 028 ClearSecond                              ModelPrimitiveType int int int Int32
    // 000 IdolSkillListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_idolSkillList_codec            FieldCodec`1<InGameIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 030 IdolSkillList                            ModelClassListType RepeatedField`1<InGameIdolSkillStatus> RepeatedField`1<InGameIdolSkillStatus> List<InGameIdolSkillStatus> Pointer
    // 000 ProduceCardIdListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardIdList_codec        FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 ProduceCardIdList                        ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 ClearStatusFieldNumber                   int IL2CPP_TYPE_I4
    // 040 ClearStatus                              ModelClassType ChallengeTourInGameClearStatus ChallengeTourInGameClearStatus ChallengeTourInGameClearStatus Pointer
    // 000 AccumulatedStatusFieldNumber             int IL2CPP_TYPE_I4
    // 048 AccumulatedStatus                        ModelClassType ChallengeTourInGameAccumulatedStatus ChallengeTourInGameAccumulatedStatus ChallengeTourInGameAccumulatedStatus Pointer
    public partial class ChallengeTourInGameResultStatus : DataModel
    {
        public bool                                     IsSuccess                               { get; set; }
        public InGameAppealPointStatus?                 AppealPoint                             { get; set; }
        public int                                      ClearSecond                             { get; set; }
        public List<InGameIdolSkillStatus>?             IdolSkillList                           { get; set; }
        public List<string>?                            ProduceCardIdList                       { get; set; }
        public ChallengeTourInGameClearStatus?          ClearStatus                             { get; set; }
        public ChallengeTourInGameAccumulatedStatus?    AccumulatedStatus                       { get; set; }

        public static ChallengeTourInGameResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameResultStatus() { Pointer= p0 };

            value.IsSuccess                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsSuccess                   ( ModelPrimitiveType bool bool bool Bool )
            value.AppealPoint                               = GetObject<InGameAppealPointStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameAppealPointStatus.FromPointer); // 0x20 AppealPoint                 ( ModelClassType InGameAppealPointStatus InGameAppealPointStatus InGameAppealPointStatus Pointer )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 ClearSecond                 ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<InGameIdolSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.InGameIdolSkillStatus.FromPointer); // 0x30 IdolSkillList               ( ModelClassListType RepeatedField`1<InGameIdolSkillStatus> RepeatedField`1<InGameIdolSkillStatus> List<InGameIdolSkillStatus> Pointer )
            value.ProduceCardIdList                         = GetStringList(new IntPtr(p + 0x038)); // 0x38 ProduceCardIdList           ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.ClearStatus                               = GetObject<ChallengeTourInGameClearStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChallengeTourInGameClearStatus.FromPointer); // 0x40 ClearStatus                 ( ModelClassType ChallengeTourInGameClearStatus ChallengeTourInGameClearStatus ChallengeTourInGameClearStatus Pointer )
            value.AccumulatedStatus                         = GetObject<ChallengeTourInGameAccumulatedStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeTourInGameAccumulatedStatus.FromPointer); // 0x48 AccumulatedStatus           ( ModelClassType ChallengeTourInGameAccumulatedStatus ChallengeTourInGameAccumulatedStatus ChallengeTourInGameAccumulatedStatus Pointer )

            return value;
        }
    }
}
