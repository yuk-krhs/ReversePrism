using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MatchResultFieldNumber                   int IL2CPP_TYPE_I4
    // 018 MatchResult                              0001865EA090 ModelClassType PvpMatchResultStatus PvpMatchResultStatus PvpMatchResultStatus Pointer
    // 000 HighestRankUpdateRewardListFieldNumber   int IL2CPP_TYPE_I4
    // 008 _repeated_highestRankUpdateRewardList_codec FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 HighestRankUpdateRewardList              000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 028 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 030 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FinishPvpMatchReply
    {
        public PvpMatchResultStatus?                    MatchResult                             { get; set; }
        public List<ProductWithAmountStatus>?           HighestRankUpdateRewardList             { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public int                                      MstEventId                              { get; set; }

        public static FinishPvpMatchReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishPvpMatchReply();

            value.MatchResult                               = GetObject<PvpMatchResultStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.PvpMatchResultStatus.FromPointer); // 0270D27419A8 0x18 MatchResult                 ( 0001865EA090 ModelClassType PvpMatchResultStatus PvpMatchResultStatus PvpMatchResultStatus Pointer )
            value.HighestRankUpdateRewardList               = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D2741A08 0x20 HighestRankUpdateRewardList ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D2741A48 0x28 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x030)); // 0270D2741A88 0x30 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
