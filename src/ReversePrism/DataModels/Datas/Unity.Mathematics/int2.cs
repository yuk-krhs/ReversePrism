using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType int int int Int32
    // 014 Y                                        ModelPrimitiveType int int int Int32
    // 000 zero                                     int2 IL2CPP_TYPE_VALUETYPE
    public partial class int2 : DataModel
    {
        public int                                      X                                       { get; set; }
        public int                                      Y                                       { get; set; }

        public static int2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int2() { Pointer= p0 };

            value.X                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType int int int Int32 )
            value.Y                                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
