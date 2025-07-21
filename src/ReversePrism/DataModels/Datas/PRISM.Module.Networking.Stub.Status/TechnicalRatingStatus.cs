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
    // 018 DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstSongId                                ModelPrimitiveType int int int Int32
    // 000 SongLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 020 SongLevel                                ModelPrimitiveType int int int Int32
    // 000 TechnicalScoreFieldNumber                int IL2CPP_TYPE_I4
    // 024 TechnicalScore                           ModelPrimitiveType int int int Int32
    // 000 RatingFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Rating                                   ModelPrimitiveType float float float Single
    // 000 RatingTheoreticalValueFieldNumber        int IL2CPP_TYPE_I4
    // 02C RatingTheoreticalValue                   ModelPrimitiveType float float float Single
    public partial class TechnicalRatingStatus : DataModel
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      MstSongId                               { get; set; }
        public int                                      SongLevel                               { get; set; }
        public int                                      TechnicalScore                          { get; set; }
        public float                                    Rating                                  { get; set; }
        public float                                    RatingTheoreticalValue                  { get; set; }

        public static TechnicalRatingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TechnicalRatingStatus() { Pointer= p0 };

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 SongLevel                   ( ModelPrimitiveType int int int Int32 )
            value.TechnicalScore                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 TechnicalScore              ( ModelPrimitiveType int int int Int32 )
            value.Rating                                    = GetSingle(new IntPtr(p + 0x028)); // 0x28 Rating                      ( ModelPrimitiveType float float float Single )
            value.RatingTheoreticalValue                    = GetSingle(new IntPtr(p + 0x02C)); // 0x2C RatingTheoreticalValue      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
