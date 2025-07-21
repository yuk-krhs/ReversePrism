using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChannelHandler                           ModelClassType ChannelHandler ChannelHandler ChannelHandler Pointer
    // 018 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 000 downloadThrottleEnabled                  bool IL2CPP_TYPE_BOOLEAN
    // 020 ServerConfig                             ModelClassType IServerConfig IServerConfig IServerConfig Pointer
    public partial class APIProvider : DataModel
    {
        public ChannelHandler?                          ChannelHandler                          { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public IServerConfig?                           ServerConfig                            { get; set; }

        public static APIProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new APIProvider() { Pointer= p0 };

            value.ChannelHandler                            = GetObject<ChannelHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChannelHandler.FromPointer); // 0x10 ChannelHandler              ( ModelClassType ChannelHandler ChannelHandler ChannelHandler Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x018)); // 0x18 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.ServerConfig                              = GetObject<IServerConfig>(new IntPtr(p + 0x020), ReversePrism.DataModels.IServerConfig.FromPointer); // 0x20 ServerConfig                ( ModelClassType IServerConfig IServerConfig IServerConfig Pointer )

            return value;
        }
    }
}
