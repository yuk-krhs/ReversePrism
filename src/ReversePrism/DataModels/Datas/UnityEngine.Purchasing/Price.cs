using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001865C0E90 ModelEnumType Decimal Decimal Decimal Int32
    // 020 Data                                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 Num                                      0001865C2950 ModelPrimitiveType double double double Double
    public partial class Price : DataModel
    {
        public Decimal                                  Value                                   { get; set; }
        public List<int>?                               Data                                    { get; set; }
        public double                                   Num                                     { get; set; }

        public static Price? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Price() { Pointer= p0 };

            value.Value                                     = (Decimal)GetInt32(new IntPtr(p + 0x010)); // 0245A68DC638 0x10 Value                       ( 0001865C0E90 ModelEnumType Decimal Decimal Decimal Int32 )
            value.Data                                      = GetInt32List(new IntPtr(p + 0x020)); // 0245A68DC658 0x20 Data                        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Num                                       = GetDouble(new IntPtr(p + 0x028)); // 0245A68DC678 0x28 Num                         ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
