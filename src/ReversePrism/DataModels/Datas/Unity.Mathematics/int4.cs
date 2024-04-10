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
    // 01C W                                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 000 zero                                     int4 IL2CPP_TYPE_VALUETYPE
    public partial class int4 : DataModel
    {
        public int                                      X                                       { get; set; }
        public int                                      Y                                       { get; set; }
        public int                                      Z                                       { get; set; }
        public int                                      W                                       { get; set; }

        public static int4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int4() { Pointer= p0 };

            value.X                                         = GetInt32(new IntPtr(p + 0x010)); // 0245A15B6808 0x10 X                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Y                                         = GetInt32(new IntPtr(p + 0x014)); // 0245A15B6828 0x14 Y                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Z                                         = GetInt32(new IntPtr(p + 0x018)); // 0245A15B6848 0x18 Z                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.W                                         = GetInt32(new IntPtr(p + 0x01C)); // 0245A15B6868 0x1C W                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
