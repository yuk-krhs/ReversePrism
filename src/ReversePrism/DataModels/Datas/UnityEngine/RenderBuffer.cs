using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RenderTextureInstanceID                ModelPrimitiveType int int int Int32
    // 018 m_BufferPtr                              <int> IL2CPP_TYPE_I
    public partial class RenderBuffer : DataModel
    {
        public int                                      M_RenderTextureInstanceID               { get; set; }

        public static RenderBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderBuffer() { Pointer= p0 };

            value.M_RenderTextureInstanceID                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_RenderTextureInstanceID   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
