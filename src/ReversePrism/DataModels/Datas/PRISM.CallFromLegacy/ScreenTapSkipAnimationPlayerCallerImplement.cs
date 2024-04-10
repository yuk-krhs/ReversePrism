using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Player                                   0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    public partial class ScreenTapSkipAnimationPlayerCallerImplement : DataModel
    {
        public ScreenTapSkipAnimationPlayer?            Player                                  { get; set; }

        public static ScreenTapSkipAnimationPlayerCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenTapSkipAnimationPlayerCallerImplement() { Pointer= p0 };

            value.Player                                    = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 02466BA6BF50 0x20 Player                      ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )

            return value;
        }
    }
}
