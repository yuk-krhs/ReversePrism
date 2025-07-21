using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType SoftOverlayBehaviour SoftOverlayBehaviour SoftOverlayBehaviour Pointer
    public partial class SoftOverlayClip : DataModel
    {
        public SoftOverlayBehaviour?                    Behaviour                               { get; set; }

        public static SoftOverlayClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftOverlayClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<SoftOverlayBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SoftOverlayBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType SoftOverlayBehaviour SoftOverlayBehaviour SoftOverlayBehaviour Pointer )

            return value;
        }
    }
}
