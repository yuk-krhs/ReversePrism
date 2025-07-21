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
    // 018 HighScoreRatingList                      ModelClassListType RepeatedField`1<HighScoreRatingStatus> RepeatedField`1<HighScoreRatingStatus> List<HighScoreRatingStatus> Pointer
    // 000 TechnicalRatingListFieldNumber           int IL2CPP_TYPE_I4
    // 010 _repeated_technicalRatingList_codec      FieldCodec`1<TechnicalRatingStatus> IL2CPP_TYPE_GENERICINST
    // 020 TechnicalRatingList                      ModelClassListType RepeatedField`1<TechnicalRatingStatus> RepeatedField`1<TechnicalRatingStatus> List<TechnicalRatingStatus> Pointer
    public partial class GetSongRatingListReply : DataModel
    {
        public List<HighScoreRatingStatus>?             HighScoreRatingList                     { get; set; }
        public List<TechnicalRatingStatus>?             TechnicalRatingList                     { get; set; }

        public static GetSongRatingListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSongRatingListReply() { Pointer= p0 };

            value.HighScoreRatingList                       = GetObjectList<HighScoreRatingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HighScoreRatingStatus.FromPointer); // 0x18 HighScoreRatingList         ( ModelClassListType RepeatedField`1<HighScoreRatingStatus> RepeatedField`1<HighScoreRatingStatus> List<HighScoreRatingStatus> Pointer )
            value.TechnicalRatingList                       = GetObjectList<TechnicalRatingStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TechnicalRatingStatus.FromPointer); // 0x20 TechnicalRatingList         ( ModelClassListType RepeatedField`1<TechnicalRatingStatus> RepeatedField`1<TechnicalRatingStatus> List<TechnicalRatingStatus> Pointer )

            return value;
        }
    }
}
