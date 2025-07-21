using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChannelCredentials                       ModelClassType ChannelCredentials ChannelCredentials ChannelCredentials Pointer
    // 018 CallCredentials                          ModelClassType CallCredentials CallCredentials CallCredentials Pointer
    public partial class CompositeChannelCredentials : DataModel
    {
        public ChannelCredentials?                      ChannelCredentials                      { get; set; }
        public CallCredentials?                         CallCredentials                         { get; set; }

        public static CompositeChannelCredentials? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompositeChannelCredentials() { Pointer= p0 };

            value.ChannelCredentials                        = GetObject<ChannelCredentials>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChannelCredentials.FromPointer); // 0x10 ChannelCredentials          ( ModelClassType ChannelCredentials ChannelCredentials ChannelCredentials Pointer )
            value.CallCredentials                           = GetObject<CallCredentials>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallCredentials.FromPointer); // 0x18 CallCredentials             ( ModelClassType CallCredentials CallCredentials CallCredentials Pointer )

            return value;
        }
    }
}
