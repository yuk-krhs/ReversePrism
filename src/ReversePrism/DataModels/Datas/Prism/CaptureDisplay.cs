using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Renderer                                 00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 028 KeepReserveBuffer                        000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    public partial class CaptureDisplay
    {
        public Renderer?                                Renderer                                { get; set; }
        public RenderTexture?                           KeepReserveBuffer                       { get; set; }

        public static CaptureDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaptureDisplay();

            value.Renderer                                  = GetObject<Renderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.Renderer.FromPointer); // 0270D4E4BE08 0x20 Renderer                    ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.KeepReserveBuffer                         = GetObject<RenderTexture>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderTexture.FromPointer); // 0270D4E4BE28 0x28 KeepReserveBuffer           ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )

            return value;
        }
    }
}
