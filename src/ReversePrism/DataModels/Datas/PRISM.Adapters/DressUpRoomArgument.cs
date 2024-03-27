using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                000186515B60 ModelClassType LegacyDressUpRoomParameter LegacyDressUpRoomParameter LegacyDressUpRoomParameter Pointer
    public partial class DressUpRoomArgument
    {
        public LegacyDressUpRoomParameter?              JumpParam                               { get; set; }

        public static DressUpRoomArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomArgument();

            value.JumpParam                                 = GetObject<LegacyDressUpRoomParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.LegacyDressUpRoomParameter.FromPointer); // 0270D6227AD0 0x10 JumpParam                   ( 000186515B60 ModelClassType LegacyDressUpRoomParameter LegacyDressUpRoomParameter LegacyDressUpRoomParameter Pointer )

            return value;
        }
    }
}
