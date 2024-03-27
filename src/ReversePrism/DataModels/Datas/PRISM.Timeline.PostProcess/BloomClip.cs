using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186767280 ModelClassType BloomBehaviour BloomBehaviour BloomBehaviour Pointer
    public partial class BloomClip
    {
        public BloomBehaviour?                          Behaviour                               { get; set; }

        public static BloomClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BloomClip();

            value.Behaviour                                 = GetObject<BloomBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.BloomBehaviour.FromPointer); // 0270D5074918 0x18 Behaviour                   ( 000186767280 ModelClassType BloomBehaviour BloomBehaviour BloomBehaviour Pointer )

            return value;
        }
    }
}
