using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicData                                ModelClassType MusicData MusicData MusicData Pointer
    // 018 MusicDifficulty                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 020 BackgroundImagePath                      ModelPrimitiveType string string string String
    // 028 UnitId                                   ModelPrimitiveType int int int Int32
    // 02C IdolPosition                             ModelPrimitiveType int int int Int32
    // 030 ShowUnitBonus                            ModelPrimitiveType bool bool bool Bool
    // 031 IsLimitedVocalSeparated                  ModelPrimitiveType bool bool bool Bool
    public partial class JumpParameter : DataModel
    {
        public MusicData?                               MusicData                               { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public string                                   BackgroundImagePath                     { get; set; }
        public int                                      UnitId                                  { get; set; }
        public int                                      IdolPosition                            { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }
        public bool                                     IsLimitedVocalSeparated                 { get; set; }

        public static JumpParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JumpParameter() { Pointer= p0 };

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicData.FromPointer); // 0x10 MusicData                   ( ModelClassType MusicData MusicData MusicData Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 MusicDifficulty             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.BackgroundImagePath                       = GetString(new IntPtr(p + 0x020)); // 0x20 BackgroundImagePath         ( ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.IdolPosition                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IdolPosition                ( ModelPrimitiveType int int int Int32 )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x030)); // 0x30 ShowUnitBonus               ( ModelPrimitiveType bool bool bool Bool )
            value.IsLimitedVocalSeparated                   = GetBool(new IntPtr(p + 0x031)); // 0x31 IsLimitedVocalSeparated     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
