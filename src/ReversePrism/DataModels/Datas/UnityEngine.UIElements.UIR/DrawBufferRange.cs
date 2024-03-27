using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 IndexCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MinIndexVal                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C VertsReferenced                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class DrawBufferRange
    {
        public int                                      FirstIndex                              { get; set; }
        public int                                      IndexCount                              { get; set; }
        public int                                      MinIndexVal                             { get; set; }
        public int                                      VertsReferenced                         { get; set; }

        public static DrawBufferRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawBufferRange();

            value.FirstIndex                                = GetInt32(new IntPtr(p + 0x010)); // 02700685F3A0 0x10 FirstIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x014)); // 02700685F3C0 0x14 IndexCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinIndexVal                               = GetInt32(new IntPtr(p + 0x018)); // 02700685F3E0 0x18 MinIndexVal                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VertsReferenced                           = GetInt32(new IntPtr(p + 0x01C)); // 02700685F400 0x1C VertsReferenced             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
