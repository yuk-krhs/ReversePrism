using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Infinity                                 int IL2CPP_TYPE_I4
    // 010 M_Type                                   00018652C6C0 ModelEnumType ExpressionMultiplierType ExpressionMultiplierType ExpressionMultiplierType Int32
    // 014 Min                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Max                                      0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ExpressionMultiplier
    {
        public ExpressionMultiplierType                 M_Type                                  { get; set; }
        public int                                      Min                                     { get; set; }
        public int                                      Max                                     { get; set; }

        public static ExpressionMultiplier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionMultiplier();

            value.M_Type                                    = (ExpressionMultiplierType)GetInt32(new IntPtr(p + 0x010)); // 027006888A40 0x10 M_Type                      ( 00018652C6C0 ModelEnumType ExpressionMultiplierType ExpressionMultiplierType ExpressionMultiplierType Int32 )
            value.Min                                       = GetInt32(new IntPtr(p + 0x014)); // 027006888A60 0x14 Min                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x018)); // 027006888A80 0x18 Max                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
