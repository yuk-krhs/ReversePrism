using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChannelHandler                           000186592100 ModelClassType ChannelHandler ChannelHandler ChannelHandler Pointer
    // 018 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 downloadThrottleEnabled                  bool IL2CPP_TYPE_BOOLEAN
    // 020 ServerConfig                             000186637CE0 ModelClassType IServerConfig IServerConfig IServerConfig Pointer
    public partial class APIProvider
    {
        public ChannelHandler?                          ChannelHandler                          { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public IServerConfig?                           ServerConfig                            { get; set; }

        public static APIProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new APIProvider();

            value.ChannelHandler                            = GetObject<ChannelHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChannelHandler.FromPointer); // 0270D0E861A0 0x10 ChannelHandler              ( 000186592100 ModelClassType ChannelHandler ChannelHandler ChannelHandler Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x018)); // 0270D0E861C0 0x18 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ServerConfig                              = GetObject<IServerConfig>(new IntPtr(p + 0x020), ReversePrism.DataModels.IServerConfig.FromPointer); // 0270D0E86200 0x20 ServerConfig                ( 000186637CE0 ModelClassType IServerConfig IServerConfig IServerConfig Pointer )

            return value;
        }
    }
}
