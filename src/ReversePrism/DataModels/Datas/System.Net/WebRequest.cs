using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultTimeout                           int IL2CPP_TYPE_I4
    // 000 s_PrefixList                             ArrayList IL2CPP_TYPE_CLASS
    // 008 s_InternalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    // 010 S_DefaultTimerQueue                      ModelClassType Queue Queue Queue Pointer
    // 018 M_AuthenticationLevel                    ModelEnumType AuthenticationLevel AuthenticationLevel AuthenticationLevel Int32
    // 01C M_ImpersonationLevel                     ModelEnumType TokenImpersonationLevel TokenImpersonationLevel TokenImpersonationLevel Int32
    // 020 M_CachePolicy                            ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    // 028 M_CacheProtocol                          ModelClassType RequestCacheProtocol RequestCacheProtocol RequestCacheProtocol Pointer
    // 030 M_CacheBinding                           ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer
    // 018 WebRequestCreate                         ModelClassType DesignerWebRequestCreate DesignerWebRequestCreate DesignerWebRequestCreate Pointer
    // 020 S_DefaultWebProxy                        ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 028 S_DefaultWebProxyInitialized             ModelPrimitiveType bool bool bool Bool
    public partial class WebRequest : DataModel
    {
        public Queue?                                   S_DefaultTimerQueue                     { get; set; }
        public AuthenticationLevel                      M_AuthenticationLevel                   { get; set; }
        public TokenImpersonationLevel                  M_ImpersonationLevel                    { get; set; }
        public RequestCachePolicy?                      M_CachePolicy                           { get; set; }
        public RequestCacheProtocol?                    M_CacheProtocol                         { get; set; }
        public RequestCacheBinding?                     M_CacheBinding                          { get; set; }
        public DesignerWebRequestCreate?                WebRequestCreate                        { get; set; }
        public IWebProxy?                               S_DefaultWebProxy                       { get; set; }
        public bool                                     S_DefaultWebProxyInitialized            { get; set; }

        public static WebRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequest() { Pointer= p0 };

            value.S_DefaultTimerQueue                       = GetObject<Queue>(new IntPtr(p + 0x010), ReversePrism.DataModels.Queue.FromPointer); // 0x10 S_DefaultTimerQueue         ( ModelClassType Queue Queue Queue Pointer )
            value.M_AuthenticationLevel                     = (AuthenticationLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_AuthenticationLevel       ( ModelEnumType AuthenticationLevel AuthenticationLevel AuthenticationLevel Int32 )
            value.M_ImpersonationLevel                      = (TokenImpersonationLevel)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_ImpersonationLevel        ( ModelEnumType TokenImpersonationLevel TokenImpersonationLevel TokenImpersonationLevel Int32 )
            value.M_CachePolicy                             = GetObject<RequestCachePolicy>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 0x20 M_CachePolicy               ( ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )
            value.M_CacheProtocol                           = GetObject<RequestCacheProtocol>(new IntPtr(p + 0x028), ReversePrism.DataModels.RequestCacheProtocol.FromPointer); // 0x28 M_CacheProtocol             ( ModelClassType RequestCacheProtocol RequestCacheProtocol RequestCacheProtocol Pointer )
            value.M_CacheBinding                            = GetObject<RequestCacheBinding>(new IntPtr(p + 0x030), ReversePrism.DataModels.RequestCacheBinding.FromPointer); // 0x30 M_CacheBinding              ( ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer )
            value.WebRequestCreate                          = GetObject<DesignerWebRequestCreate>(new IntPtr(p + 0x018), ReversePrism.DataModels.DesignerWebRequestCreate.FromPointer); // 0x18 WebRequestCreate            ( ModelClassType DesignerWebRequestCreate DesignerWebRequestCreate DesignerWebRequestCreate Pointer )
            value.S_DefaultWebProxy                         = GetObject<IWebProxy>(new IntPtr(p + 0x020), ReversePrism.DataModels.IWebProxy.FromPointer); // 0x20 S_DefaultWebProxy           ( ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.S_DefaultWebProxyInitialized              = GetBool(new IntPtr(p + 0x028)); // 0x28 S_DefaultWebProxyInitialized ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
