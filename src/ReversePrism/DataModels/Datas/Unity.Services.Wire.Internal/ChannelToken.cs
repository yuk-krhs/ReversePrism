using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChannelName                              0001866722E0 ModelPrimitiveType string string string String
    // 018 Token                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class ChannelToken : DataModel
    {
        public string                                   ChannelName                             { get; set; }
        public string                                   Token                                   { get; set; }

        public static ChannelToken? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelToken() { Pointer= p0 };

            value.ChannelName                               = GetString(new IntPtr(p + 0x010)); // 02466BAB6EA0 0x10 ChannelName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Token                                     = GetString(new IntPtr(p + 0x018)); // 02466BAB6EC0 0x18 Token                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
