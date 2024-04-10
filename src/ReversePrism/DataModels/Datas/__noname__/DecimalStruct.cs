using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDecimal                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Dvalue                                   000185B7C4F0 ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer
    public partial class DecimalStruct : DataModel
    {
        public bool                                     IsDecimal                               { get; set; }
        public List<Decimal>?                           Dvalue                                  { get; set; }

        public static DecimalStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecimalStruct() { Pointer= p0 };

            value.IsDecimal                                 = GetBool(new IntPtr(p + 0x010)); // 02466755A8A8 0x10 IsDecimal                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Dvalue                                    = GetEnumList<Decimal>(new IntPtr(p + 0x018)); // 02466755A8C8 0x18 Dvalue                      ( 000185B7C4F0 ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer )

            return value;
        }
    }
}
