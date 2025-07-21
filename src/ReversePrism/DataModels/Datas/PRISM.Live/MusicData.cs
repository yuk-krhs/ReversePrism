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
    // 020 Song                                     ModelClassType ISongStatus ISongStatus ISongStatus Pointer
    // 028 Master                                   ModelClassType MstSong MstSong MstSong Pointer
    // 030 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 031 IsOnceDisplayed                          ModelPrimitiveType bool bool bool Bool
    // 032 IsOnceClearedAnyDifficulty               ModelPrimitiveType bool bool bool Bool
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

            value.Song                                      = GetObject<ISongStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISongStatus.FromPointer); // 0x20 Song                        ( ModelClassType ISongStatus ISongStatus ISongStatus Pointer )
            value.Master                                    = GetObject<MstSong>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstSong.FromPointer); // 0x28 Master                      ( ModelClassType MstSong MstSong MstSong Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x030)); // 0x30 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsOnceDisplayed                           = GetBool(new IntPtr(p + 0x031)); // 0x31 IsOnceDisplayed             ( ModelPrimitiveType bool bool bool Bool )
            value.IsOnceClearedAnyDifficulty                = GetBool(new IntPtr(p + 0x032)); // 0x32 IsOnceClearedAnyDifficulty  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
