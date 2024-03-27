using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicData                                000186665050 ModelClassType MusicData MusicData MusicData Pointer
    // 018 MusicDifficulty                          00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 020 BackgroundImagePath                      000186672F10 ModelPrimitiveType string string string String
    // 028 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 02C IdolPosition                             0001865F4260 ModelPrimitiveType int int int Int32
    // 030 ShowUnitBonus                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class JumpParameter
    {
        public MusicData?                               MusicData                               { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public string                                   BackgroundImagePath                     { get; set; }
        public int                                      UnitId                                  { get; set; }
        public int                                      IdolPosition                            { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }

        public static JumpParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JumpParameter();

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicData.FromPointer); // 0270D52B2088 0x10 MusicData                   ( 000186665050 ModelClassType MusicData MusicData MusicData Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0270D52B20A8 0x18 MusicDifficulty             ( 00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.BackgroundImagePath                       = GetString(new IntPtr(p + 0x020)); // 0270D52B20C8 0x20 BackgroundImagePath         ( 000186672F10 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D52B20E8 0x28 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolPosition                              = GetInt32(new IntPtr(p + 0x02C)); // 0270D52B2108 0x2C IdolPosition                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x030)); // 0270D52B2128 0x30 ShowUnitBonus               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
