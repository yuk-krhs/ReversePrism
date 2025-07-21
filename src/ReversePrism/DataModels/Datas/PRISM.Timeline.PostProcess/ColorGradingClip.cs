using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType ColorGradingBehaviour ColorGradingBehaviour ColorGradingBehaviour Pointer
    public partial class ColorGradingClip : DataModel
    {
        public ColorGradingBehaviour?                   Behaviour                               { get; set; }

        public static ColorGradingClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<ColorGradingBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ColorGradingBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType ColorGradingBehaviour ColorGradingBehaviour ColorGradingBehaviour Pointer )

            return value;
        }
    }
}
