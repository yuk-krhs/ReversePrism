using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IntervalBit                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RuntimeElement : DataModel
    {
        public int                                      IntervalBit                             { get; set; }

        public static RuntimeElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeElement() { Pointer= p0 };

            value.IntervalBit                               = GetInt32(new IntPtr(p + 0x010)); // 02466B2A87C8 0x10 IntervalBit                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
