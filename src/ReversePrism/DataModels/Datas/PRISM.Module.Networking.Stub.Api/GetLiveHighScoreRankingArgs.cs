using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveHighScoreRankingArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 01C DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 PageFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Page                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetLiveHighScoreRankingArgs
    {
        public int                                      MstSongId                               { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      Page                                    { get; set; }

        public static GetLiveHighScoreRankingArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveHighScoreRankingArgs();

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D21D0C50 0x18 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x01C)); // 0270D21D0C90 0x1C DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.Page                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D21D0CD0 0x20 Page                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
