using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PhoneUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 PhoneCallId                              0001865F4260 ModelPrimitiveType int int int Int32
    public partial class CallPlaybackParameter : DataModel
    {
        public int                                      PhoneUserId                             { get; set; }
        public int                                      PhoneCallId                             { get; set; }

        public static CallPlaybackParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallPlaybackParameter() { Pointer= p0 };

            value.PhoneUserId                               = GetInt32(new IntPtr(p + 0x010)); // 0246668A4498 0x10 PhoneUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PhoneCallId                               = GetInt32(new IntPtr(p + 0x014)); // 0246668A44B8 0x14 PhoneCallId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
