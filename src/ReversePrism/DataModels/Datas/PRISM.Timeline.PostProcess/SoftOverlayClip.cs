using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186527530 ModelClassType SoftOverlayBehaviour SoftOverlayBehaviour SoftOverlayBehaviour Pointer
    public partial class SoftOverlayClip
    {
        public SoftOverlayBehaviour?                    Behaviour                               { get; set; }

        public static SoftOverlayClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftOverlayClip();

            value.Behaviour                                 = GetObject<SoftOverlayBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SoftOverlayBehaviour.FromPointer); // 0270D50760C8 0x18 Behaviour                   ( 000186527530 ModelClassType SoftOverlayBehaviour SoftOverlayBehaviour SoftOverlayBehaviour Pointer )

            return value;
        }
    }
}
