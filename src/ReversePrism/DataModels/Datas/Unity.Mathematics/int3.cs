using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Y                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Z                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 000 zero                                     int3 IL2CPP_TYPE_VALUETYPE
    public partial class int3 : DataModel
    {
        public int                                      X                                       { get; set; }
        public int                                      Y                                       { get; set; }
        public int                                      Z                                       { get; set; }

        public static int3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int3() { Pointer= p0 };

            value.X                                         = GetInt32(new IntPtr(p + 0x010)); // 0245A15ADE78 0x10 X                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Y                                         = GetInt32(new IntPtr(p + 0x014)); // 0245A15ADE98 0x14 Y                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Z                                         = GetInt32(new IntPtr(p + 0x018)); // 0245A15ADEB8 0x18 Z                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
