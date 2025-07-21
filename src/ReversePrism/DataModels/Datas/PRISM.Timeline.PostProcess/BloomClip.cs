using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType BloomBehaviour BloomBehaviour BloomBehaviour Pointer
    public partial class BloomClip : DataModel
    {
        public BloomBehaviour?                          Behaviour                               { get; set; }

        public static BloomClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BloomClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<BloomBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.BloomBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType BloomBehaviour BloomBehaviour BloomBehaviour Pointer )

            return value;
        }
    }
}
