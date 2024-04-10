using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HighScoreRatingRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TargetRateFieldNumber                    int IL2CPP_TYPE_I4
    // 018 TargetRate                               0001866656B0 ModelPrimitiveType float float float Single
    // 000 HighScoreRatingFrameTypeFieldNumber      int IL2CPP_TYPE_I4
    // 01C HighScoreRatingFrameType                 0001866B6560 ModelEnumType HighScoreRatingFrameType HighScoreRatingFrameType HighScoreRatingFrameType Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class HighScoreRatingRewardStatus : DataModel
    {
        public float                                    TargetRate                              { get; set; }
        public HighScoreRatingFrameType                 HighScoreRatingFrameType                { get; set; }
        public int                                      Star                                    { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }

        public static HighScoreRatingRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighScoreRatingRewardStatus() { Pointer= p0 };

            value.TargetRate                                = GetSingle(new IntPtr(p + 0x018)); // 0246612C6E00 0x18 TargetRate                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HighScoreRatingFrameType                  = (HighScoreRatingFrameType)GetInt32(new IntPtr(p + 0x01C)); // 0246612C6E40 0x1C HighScoreRatingFrameType    ( 0001866B6560 ModelEnumType HighScoreRatingFrameType HighScoreRatingFrameType HighScoreRatingFrameType Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 0246612C6E80 0x20 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0246612C6EE0 0x28 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
