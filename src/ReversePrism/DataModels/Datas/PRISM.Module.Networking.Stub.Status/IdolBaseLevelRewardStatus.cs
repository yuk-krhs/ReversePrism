using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolBaseLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class IdolBaseLevelRewardStatus
    {
        public int                                      Level                                   { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }

        public static IdolBaseLevelRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseLevelRewardStatus();

            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D1CE7CF8 0x18 Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1CE7D58 0x20 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
