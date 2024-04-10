using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Overlay                                  0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class OverlayInputBlocker : DataModel
    {
        public Image?                                   Overlay                                 { get; set; }

        public static OverlayInputBlocker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OverlayInputBlocker() { Pointer= p0 };

            value.Overlay                                   = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0245A1E9C9C8 0x20 Overlay                     ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
