using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_cachedEventAttribute                   000186762990 ModelClassType VFXEventAttribute VFXEventAttribute VFXEventAttribute Pointer
    // 020 outputEventReceived                      Action`1<VFXOutputEventArgs> IL2CPP_TYPE_GENERICINST
    public partial class VisualEffect
    {
        public VFXEventAttribute?                       M_cachedEventAttribute                  { get; set; }

        public static VisualEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualEffect();

            value.M_cachedEventAttribute                    = GetObject<VFXEventAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.VFXEventAttribute.FromPointer); // 0270021A52B8 0x18 M_cachedEventAttribute      ( 000186762990 ModelClassType VFXEventAttribute VFXEventAttribute VFXEventAttribute Pointer )

            return value;
        }
    }
}
