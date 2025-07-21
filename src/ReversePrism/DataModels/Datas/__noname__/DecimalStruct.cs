using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDecimal                                ModelPrimitiveType bool bool bool Bool
    // 018 Dvalue                                   ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer
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

            value.IsDecimal                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IsDecimal                   ( ModelPrimitiveType bool bool bool Bool )
            value.Dvalue                                    = GetEnumList<Decimal>(new IntPtr(p + 0x018)); // 0x18 Dvalue                      ( ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer )

            return value;
        }
    }
}
