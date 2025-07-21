using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveScoreInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScoreFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Score                                    ModelPrimitiveType int int int Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 01C HighScore                                ModelPrimitiveType int int int Int32
    // 000 ScoreRankFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ScoreRank                                ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 000 IsNewRecordFieldNumber                   int IL2CPP_TYPE_I4
    // 024 IsNewRecord                              ModelPrimitiveType bool bool bool Bool
    public partial class LiveScoreInfoStatus : DataModel
    {
        public int                                      Score                                   { get; set; }
        public int                                      HighScore                               { get; set; }
        public ScoreRank                                ScoreRank                               { get; set; }
        public bool                                     IsNewRecord                             { get; set; }

        public static LiveScoreInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveScoreInfoStatus() { Pointer= p0 };

            value.Score                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Score                       ( ModelPrimitiveType int int int Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C HighScore                   ( ModelPrimitiveType int int int Int32 )
            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScoreRank                   ( ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.IsNewRecord                               = GetBool(new IntPtr(p + 0x024)); // 0x24 IsNewRecord                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
