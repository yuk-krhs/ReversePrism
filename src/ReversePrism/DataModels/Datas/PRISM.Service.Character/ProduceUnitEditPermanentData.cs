using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 014 UnitNumber                               ModelPrimitiveType int int int Int32
    public partial class ProduceUnitEditPermanentData : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public int                                      UnitNumber                              { get; set; }

        public static ProduceUnitEditPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditPermanentData() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 UnitNumber                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
