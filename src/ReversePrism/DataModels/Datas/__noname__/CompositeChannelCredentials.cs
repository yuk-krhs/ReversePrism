using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChannelCredentials                       000186590860 ModelClassType ChannelCredentials ChannelCredentials ChannelCredentials Pointer
    // 018 CallCredentials                          000186526380 ModelClassType CallCredentials CallCredentials CallCredentials Pointer
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

            value.ChannelCredentials                        = GetObject<ChannelCredentials>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChannelCredentials.FromPointer); // 02466BBC10D0 0x10 ChannelCredentials          ( 000186590860 ModelClassType ChannelCredentials ChannelCredentials ChannelCredentials Pointer )
            value.CallCredentials                           = GetObject<CallCredentials>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallCredentials.FromPointer); // 02466BBC10F0 0x18 CallCredentials             ( 000186526380 ModelClassType CallCredentials CallCredentials CallCredentials Pointer )

            return value;
        }
    }
}
