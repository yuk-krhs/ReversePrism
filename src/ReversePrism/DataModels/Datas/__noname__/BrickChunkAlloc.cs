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
    public partial class BrickChunkAlloc
    {
        public int                                      X                                       { get; set; }
        public int                                      Y                                       { get; set; }
        public int                                      Z                                       { get; set; }

        public static BrickChunkAlloc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrickChunkAlloc();

            value.X                                         = GetInt32(new IntPtr(p + 0x010)); // 0270D91E0370 0x10 X                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Y                                         = GetInt32(new IntPtr(p + 0x014)); // 0270D91E0390 0x14 Y                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Z                                         = GetInt32(new IntPtr(p + 0x018)); // 0270D91E03B0 0x18 Z                           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
