using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TechnicalRatingRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TargetRateFieldNumber                    int IL2CPP_TYPE_I4
    // 018 TargetRate                               0001866656B0 ModelPrimitiveType float float float Single
    // 000 TechnicalRatingFrameTypeFieldNumber      int IL2CPP_TYPE_I4
    // 01C TechnicalRatingFrameType                 000186628020 ModelEnumType TechnicalRatingFrameType TechnicalRatingFrameType TechnicalRatingFrameType Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class TechnicalRatingRewardStatus
    {
        public float                                    TargetRate                              { get; set; }
        public TechnicalRatingFrameType                 TechnicalRatingFrameType                { get; set; }
        public int                                      Star                                    { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }

        public static TechnicalRatingRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TechnicalRatingRewardStatus();

            value.TargetRate                                = GetSingle(new IntPtr(p + 0x018)); // 0270D13752C0 0x18 TargetRate                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TechnicalRatingFrameType                  = (TechnicalRatingFrameType)GetInt32(new IntPtr(p + 0x01C)); // 0270D1375300 0x1C TechnicalRatingFrameType    ( 000186628020 ModelEnumType TechnicalRatingFrameType TechnicalRatingFrameType TechnicalRatingFrameType Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D1375340 0x20 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D13753A0 0x28 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
