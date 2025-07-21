using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                ModelClassType LegacyDressUpRoomParameter LegacyDressUpRoomParameter LegacyDressUpRoomParameter Pointer
    public partial class DressUpRoomArgument : DataModel
    {
        public LegacyDressUpRoomParameter?              JumpParam                               { get; set; }

        public static DressUpRoomArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<LegacyDressUpRoomParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.LegacyDressUpRoomParameter.FromPointer); // 0x10 JumpParam                   ( ModelClassType LegacyDressUpRoomParameter LegacyDressUpRoomParameter LegacyDressUpRoomParameter Pointer )

            return value;
        }
    }
}
