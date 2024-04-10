using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MissionGaugeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Point                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<MissionGaugeRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CE6C38 ModelClassListType RepeatedField`1<MissionGaugeRewardStatus> RepeatedField`1<MissionGaugeRewardStatus> List<MissionGaugeRewardStatus> Pointer
    public partial class MissionGaugeStatus : DataModel
    {
        public int                                      Point                                   { get; set; }
        public List<MissionGaugeRewardStatus>?          RewardList                              { get; set; }

        public static MissionGaugeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGaugeStatus() { Pointer= p0 };

            value.Point                                     = GetInt32(new IntPtr(p + 0x018)); // 024662260120 0x18 Point                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<MissionGaugeRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MissionGaugeRewardStatus.FromPointer); // 024662260180 0x20 RewardList                  ( 000185CE6C38 ModelClassListType RepeatedField`1<MissionGaugeRewardStatus> RepeatedField`1<MissionGaugeRewardStatus> List<MissionGaugeRewardStatus> Pointer )

            return value;
        }
    }
}
