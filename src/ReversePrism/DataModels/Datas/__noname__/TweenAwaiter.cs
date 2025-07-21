using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tween                                    ModelClassType Tween Tween Tween Pointer
    public partial class TweenAwaiter : DataModel
    {
        public Tween?                                   Tween                                   { get; set; }

        public static TweenAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenAwaiter() { Pointer= p0 };

            value.Tween                                     = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0x10 Tween                       ( ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
