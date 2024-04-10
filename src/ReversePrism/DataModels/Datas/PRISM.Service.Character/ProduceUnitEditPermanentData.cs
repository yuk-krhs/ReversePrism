using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0245A3A77648 0x10 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x014)); // 0245A3A77668 0x14 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
