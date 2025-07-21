using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Size                                     ModelPrimitiveType int int int Int32
    // 014 OffsetObjectToWorld                      ModelPrimitiveType int int int Int32
    // 018 OffsetPrevObjectToWorld                  ModelPrimitiveType int int int Int32
    // 01C OffsetRenderingLayerMask                 ModelPrimitiveType int int int Int32
    public partial class RenderInstancedDataLayout : DataModel
    {
        public int                                      Size                                    { get; set; }
        public int                                      OffsetObjectToWorld                     { get; set; }
        public int                                      OffsetPrevObjectToWorld                 { get; set; }
        public int                                      OffsetRenderingLayerMask                { get; set; }

        public static RenderInstancedDataLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderInstancedDataLayout() { Pointer= p0 };

            value.Size                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Size                        ( ModelPrimitiveType int int int Int32 )
            value.OffsetObjectToWorld                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 OffsetObjectToWorld         ( ModelPrimitiveType int int int Int32 )
            value.OffsetPrevObjectToWorld                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 OffsetPrevObjectToWorld     ( ModelPrimitiveType int int int Int32 )
            value.OffsetRenderingLayerMask                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C OffsetRenderingLayerMask    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
