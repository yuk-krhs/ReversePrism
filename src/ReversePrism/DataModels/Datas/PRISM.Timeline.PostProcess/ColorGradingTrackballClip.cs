using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001865CEE60 ModelClassType ColorGradingTrackballBehaviour ColorGradingTrackballBehaviour ColorGradingTrackballBehaviour Pointer
    public partial class ColorGradingTrackballClip
    {
        public ColorGradingTrackballBehaviour?          Behaviour                               { get; set; }

        public static ColorGradingTrackballClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingTrackballClip();

            value.Behaviour                                 = GetObject<ColorGradingTrackballBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ColorGradingTrackballBehaviour.FromPointer); // 0270D5075068 0x18 Behaviour                   ( 0001865CEE60 ModelClassType ColorGradingTrackballBehaviour ColorGradingTrackballBehaviour ColorGradingTrackballBehaviour Pointer )

            return value;
        }
    }
}
