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
    // 018 Gauge                                    000186622DD0 ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 030 ReceivableCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReceiveMissionGaugeRewardReply
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
            var value   = new ReceiveMissionGaugeRewardReply();

            value.Gauge                                     = GetObject<MissionGaugeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionGaugeStatus.FromPointer); // 0270D22E5DA8 0x18 Gauge                       ( 000186622DD0 ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer )
            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D22E5E08 0x20 RewardList                  ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D22E5E48 0x28 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x030)); // 0270D22E5E88 0x30 ReceivableCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
