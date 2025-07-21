using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveMissionGaugeRewardReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GaugeFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Gauge                                    ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 030 ReceivableCount                          ModelPrimitiveType int int int Int32
    public partial class ReceiveMissionGaugeRewardReply : DataModel
    {
        public MissionGaugeStatus?                      Gauge                                   { get; set; }
        public List<RewardProductStatus>?               RewardList                              { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public int                                      ReceivableCount                         { get; set; }

        public static ReceiveMissionGaugeRewardReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveMissionGaugeRewardReply() { Pointer= p0 };

            value.Gauge                                     = GetObject<MissionGaugeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionGaugeStatus.FromPointer); // 0x18 Gauge                       ( ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer )
            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0x20 RewardList                  ( ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x28 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 ReceivableCount             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
