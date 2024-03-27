using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Handle                                 000186640DC0 ModelEnumType PlayableOutputHandle PlayableOutputHandle PlayableOutputHandle Int32
    public partial class AnimationPlayableOutput
    {
        public PlayableOutputHandle                     M_Handle                                { get; set; }

        public static AnimationPlayableOutput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationPlayableOutput();

            value.M_Handle                                  = (PlayableOutputHandle)GetInt32(new IntPtr(p + 0x010)); // 02700223FDF0 0x10 M_Handle                    ( 000186640DC0 ModelEnumType PlayableOutputHandle PlayableOutputHandle PlayableOutputHandle Int32 )

            return value;
        }
    }
}
