using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Playable                               00018674C270 ModelEnumType Playable Playable Playable Int32
    // 000 kIntervalEnd                             long IL2CPP_TYPE_I8
    public partial class InfiniteRuntimeClip
    {
        public Playable                                 M_Playable                              { get; set; }

        public static InfiniteRuntimeClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InfiniteRuntimeClip();

            value.M_Playable                                = (Playable)GetInt32(new IntPtr(p + 0x018)); // 027007304668 0x18 M_Playable                  ( 00018674C270 ModelEnumType Playable Playable Playable Int32 )

            return value;
        }
    }
}
