using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BoneIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 OffsetY                                  000186666050 ModelPrimitiveType float float float Single
    // 018 RangeRadius                              000186666050 ModelPrimitiveType float float float Single
    public partial class ShootingTypeTable : DataModel
    {
        public int                                      BoneIndex                               { get; set; }
        public float                                    OffsetY                                 { get; set; }
        public float                                    RangeRadius                             { get; set; }

        public static ShootingTypeTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShootingTypeTable() { Pointer= p0 };

            value.BoneIndex                                 = GetInt32(new IntPtr(p + 0x010)); // 0245A6ABC530 0x10 BoneIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OffsetY                                   = GetSingle(new IntPtr(p + 0x014)); // 0245A6ABC550 0x14 OffsetY                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.RangeRadius                               = GetSingle(new IntPtr(p + 0x018)); // 0245A6ABC570 0x18 RangeRadius                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
