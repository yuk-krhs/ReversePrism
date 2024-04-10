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
    public partial class JumpParameter : DataModel
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
            var value   = new JumpParameter() { Pointer= p0 };

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicData.FromPointer); // 024665325978 0x10 MusicData                   ( 000186665050 ModelClassType MusicData MusicData MusicData Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 024665325998 0x18 MusicDifficulty             ( 00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.BackgroundImagePath                       = GetString(new IntPtr(p + 0x020)); // 0246653259B8 0x20 BackgroundImagePath         ( 000186672F10 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0246653259D8 0x28 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolPosition                              = GetInt32(new IntPtr(p + 0x02C)); // 0246653259F8 0x2C IdolPosition                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x030)); // 024665325A18 0x30 ShowUnitBonus               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
