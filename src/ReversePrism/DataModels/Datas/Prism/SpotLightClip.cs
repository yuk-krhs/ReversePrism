using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType SpotLightBehaviour SpotLightBehaviour SpotLightBehaviour Pointer
    public partial class SpotLightClip : DataModel
    {
        public SpotLightBehaviour?                      Behaviour                               { get; set; }

        public static SpotLightClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpotLightClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<SpotLightBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpotLightBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType SpotLightBehaviour SpotLightBehaviour SpotLightBehaviour Pointer )

            return value;
        }
    }
}
