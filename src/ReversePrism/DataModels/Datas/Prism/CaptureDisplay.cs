using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Renderer                                 ModelClassType Renderer Renderer Renderer Pointer
    // 028 KeepReserveBuffer                        ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class CaptureDisplay : DataModel
    {
        public Renderer?                                Renderer                                { get; set; }
        public RenderTexture?                           KeepReserveBuffer                       { get; set; }

        public static CaptureDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaptureDisplay() { Pointer= p0 };

            value.Renderer                                  = GetObject<Renderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.Renderer.FromPointer); // 0x20 Renderer                    ( ModelClassType Renderer Renderer Renderer Pointer )
            value.KeepReserveBuffer                         = GetObject<RenderTexture>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x28 KeepReserveBuffer           ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
