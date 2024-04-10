using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Slot                                     0001865F4760 ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 020 <MusicIds>k__BackingField                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class FavoriteMusicGroup : DataModel
    {
        public FavoriteSongSlot                         Slot                                    { get; set; }
        public string                                   Name                                    { get; set; }

        public static FavoriteMusicGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteMusicGroup() { Pointer= p0 };

            value.Slot                                      = (FavoriteSongSlot)GetInt32(new IntPtr(p + 0x010)); // 0246651A8408 0x10 Slot                        ( 0001865F4760 ModelEnumType FavoriteSongSlot FavoriteSongSlot FavoriteSongSlot Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0246651A8428 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
