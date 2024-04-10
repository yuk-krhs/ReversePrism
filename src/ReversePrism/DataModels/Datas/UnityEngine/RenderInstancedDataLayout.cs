using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Size                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 014 OffsetObjectToWorld                      0001865F4260 ModelPrimitiveType int int int Int32
    // 018 OffsetPrevObjectToWorld                  0001865F4260 ModelPrimitiveType int int int Int32
    // 01C OffsetRenderingLayerMask                 0001865F4260 ModelPrimitiveType int int int Int32
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

            value.Size                                      = GetInt32(new IntPtr(p + 0x010)); // 0245A65C2688 0x10 Size                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OffsetObjectToWorld                       = GetInt32(new IntPtr(p + 0x014)); // 0245A65C26A8 0x14 OffsetObjectToWorld         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OffsetPrevObjectToWorld                   = GetInt32(new IntPtr(p + 0x018)); // 0245A65C26C8 0x18 OffsetPrevObjectToWorld     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OffsetRenderingLayerMask                  = GetInt32(new IntPtr(p + 0x01C)); // 0245A65C26E8 0x1C OffsetRenderingLayerMask    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
