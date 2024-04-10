using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSongRatingListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HighScoreRatingListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_highScoreRatingList_codec      FieldCodec`1<HighScoreRatingStatus> IL2CPP_TYPE_GENERICINST
    // 018 HighScoreRatingList                      000185CDE3C8 ModelClassListType RepeatedField`1<HighScoreRatingStatus> RepeatedField`1<HighScoreRatingStatus> List<HighScoreRatingStatus> Pointer
    // 000 HighScoreRatingRewardListFieldNumber     int IL2CPP_TYPE_I4
    // 010 _repeated_highScoreRatingRewardList_codec FieldCodec`1<HighScoreRatingRewardStatus> IL2CPP_TYPE_GENERICINST
    // 020 HighScoreRatingRewardList                000185CDE1A8 ModelClassListType RepeatedField`1<HighScoreRatingRewardStatus> RepeatedField`1<HighScoreRatingRewardStatus> List<HighScoreRatingRewardStatus> Pointer
    // 000 TechnicalRatingListFieldNumber           int IL2CPP_TYPE_I4
    // 018 _repeated_technicalRatingList_codec      FieldCodec`1<TechnicalRatingStatus> IL2CPP_TYPE_GENERICINST
    // 028 TechnicalRatingList                      000185CF4E38 ModelClassListType RepeatedField`1<TechnicalRatingStatus> RepeatedField`1<TechnicalRatingStatus> List<TechnicalRatingStatus> Pointer
    // 000 TechnicalRatingRewardListFieldNumber     int IL2CPP_TYPE_I4
    // 020 _repeated_technicalRatingRewardList_codec FieldCodec`1<TechnicalRatingRewardStatus> IL2CPP_TYPE_GENERICINST
    // 030 TechnicalRatingRewardList                000185CF4BF8 ModelClassListType RepeatedField`1<TechnicalRatingRewardStatus> RepeatedField`1<TechnicalRatingRewardStatus> List<TechnicalRatingRewardStatus> Pointer
    public partial class GetSongRatingListReply : DataModel
    {
        public List<HighScoreRatingStatus>?             HighScoreRatingList                     { get; set; }
        public List<HighScoreRatingRewardStatus>?       HighScoreRatingRewardList               { get; set; }
        public List<TechnicalRatingStatus>?             TechnicalRatingList                     { get; set; }
        public List<TechnicalRatingRewardStatus>?       TechnicalRatingRewardList               { get; set; }

        public static GetSongRatingListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSongRatingListReply() { Pointer= p0 };

            value.HighScoreRatingList                       = GetObjectList<HighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HighScoreRatingStatus.FromPointer); // 02466218A5D8 0x18 HighScoreRatingList         ( 000185CDE3C8 ModelClassListType RepeatedField`1<HighScoreRatingStatus> RepeatedField`1<HighScoreRatingStatus> List<HighScoreRatingStatus> Pointer )
            value.HighScoreRatingRewardList                 = GetObjectList<HighScoreRatingRewardStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HighScoreRatingRewardStatus.FromPointer); // 02466218A638 0x20 HighScoreRatingRewardList   ( 000185CDE1A8 ModelClassListType RepeatedField`1<HighScoreRatingRewardStatus> RepeatedField`1<HighScoreRatingRewardStatus> List<HighScoreRatingRewardStatus> Pointer )
            value.TechnicalRatingList                       = GetObjectList<TechnicalRatingStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.TechnicalRatingStatus.FromPointer); // 02466218A698 0x28 TechnicalRatingList         ( 000185CF4E38 ModelClassListType RepeatedField`1<TechnicalRatingStatus> RepeatedField`1<TechnicalRatingStatus> List<TechnicalRatingStatus> Pointer )
            value.TechnicalRatingRewardList                 = GetObjectList<TechnicalRatingRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.TechnicalRatingRewardStatus.FromPointer); // 02466218A6F8 0x30 TechnicalRatingRewardList   ( 000185CF4BF8 ModelClassListType RepeatedField`1<TechnicalRatingRewardStatus> RepeatedField`1<TechnicalRatingRewardStatus> List<TechnicalRatingRewardStatus> Pointer )

            return value;
        }
    }
}
