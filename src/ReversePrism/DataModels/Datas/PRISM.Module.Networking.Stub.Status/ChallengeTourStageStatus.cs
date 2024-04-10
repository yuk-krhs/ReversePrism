using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourStageStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StageIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 StageId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StageNumberFieldNumber                   int IL2CPP_TYPE_I4
    // 01C StageNumber                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StageTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StageType                                000186585040 ModelEnumType ChallengeTourStageType ChallengeTourStageType ChallengeTourStageType Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Star                                     00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ChallengeTourStageRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 RewardList                               000185CD1758 ModelClassListType RepeatedField`1<ChallengeTourStageRewardStatus> RepeatedField`1<ChallengeTourStageRewardStatus> List<ChallengeTourStageRewardStatus> Pointer
    // 000 RivalUnitFieldNumber                     int IL2CPP_TYPE_I4
    // 038 RivalUnit                                00018657EB90 ModelClassType ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus Pointer
    public partial class ChallengeTourStageStatus : DataModel
    {
        public int                                      StageId                                 { get; set; }
        public int                                      StageNumber                             { get; set; }
        public ChallengeTourStageType                   StageType                               { get; set; }
        public LimitedValueStatus?                      Star                                    { get; set; }
        public List<ChallengeTourStageRewardStatus>?    RewardList                              { get; set; }
        public ChallengeTourRivalUnitStatus?            RivalUnit                               { get; set; }

        public static ChallengeTourStageStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageStatus() { Pointer= p0 };

            value.StageId                                   = GetInt32(new IntPtr(p + 0x018)); // 024660EDCE10 0x18 StageId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StageNumber                               = GetInt32(new IntPtr(p + 0x01C)); // 024660EDCE50 0x1C StageNumber                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StageType                                 = (ChallengeTourStageType)GetInt32(new IntPtr(p + 0x020)); // 024660EDCE90 0x20 StageType                   ( 000186585040 ModelEnumType ChallengeTourStageType ChallengeTourStageType ChallengeTourStageType Int32 )
            value.Star                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024660EDCED0 0x28 Star                        ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.RewardList                                = GetObjectList<ChallengeTourStageRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourStageRewardStatus.FromPointer); // 024660EDCF30 0x30 RewardList                  ( 000185CD1758 ModelClassListType RepeatedField`1<ChallengeTourStageRewardStatus> RepeatedField`1<ChallengeTourStageRewardStatus> List<ChallengeTourStageRewardStatus> Pointer )
            value.RivalUnit                                 = GetObject<ChallengeTourRivalUnitStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourRivalUnitStatus.FromPointer); // 024660EDCF70 0x38 RivalUnit                   ( 00018657EB90 ModelClassType ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus Pointer )

            return value;
        }
    }
}
