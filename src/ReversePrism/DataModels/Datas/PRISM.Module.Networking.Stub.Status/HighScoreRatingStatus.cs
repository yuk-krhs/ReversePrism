using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HighScoreRatingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 018 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SongLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 020 SongLevel                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 024 HighScore                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RatingFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Rating                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSongTypeIdFieldNumber                 int IL2CPP_TYPE_I4
    // 02C MstSongTypeId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HighScoreRatingStatus
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      MstSongId                               { get; set; }
        public int                                      SongLevel                               { get; set; }
        public int                                      HighScore                               { get; set; }
        public int                                      Rating                                  { get; set; }
        public int                                      MstSongTypeId                           { get; set; }

        public static HighScoreRatingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighScoreRatingStatus();

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0270D133F128 0x18 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D133F168 0x1C MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D133F1A8 0x20 SongLevel                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D133F1E8 0x24 HighScore                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rating                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D133F228 0x28 Rating                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x02C)); // 0270D133F268 0x2C MstSongTypeId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
