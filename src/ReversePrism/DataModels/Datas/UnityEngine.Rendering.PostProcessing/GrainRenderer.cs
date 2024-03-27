using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_GrainLookupRT                          000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 000 k_SampleCount                            int IL2CPP_TYPE_I4
    // 028 M_SampleIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GrainRenderer
    {
        public RenderTexture?                           M_GrainLookupRT                         { get; set; }
        public int                                      M_SampleIndex                           { get; set; }

        public static GrainRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GrainRenderer();

            value.M_GrainLookupRT                           = GetObject<RenderTexture>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderTexture.FromPointer); // 02700657B2A8 0x20 M_GrainLookupRT             ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_SampleIndex                             = GetInt32(new IntPtr(p + 0x028)); // 02700657B2E8 0x28 M_SampleIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
