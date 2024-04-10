using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CellTitle                                000186672F10 ModelPrimitiveType string string string String
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

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0246668A0320 0x10 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CellTitle                                 = GetString(new IntPtr(p + 0x018)); // 0246668A0340 0x18 CellTitle                   ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
