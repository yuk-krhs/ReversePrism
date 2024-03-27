using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveRateRewardPackStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalHighScoreRateRewardListFieldNumber  int IL2CPP_TYPE_I4
    // 008 _repeated_totalHighScoreRateRewardList_codec FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 018 TotalHighScoreRateRewardList             000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 TotalTechnicalRateRewardListFieldNumber  int IL2CPP_TYPE_I4
    // 010 _repeated_totalTechnicalRateRewardList_codec FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 TotalTechnicalRateRewardList             000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class LiveRateRewardPackStatus
    {
        public List<ProductWithAmountStatus>?           TotalHighScoreRateRewardList            { get; set; }
        public List<ProductWithAmountStatus>?           TotalTechnicalRateRewardList            { get; set; }

        public static LiveRateRewardPackStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveRateRewardPackStatus();

            value.TotalHighScoreRateRewardList              = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1354BC0 0x18 TotalHighScoreRateRewardList ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.TotalTechnicalRateRewardList              = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1354C20 0x20 TotalTechnicalRateRewardList ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
