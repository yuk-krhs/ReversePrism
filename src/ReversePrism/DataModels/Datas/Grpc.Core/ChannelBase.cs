using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   000186672F10 ModelPrimitiveType string string string String
    public partial class ChannelBase
    {
        public string                                   Target                                  { get; set; }

        public static ChannelBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelBase();

            value.Target                                    = GetString(new IntPtr(p + 0x010)); // 0270D0EA5C58 0x10 Target                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
