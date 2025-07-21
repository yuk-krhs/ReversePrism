using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EffectBufferID                           ModelPrimitiveType int int int Int32
    // 014 ShadowBufferID                           ModelPrimitiveType int int int Int32
    // 018 DepthBufferID                            ModelPrimitiveType int int int Int32
    public partial class BufferIDs : DataModel
    {
        public int                                      EffectBufferID                          { get; set; }
        public int                                      ShadowBufferID                          { get; set; }
        public int                                      DepthBufferID                           { get; set; }

        public static BufferIDs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferIDs() { Pointer= p0 };

            value.EffectBufferID                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 EffectBufferID              ( ModelPrimitiveType int int int Int32 )
            value.ShadowBufferID                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 ShadowBufferID              ( ModelPrimitiveType int int int Int32 )
            value.DepthBufferID                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 DepthBufferID               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
