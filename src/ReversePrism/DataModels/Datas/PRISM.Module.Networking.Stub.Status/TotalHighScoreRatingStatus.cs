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
    // 018 TotalRating                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighScoreRatingFrameTypeFieldNumber      int IL2CPP_TYPE_I4
    // 01C HighScoreRatingFrameType                 0001866B6560 ModelEnumType HighScoreRatingFrameType HighScoreRatingFrameType HighScoreRatingFrameType Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdFieldNumber                         int IL2CPP_TYPE_I4
    // 024 MstId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TotalHighScoreRatingStatus
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
            var value   = new TotalHighScoreRatingStatus();

            value.TotalRating                               = GetInt32(new IntPtr(p + 0x018)); // 0270D1377480 0x18 TotalRating                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighScoreRatingFrameType                  = (HighScoreRatingFrameType)GetInt32(new IntPtr(p + 0x01C)); // 0270D13774C0 0x1C HighScoreRatingFrameType    ( 0001866B6560 ModelEnumType HighScoreRatingFrameType HighScoreRatingFrameType HighScoreRatingFrameType Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D1377500 0x20 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x024)); // 0270D1377540 0x24 MstId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
