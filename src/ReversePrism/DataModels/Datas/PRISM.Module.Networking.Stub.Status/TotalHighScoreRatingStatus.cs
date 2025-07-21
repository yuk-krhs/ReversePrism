using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TotalHighScoreRatingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalRatingFieldNumber                   int IL2CPP_TYPE_I4
    // 018 TotalRating                              ModelPrimitiveType int int int Int32
    // 000 HighScoreRatingFrameTypeFieldNumber      int IL2CPP_TYPE_I4
    // 01C HighScoreRatingFrameType                 ModelEnumType HighScoreRatingFrameType HighScoreRatingFrameType HighScoreRatingFrameType Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     ModelPrimitiveType int int int Int32
    // 000 MstIdFieldNumber                         int IL2CPP_TYPE_I4
    // 024 MstId                                    ModelPrimitiveType int int int Int32
    public partial class TotalHighScoreRatingStatus : DataModel
    {
        public int                                      TotalRating                             { get; set; }
        public HighScoreRatingFrameType                 HighScoreRatingFrameType                { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      MstId                                   { get; set; }

        public static TotalHighScoreRatingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TotalHighScoreRatingStatus() { Pointer= p0 };

            value.TotalRating                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotalRating                 ( ModelPrimitiveType int int int Int32 )
            value.HighScoreRatingFrameType                  = (HighScoreRatingFrameType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C HighScoreRatingFrameType    ( ModelEnumType HighScoreRatingFrameType HighScoreRatingFrameType HighScoreRatingFrameType Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Star                        ( ModelPrimitiveType int int int Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstId                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
