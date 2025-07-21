using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Infinity                                 int IL2CPP_TYPE_I4
    // 010 M_Type                                   ModelEnumType ExpressionMultiplierType ExpressionMultiplierType ExpressionMultiplierType Int32
    // 014 Min                                      ModelPrimitiveType int int int Int32
    // 018 Max                                      ModelPrimitiveType int int int Int32
    public partial class ExpressionMultiplier : DataModel
    {
        public ExpressionMultiplierType                 M_Type                                  { get; set; }
        public int                                      Min                                     { get; set; }
        public int                                      Max                                     { get; set; }

        public static ExpressionMultiplier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionMultiplier() { Pointer= p0 };

            value.M_Type                                    = (ExpressionMultiplierType)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Type                      ( ModelEnumType ExpressionMultiplierType ExpressionMultiplierType ExpressionMultiplierType Int32 )
            value.Min                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 Min                         ( ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Max                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
