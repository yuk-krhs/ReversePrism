using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType RadialBlurBehaviour RadialBlurBehaviour RadialBlurBehaviour Pointer
    public partial class RadialBlurClip : DataModel
    {
        public RadialBlurBehaviour?                     Behaviour                               { get; set; }

        public static RadialBlurClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RadialBlurClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<RadialBlurBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.RadialBlurBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType RadialBlurBehaviour RadialBlurBehaviour RadialBlurBehaviour Pointer )

            return value;
        }
    }
}
