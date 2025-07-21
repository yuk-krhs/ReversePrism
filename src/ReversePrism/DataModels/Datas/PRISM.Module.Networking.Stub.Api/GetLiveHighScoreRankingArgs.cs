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
    // 018 MstSongId                                ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 01C DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 PageFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Page                                     ModelPrimitiveType int int int Int32
    public partial class GetLiveHighScoreRankingArgs : DataModel
    {
        public int                                      MstSongId                               { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      Page                                    { get; set; }

        public static GetLiveHighScoreRankingArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveHighScoreRankingArgs() { Pointer= p0 };

            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x01C)); // 0x1C DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.Page                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Page                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
