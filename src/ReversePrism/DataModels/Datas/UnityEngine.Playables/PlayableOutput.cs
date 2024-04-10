using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Handle                                 000186640DC0 ModelEnumType PlayableOutputHandle PlayableOutputHandle PlayableOutputHandle Int32
    // 000 m_NullPlayableOutput                     PlayableOutput IL2CPP_TYPE_VALUETYPE
    public partial class PlayableOutput : DataModel
    {
        public PlayableOutputHandle                     M_Handle                                { get; set; }

        public static PlayableOutput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayableOutput() { Pointer= p0 };

            value.M_Handle                                  = (PlayableOutputHandle)GetInt32(new IntPtr(p + 0x010)); // 0245A23FF398 0x10 M_Handle                    ( 000186640DC0 ModelEnumType PlayableOutputHandle PlayableOutputHandle PlayableOutputHandle Int32 )

            return value;
        }
    }
}
