using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class CueEventMessage
    {
        public ulong                                    Time                                    { get; set; }

        public static CueEventMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueEventMessage();

            value.Time                                      = GetUInt64(new IntPtr(p + 0x010)); // 027004376F60 0x10 Time                        ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
