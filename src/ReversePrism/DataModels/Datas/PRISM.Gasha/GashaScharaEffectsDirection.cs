using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplateScharaEffects                  000186618EB0 ModelClassType GashaScharaEffects GashaScharaEffects GashaScharaEffects Pointer
    public partial class GashaScharaEffectsDirection : DataModel
    {
        public GashaScharaEffects?                      GoTemplateScharaEffects                 { get; set; }

        public static GashaScharaEffectsDirection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaScharaEffectsDirection() { Pointer= p0 };

            value.GoTemplateScharaEffects                   = GetObject<GashaScharaEffects>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaScharaEffects.FromPointer); // 024664E279E0 0x20 GoTemplateScharaEffects     ( 000186618EB0 ModelClassType GashaScharaEffects GashaScharaEffects GashaScharaEffects Pointer )

            return value;
        }
    }
}
