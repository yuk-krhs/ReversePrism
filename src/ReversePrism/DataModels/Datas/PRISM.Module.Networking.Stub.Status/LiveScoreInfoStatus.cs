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
    // 018 Score                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 01C HighScore                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScoreRankFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ScoreRank                                0001866EDE40 ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 000 IsNewRecordFieldNumber                   int IL2CPP_TYPE_I4
    // 024 IsNewRecord                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveScoreInfoStatus
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
            var value   = new LiveScoreInfoStatus();

            value.Score                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D1359958 0x18 Score                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D1359998 0x1C HighScore                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x020)); // 0270D13599D8 0x20 ScoreRank                   ( 0001866EDE40 ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.IsNewRecord                               = GetBool(new IntPtr(p + 0x024)); // 0270D1359A18 0x24 IsNewRecord                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
