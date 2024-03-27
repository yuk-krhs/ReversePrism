using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaScharaEffectsDirection              0001866195B0 ModelClassType GashaScharaEffectsDirection GashaScharaEffectsDirection GashaScharaEffectsDirection Pointer
    public partial class GashaS3Setting
    {
        public GashaScharaEffectsDirection?             GashaScharaEffectsDirection             { get; set; }

        public static GashaS3Setting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaS3Setting();

            value.GashaScharaEffectsDirection               = GetObject<GashaScharaEffectsDirection>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaScharaEffectsDirection.FromPointer); // 0270D53B7C50 0x20 GashaScharaEffectsDirection ( 0001866195B0 ModelClassType GashaScharaEffectsDirection GashaScharaEffectsDirection GashaScharaEffectsDirection Pointer )

            return value;
        }
    }
}
