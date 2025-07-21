using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 Costume                                  ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    public partial class LiveMVIdol : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public CharacterCostume?                        Costume                                 { get; set; }

        public static LiveMVIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVIdol() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.Costume                                   = GetObject<CharacterCostume>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0x18 Costume                     ( ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )

            return value;
        }
    }
}
