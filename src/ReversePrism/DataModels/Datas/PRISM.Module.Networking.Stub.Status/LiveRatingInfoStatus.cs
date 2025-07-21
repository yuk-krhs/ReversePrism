using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveRatingInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HighScoreRatingFieldNumber               int IL2CPP_TYPE_I4
    // 018 HighScoreRating                          ModelPrimitiveType int int int Int32
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 01C TotalHighScoreRating                     ModelPrimitiveType int int int Int32
    // 000 TechnicalRatingFieldNumber               int IL2CPP_TYPE_I4
    // 020 TechnicalRating                          ModelPrimitiveType float float float Single
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 024 TotalTechnicalRating                     ModelPrimitiveType float float float Single
    public partial class LiveRatingInfoStatus : DataModel
    {
        public int                                      HighScoreRating                         { get; set; }
        public int                                      TotalHighScoreRating                    { get; set; }
        public float                                    TechnicalRating                         { get; set; }
        public float                                    TotalTechnicalRating                    { get; set; }

        public static LiveRatingInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveRatingInfoStatus() { Pointer= p0 };

            value.HighScoreRating                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 HighScoreRating             ( ModelPrimitiveType int int int Int32 )
            value.TotalHighScoreRating                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C TotalHighScoreRating        ( ModelPrimitiveType int int int Int32 )
            value.TechnicalRating                           = GetSingle(new IntPtr(p + 0x020)); // 0x20 TechnicalRating             ( ModelPrimitiveType float float float Single )
            value.TotalTechnicalRating                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 TotalTechnicalRating        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
