using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ChallengeTourStageRewardStatus> IL2CPP_TYPE_GENERICINST
    // 018 RewardList                               000185CD1758 ModelClassListType RepeatedField`1<ChallengeTourStageRewardStatus> RepeatedField`1<ChallengeTourStageRewardStatus> List<ChallengeTourStageRewardStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 FanFieldNumber                           int IL2CPP_TYPE_I4
    // 028 Fan                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ChallengeTourStageFieldNumber            int IL2CPP_TYPE_I4
    // 030 ChallengeTourStage                       000186584860 ModelClassType ChallengeTourStageStatus ChallengeTourStageStatus ChallengeTourStageStatus Pointer
    // 000 IdolBaseListFieldNumber                  int IL2CPP_TYPE_I4
    // 010 _repeated_idolBaseList_codec             FieldCodec`1<IdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 038 IdolBaseList                             000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer
    public partial class FinishChallengeTourStageReply : DataModel
    {
        public List<ChallengeTourStageRewardStatus>?    RewardList                              { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public int                                      Fan                                     { get; set; }
        public ChallengeTourStageStatus?                ChallengeTourStage                      { get; set; }
        public List<IdolBaseStatus>?                    IdolBaseList                            { get; set; }

        public static FinishChallengeTourStageReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishChallengeTourStageReply() { Pointer= p0 };

            value.RewardList                                = GetObjectList<ChallengeTourStageRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourStageRewardStatus.FromPointer); // 024660B27528 0x18 RewardList                  ( 000185CD1758 ModelClassListType RepeatedField`1<ChallengeTourStageRewardStatus> RepeatedField`1<ChallengeTourStageRewardStatus> List<ChallengeTourStageRewardStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 024660B27568 0x20 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.Fan                                       = GetInt32(new IntPtr(p + 0x028)); // 024660B275A8 0x28 Fan                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChallengeTourStage                        = GetObject<ChallengeTourStageStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourStageStatus.FromPointer); // 024660B275E8 0x30 ChallengeTourStage          ( 000186584860 ModelClassType ChallengeTourStageStatus ChallengeTourStageStatus ChallengeTourStageStatus Pointer )
            value.IdolBaseList                              = GetObjectList<IdolBaseStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IdolBaseStatus.FromPointer); // 024660B27648 0x38 IdolBaseList                ( 000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer )

            return value;
        }
    }
}
