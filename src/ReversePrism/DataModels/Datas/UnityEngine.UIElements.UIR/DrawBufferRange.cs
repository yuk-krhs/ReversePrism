using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstIndex                               ModelPrimitiveType int int int Int32
    // 014 IndexCount                               ModelPrimitiveType int int int Int32
    // 018 MinIndexVal                              ModelPrimitiveType int int int Int32
    // 01C VertsReferenced                          ModelPrimitiveType int int int Int32
    public partial class DrawBufferRange : DataModel
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
            var value   = new DrawBufferRange() { Pointer= p0 };

            value.FirstIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 FirstIndex                  ( ModelPrimitiveType int int int Int32 )
            value.IndexCount                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 IndexCount                  ( ModelPrimitiveType int int int Int32 )
            value.MinIndexVal                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 MinIndexVal                 ( ModelPrimitiveType int int int Int32 )
            value.VertsReferenced                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C VertsReferenced             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
