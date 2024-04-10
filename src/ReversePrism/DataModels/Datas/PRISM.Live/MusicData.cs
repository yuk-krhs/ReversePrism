using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 difficultyLevelDic                       Dictionary`2<SongDifficultyLevel, ISongDifficultyLevelStatus> IL2CPP_TYPE_GENERICINST
    // 018 favoriteMusicGroups                      IEnumerable`1<FavoriteMusicGroup> IL2CPP_TYPE_GENERICINST
    // 020 clearStatusLampTypeDic                   Dictionary`2<SongDifficultyLevel, MusicClearStatusLampType> IL2CPP_TYPE_GENERICINST
    // 028 Song                                     000186649210 ModelClassType ISongStatus ISongStatus ISongStatus Pointer
    // 030 Master                                   00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer
    // 038 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 IsOnceDisplayed                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A IsOnceClearedAnyDifficulty               0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class MusicData : DataModel
    {
        public ISongStatus?                             Song                                    { get; set; }
        public MstSong?                                 Master                                  { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsOnceDisplayed                         { get; set; }
        public bool                                     IsOnceClearedAnyDifficulty              { get; set; }

        public static MusicData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicData() { Pointer= p0 };

            value.Song                                      = GetObject<ISongStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISongStatus.FromPointer); // 0245A15F8560 0x28 Song                        ( 000186649210 ModelClassType ISongStatus ISongStatus ISongStatus Pointer )
            value.Master                                    = GetObject<MstSong>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstSong.FromPointer); // 0245A15F8580 0x30 Master                      ( 00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x038)); // 0245A15F85A0 0x38 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsOnceDisplayed                           = GetBool(new IntPtr(p + 0x039)); // 0245A15F85C0 0x39 IsOnceDisplayed             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsOnceClearedAnyDifficulty                = GetBool(new IntPtr(p + 0x03A)); // 0245A15F85E0 0x3A IsOnceClearedAnyDifficulty  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
