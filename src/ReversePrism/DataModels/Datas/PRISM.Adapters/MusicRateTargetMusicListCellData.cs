using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicMaster                              00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer
    // 018 MusicDifficulty                          00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 01C MusicLevel                               0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Score                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 024 Rate                                     000186666CB0 ModelPrimitiveType float float float Single
    // 028 MaxRate                                  000186666CB0 ModelPrimitiveType float float float Single
    // 02C IsTechnicalRate                          0001865965D0 ModelPrimitiveType bool bool bool Bool
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

            value.MusicMaster                               = GetObject<MstSong>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstSong.FromPointer); // 02466645BB98 0x10 MusicMaster                 ( 00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 02466645BBB8 0x18 MusicDifficulty             ( 00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MusicLevel                                = GetInt32(new IntPtr(p + 0x01C)); // 02466645BBD8 0x1C MusicLevel                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x020)); // 02466645BBF8 0x20 Score                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x024)); // 02466645BC18 0x24 Rate                        ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.MaxRate                                   = GetSingle(new IntPtr(p + 0x028)); // 02466645BC38 0x28 MaxRate                     ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.IsTechnicalRate                           = GetBool(new IntPtr(p + 0x02C)); // 02466645BC58 0x2C IsTechnicalRate             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
