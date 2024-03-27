using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DrawMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 RewardList                               000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 MedalGashaStatusFieldNumber              int IL2CPP_TYPE_I4
    // 020 MedalGashaStatus                         0001865EEDD0 ModelClassType MedalGashaStatus MedalGashaStatus MedalGashaStatus Pointer
    // 000 BoxListFieldNumber                       int IL2CPP_TYPE_I4
    // 010 _repeated_boxList_codec                  FieldCodec`1<MedalGashaBoxStatus> IL2CPP_TYPE_GENERICINST
    // 028 BoxList                                  000185CE5988 ModelClassListType RepeatedField`1<MedalGashaBoxStatus> RepeatedField`1<MedalGashaBoxStatus> List<MedalGashaBoxStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 030 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class DrawMedalGashaReply
    {
        public List<RewardProductStatus>?               RewardList                              { get; set; }
        public MedalGashaStatus?                        MedalGashaStatus                        { get; set; }
        public List<MedalGashaBoxStatus>?               BoxList                                 { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static DrawMedalGashaReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawMedalGashaReply();

            value.RewardList                                = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D2288960 0x18 RewardList                  ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.MedalGashaStatus                          = GetObject<MedalGashaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MedalGashaStatus.FromPointer); // 0270D22889A0 0x20 MedalGashaStatus            ( 0001865EEDD0 ModelClassType MedalGashaStatus MedalGashaStatus MedalGashaStatus Pointer )
            value.BoxList                                   = GetObjectList<MedalGashaBoxStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.MedalGashaBoxStatus.FromPointer); // 0270D2288A00 0x28 BoxList                     ( 000185CE5988 ModelClassListType RepeatedField`1<MedalGashaBoxStatus> RepeatedField`1<MedalGashaBoxStatus> List<MedalGashaBoxStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D2288A40 0x30 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
