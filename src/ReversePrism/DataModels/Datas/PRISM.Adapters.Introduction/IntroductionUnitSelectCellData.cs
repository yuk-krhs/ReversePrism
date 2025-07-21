using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 018 CellTitle                                ModelPrimitiveType string string string String
    public partial class IntroductionUnitSelectCellData : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   CellTitle                               { get; set; }

        public static IntroductionUnitSelectCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitSelectCellData() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.CellTitle                                 = GetString(new IntPtr(p + 0x018)); // 0x18 CellTitle                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
