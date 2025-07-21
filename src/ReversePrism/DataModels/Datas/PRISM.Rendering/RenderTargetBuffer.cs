using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EffectBuffer                             ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 018 OpaqueBuffer                             ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class RenderTargetBuffer : DataModel
    {
        public RenderTexture?                           EffectBuffer                            { get; set; }
        public RenderTexture?                           OpaqueBuffer                            { get; set; }

        public static RenderTargetBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderTargetBuffer() { Pointer= p0 };

            value.EffectBuffer                              = GetObject<RenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x10 EffectBuffer                ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.OpaqueBuffer                              = GetObject<RenderTexture>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x18 OpaqueBuffer                ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
