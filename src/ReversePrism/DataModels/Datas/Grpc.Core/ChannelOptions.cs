using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SslTargetNameOverride                    string IL2CPP_TYPE_STRING
    // 000 Census                                   string IL2CPP_TYPE_STRING
    // 000 MaxConcurrentStreams                     string IL2CPP_TYPE_STRING
    // 000 MaxReceiveMessageLength                  string IL2CPP_TYPE_STRING
    // 000 MaxSendMessageLength                     string IL2CPP_TYPE_STRING
    // 000 MaxMessageLength                         string IL2CPP_TYPE_STRING
    // 000 Http2InitialSequenceNumber               string IL2CPP_TYPE_STRING
    // 000 DefaultAuthority                         string IL2CPP_TYPE_STRING
    // 000 PrimaryUserAgentString                   string IL2CPP_TYPE_STRING
    // 000 SecondaryUserAgentString                 string IL2CPP_TYPE_STRING
    // 000 SoReuseport                              string IL2CPP_TYPE_STRING
    public partial class ChannelOptions
    {

        public static ChannelOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelOptions();


            return value;
        }
    }
}
