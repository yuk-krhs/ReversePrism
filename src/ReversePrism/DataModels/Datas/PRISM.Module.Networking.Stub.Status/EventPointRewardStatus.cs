using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventPointRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Point                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class EventPointRewardStatus
    {
        public long                                     Point                                   { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }

        public static EventPointRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventPointRewardStatus();

            value.Point                                     = GetInt64(new IntPtr(p + 0x018)); // 0270D1380090 0x18 Point                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D13800F0 0x20 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
