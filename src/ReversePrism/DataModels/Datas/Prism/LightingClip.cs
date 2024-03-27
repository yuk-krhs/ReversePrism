using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186528E10 ModelClassType LightingBehaviour LightingBehaviour LightingBehaviour Pointer
    public partial class LightingClip
    {
        public LightingBehaviour?                       Behaviour                               { get; set; }

        public static LightingClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightingClip();

            value.Behaviour                                 = GetObject<LightingBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.LightingBehaviour.FromPointer); // 027006B65150 0x18 Behaviour                   ( 000186528E10 ModelClassType LightingBehaviour LightingBehaviour LightingBehaviour Pointer )

            return value;
        }
    }
}
