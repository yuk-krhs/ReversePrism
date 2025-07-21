using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 W                                        ModelPrimitiveType int int int Int32
    // 014 H                                        ModelPrimitiveType int int int Int32
    // 018 Samples                                  ModelPrimitiveType int int int Int32
    // 01C DepthID                                  ModelPrimitiveType int int int Int32
    public partial class RenderPassDescriptor : DataModel
    {
        public int                                      W                                       { get; set; }
        public int                                      H                                       { get; set; }
        public int                                      Samples                                 { get; set; }
        public int                                      DepthID                                 { get; set; }

        public static RenderPassDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderPassDescriptor() { Pointer= p0 };

            value.W                                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 W                           ( ModelPrimitiveType int int int Int32 )
            value.H                                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 H                           ( ModelPrimitiveType int int int Int32 )
            value.Samples                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Samples                     ( ModelPrimitiveType int int int Int32 )
            value.DepthID                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C DepthID                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
