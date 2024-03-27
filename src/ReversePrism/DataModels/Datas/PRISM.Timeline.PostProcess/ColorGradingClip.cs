using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001865CE070 ModelClassType ColorGradingBehaviour ColorGradingBehaviour ColorGradingBehaviour Pointer
    public partial class ColorGradingClip
    {
        public ColorGradingBehaviour?                   Behaviour                               { get; set; }

        public static ColorGradingClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingClip();

            value.Behaviour                                 = GetObject<ColorGradingBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ColorGradingBehaviour.FromPointer); // 0270D5074E18 0x18 Behaviour                   ( 0001865CE070 ModelClassType ColorGradingBehaviour ColorGradingBehaviour ColorGradingBehaviour Pointer )

            return value;
        }
    }
}
