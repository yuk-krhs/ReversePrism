using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BoneIndex                                ModelPrimitiveType int int int Int32
    // 014 OffsetY                                  ModelPrimitiveType float float float Single
    // 018 RangeRadius                              ModelPrimitiveType float float float Single
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

            value.BoneIndex                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 BoneIndex                   ( ModelPrimitiveType int int int Int32 )
            value.OffsetY                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 OffsetY                     ( ModelPrimitiveType float float float Single )
            value.RangeRadius                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 RangeRadius                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
