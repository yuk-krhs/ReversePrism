using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicMaster                              ModelClassType MstSong MstSong MstSong Pointer
    // 018 MusicDifficulty                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 01C MusicLevel                               ModelPrimitiveType int int int Int32
    // 020 Score                                    ModelPrimitiveType int int int Int32
    // 024 Rate                                     ModelPrimitiveType float float float Single
    // 028 MaxRate                                  ModelPrimitiveType float float float Single
    // 02C IsTechnicalRate                          ModelPrimitiveType bool bool bool Bool
    public partial class MusicRateTargetMusicListCellData : DataModel
    {
        public MstSong?                                 MusicMaster                             { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public int                                      MusicLevel                              { get; set; }
        public int                                      Score                                   { get; set; }
        public float                                    Rate                                    { get; set; }
        public float                                    MaxRate                                 { get; set; }
        public bool                                     IsTechnicalRate                         { get; set; }

        public static MusicRateTargetMusicListCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateTargetMusicListCellData() { Pointer= p0 };

            value.MusicMaster                               = GetObject<MstSong>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstSong.FromPointer); // 0x10 MusicMaster                 ( ModelClassType MstSong MstSong MstSong Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 MusicDifficulty             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MusicLevel                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MusicLevel                  ( ModelPrimitiveType int int int Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Score                       ( ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 Rate                        ( ModelPrimitiveType float float float Single )
            value.MaxRate                                   = GetSingle(new IntPtr(p + 0x028)); // 0x28 MaxRate                     ( ModelPrimitiveType float float float Single )
            value.IsTechnicalRate                           = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsTechnicalRate             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
