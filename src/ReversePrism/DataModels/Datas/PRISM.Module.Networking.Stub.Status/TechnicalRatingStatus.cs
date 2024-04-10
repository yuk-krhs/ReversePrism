using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TechnicalRatingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 018 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SongLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 020 SongLevel                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TechnicalScoreFieldNumber                int IL2CPP_TYPE_I4
    // 024 TechnicalScore                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RatingFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Rating                                   0001866656B0 ModelPrimitiveType float float float Single
    // 000 MstSongTypeIdFieldNumber                 int IL2CPP_TYPE_I4
    // 02C MstSongTypeId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RatingTheoreticalValueFieldNumber        int IL2CPP_TYPE_I4
    // 030 RatingTheoreticalValue                   0001866656B0 ModelPrimitiveType float float float Single
    public partial class TechnicalRatingStatus : DataModel
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      MstSongId                               { get; set; }
        public int                                      SongLevel                               { get; set; }
        public int                                      TechnicalScore                          { get; set; }
        public float                                    Rating                                  { get; set; }
        public int                                      MstSongTypeId                           { get; set; }
        public float                                    RatingTheoreticalValue                  { get; set; }

        public static TechnicalRatingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TechnicalRatingStatus() { Pointer= p0 };

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0246612FEB18 0x18 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0246612FEB58 0x1C MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x020)); // 0246612FEB98 0x20 SongLevel                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TechnicalScore                            = GetInt32(new IntPtr(p + 0x024)); // 0246612FEBD8 0x24 TechnicalScore              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rating                                    = GetSingle(new IntPtr(p + 0x028)); // 0246612FEC18 0x28 Rating                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x02C)); // 0246612FEC58 0x2C MstSongTypeId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RatingTheoreticalValue                    = GetSingle(new IntPtr(p + 0x030)); // 0246612FEC98 0x30 RatingTheoreticalValue      ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
