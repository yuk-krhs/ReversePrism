using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 008 CachedNativeCredentials                  ConditionalWeakTable`2<ChannelCredentials, Lazy`1<ChannelCredentialsSafeHandle>> IL2CPP_TYPE_GENERICINST
    // 010 StaticLock                               <object> IL2CPP_TYPE_OBJECT
    // 010 Configured                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 NativeCredentials                        0001865914B0 ModelClassType ChannelCredentialsSafeHandle ChannelCredentialsSafeHandle ChannelCredentialsSafeHandle Pointer
    public partial class DefaultChannelCredentialsConfigurator : DataModel
    {
        public bool                                     Configured                              { get; set; }
        public ChannelCredentialsSafeHandle?            NativeCredentials                       { get; set; }

        public static DefaultChannelCredentialsConfigurator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultChannelCredentialsConfigurator() { Pointer= p0 };

            value.Configured                                = GetBool(new IntPtr(p + 0x010)); // 0245A414D400 0x10 Configured                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NativeCredentials                         = GetObject<ChannelCredentialsSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChannelCredentialsSafeHandle.FromPointer); // 0245A414D420 0x18 NativeCredentials           ( 0001865914B0 ModelClassType ChannelCredentialsSafeHandle ChannelCredentialsSafeHandle ChannelCredentialsSafeHandle Pointer )

            return value;
        }
    }
}
