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
    // 018 HighScoreRating                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 01C TotalHighScoreRating                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TechnicalRatingFieldNumber               int IL2CPP_TYPE_I4
    // 020 TechnicalRating                          0001866656B0 ModelPrimitiveType float float float Single
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 024 TotalTechnicalRating                     0001866656B0 ModelPrimitiveType float float float Single
    public partial class LiveRatingInfoStatus
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
            var value   = new LiveRatingInfoStatus();

            value.HighScoreRating                           = GetInt32(new IntPtr(p + 0x018)); // 0270D1355840 0x18 HighScoreRating             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalHighScoreRating                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D1355880 0x1C TotalHighScoreRating        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TechnicalRating                           = GetSingle(new IntPtr(p + 0x020)); // 0270D13558C0 0x20 TechnicalRating             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TotalTechnicalRating                      = GetSingle(new IntPtr(p + 0x024)); // 0270D1355900 0x24 TotalTechnicalRating        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
