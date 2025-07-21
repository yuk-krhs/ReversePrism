using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Texture                                  ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class DisposableRenderTexture : DataModel
    {
        public RenderTexture?                           Texture                                 { get; set; }

        public static DisposableRenderTexture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisposableRenderTexture() { Pointer= p0 };

            value.Texture                                   = GetObject<RenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x10 Texture                     ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
