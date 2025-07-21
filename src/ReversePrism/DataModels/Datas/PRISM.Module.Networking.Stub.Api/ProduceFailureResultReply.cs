using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceFailureResultReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IdolBaseRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_idolBaseRewardList_codec       FieldCodec`1<IdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 028 IdolBaseRewardList                       ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 034 ScheduleLevel                            ModelPrimitiveType int int int Int32
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 038 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class ProduceFailureResultReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public List<IdolBaseRewardStatus>?              IdolBaseRewardList                      { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static ProduceFailureResultReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x20 RewardList                  ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IdolBaseRewardList                        = GetObjectList<IdolBaseRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0x28 IdolBaseRewardList          ( ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 ScheduleLevel               ( ModelPrimitiveType int int int Int32 )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x38 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
