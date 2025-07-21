using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MedalGashaBoxStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BoxNumberFieldNumber                     int IL2CPP_TYPE_I4
    // 018 BoxNumber                                ModelPrimitiveType long long long Int64
    // 000 IsLoopFieldNumber                        int IL2CPP_TYPE_I4
    // 020 IsLoop                                   ModelPrimitiveType bool bool bool Bool
    // 000 IsUsedFieldNumber                        int IL2CPP_TYPE_I4
    // 021 IsUsed                                   ModelPrimitiveType bool bool bool Bool
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<MedalGashaRewardStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardList                               ModelClassListType RepeatedField`1<MedalGashaRewardStatus> RepeatedField`1<MedalGashaRewardStatus> List<MedalGashaRewardStatus> Pointer
    public partial class MedalGashaBoxStatus : DataModel
    {
        public long                                     BoxNumber                               { get; set; }
        public bool                                     IsLoop                                  { get; set; }
        public bool                                     IsUsed                                  { get; set; }
        public List<MedalGashaRewardStatus>?            RewardList                              { get; set; }

        public static MedalGashaBoxStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaBoxStatus() { Pointer= p0 };

            value.BoxNumber                                 = GetInt64(new IntPtr(p + 0x018)); // 0x18 BoxNumber                   ( ModelPrimitiveType long long long Int64 )
            value.IsLoop                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 IsLoop                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsUsed                                    = GetBool(new IntPtr(p + 0x021)); // 0x21 IsUsed                      ( ModelPrimitiveType bool bool bool Bool )
            value.RewardList                                = GetObjectList<MedalGashaRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.MedalGashaRewardStatus.FromPointer); // 0x28 RewardList                  ( ModelClassListType RepeatedField`1<MedalGashaRewardStatus> RepeatedField`1<MedalGashaRewardStatus> List<MedalGashaRewardStatus> Pointer )

            return value;
        }
    }
}
