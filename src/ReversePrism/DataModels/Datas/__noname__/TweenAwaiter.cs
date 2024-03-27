using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tween                                    0001866BF4B0 ModelClassType Tween Tween Tween Pointer
    public partial class TweenAwaiter
    {
        public Tween?                                   Tween                                   { get; set; }

        public static TweenAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenAwaiter();

            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 027005AB8330 0x10 Tween                       ( 0001866BF4B0 ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
