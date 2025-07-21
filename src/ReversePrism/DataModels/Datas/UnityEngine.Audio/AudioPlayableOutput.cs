using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Handle                                 ModelEnumType PlayableOutputHandle PlayableOutputHandle PlayableOutputHandle Int32
    public partial class AudioPlayableOutput : DataModel
    {
        public PlayableOutputHandle                     M_Handle                                { get; set; }

        public static AudioPlayableOutput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioPlayableOutput() { Pointer= p0 };

            value.M_Handle                                  = (PlayableOutputHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Handle                    ( ModelEnumType PlayableOutputHandle PlayableOutputHandle PlayableOutputHandle Int32 )

            return value;
        }
    }
}
