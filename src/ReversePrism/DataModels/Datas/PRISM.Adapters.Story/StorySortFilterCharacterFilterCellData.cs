using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 isLocked                                 ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 isSelected                               ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 024 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class StorySortFilterCharacterFilterCellData : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static StorySortFilterCharacterFilterCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterCharacterFilterCellData() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x020)); // 02466681F010 0x20 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x024)); // 02466681F030 0x24 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
