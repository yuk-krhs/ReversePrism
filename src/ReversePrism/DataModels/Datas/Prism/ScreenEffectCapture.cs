using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderTexture                            ModelClassType DisposableRenderTexture DisposableRenderTexture DisposableRenderTexture Pointer
    // 018 CaptureName                              ModelPrimitiveType string string string String
    // 020 Scale                                    ModelPrimitiveType float float float Single
    public partial class ScreenEffectCapture : DataModel
    {
        public DisposableRenderTexture?                 RenderTexture                           { get; set; }
        public string                                   CaptureName                             { get; set; }
        public float                                    Scale                                   { get; set; }

        public static ScreenEffectCapture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEffectCapture() { Pointer= p0 };

            value.RenderTexture                             = GetObject<DisposableRenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.DisposableRenderTexture.FromPointer); // 0x10 RenderTexture               ( ModelClassType DisposableRenderTexture DisposableRenderTexture DisposableRenderTexture Pointer )
            value.CaptureName                               = GetString(new IntPtr(p + 0x018)); // 0x18 CaptureName                 ( ModelPrimitiveType string string string String )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x020)); // 0x20 Scale                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
