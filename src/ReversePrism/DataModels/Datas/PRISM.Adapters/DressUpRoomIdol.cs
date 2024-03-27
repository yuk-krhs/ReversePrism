using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Costume                                  00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    public partial class DressUpRoomIdol
    {
        public int                                      CharacterId                             { get; set; }
        public CharacterCostume?                        Costume                                 { get; set; }

        public static DressUpRoomIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomIdol();

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0270D622ABD8 0x10 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Costume                                   = GetObject<CharacterCostume>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0270D622ABF8 0x18 Costume                     ( 00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )

            return value;
        }
    }
}
