using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ValueType                              ModelEnumType StyleValueType StyleValueType StyleValueType Int32
    // 014 ValueIndex                               ModelPrimitiveType int int int Int32
    public partial class StyleValueHandle : DataModel
    {
        public StyleValueType                           M_ValueType                             { get; set; }
        public int                                      ValueIndex                              { get; set; }

        public static StyleValueHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleValueHandle() { Pointer= p0 };

            value.M_ValueType                               = (StyleValueType)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ValueType                 ( ModelEnumType StyleValueType StyleValueType StyleValueType Int32 )
            value.ValueIndex                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 ValueIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
