using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetMetadataExceptionStatusMsg            string IL2CPP_TYPE_STRING
    // 000 GetMetadataExceptionLogMsg               string IL2CPP_TYPE_STRING
    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 008 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 010 Interceptor                              ModelClassType AsyncAuthInterceptor AsyncAuthInterceptor AsyncAuthInterceptor Pointer
    // 018 Credentials                              ModelClassType CallCredentialsSafeHandle CallCredentialsSafeHandle CallCredentialsSafeHandle Pointer
    // 020 CallbackRegistration                     ModelClassType NativeCallbackRegistration NativeCallbackRegistration NativeCallbackRegistration Pointer
    public partial class NativeMetadataCredentialsPlugin : DataModel
    {
        public AsyncAuthInterceptor?                    Interceptor                             { get; set; }
        public CallCredentialsSafeHandle?               Credentials                             { get; set; }
        public NativeCallbackRegistration?              CallbackRegistration                    { get; set; }

        public static NativeMetadataCredentialsPlugin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeMetadataCredentialsPlugin() { Pointer= p0 };

            value.Interceptor                               = GetObject<AsyncAuthInterceptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncAuthInterceptor.FromPointer); // 0x10 Interceptor                 ( ModelClassType AsyncAuthInterceptor AsyncAuthInterceptor AsyncAuthInterceptor Pointer )
            value.Credentials                               = GetObject<CallCredentialsSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallCredentialsSafeHandle.FromPointer); // 0x18 Credentials                 ( ModelClassType CallCredentialsSafeHandle CallCredentialsSafeHandle CallCredentialsSafeHandle Pointer )
            value.CallbackRegistration                      = GetObject<NativeCallbackRegistration>(new IntPtr(p + 0x020), ReversePrism.DataModels.NativeCallbackRegistration.FromPointer); // 0x20 CallbackRegistration        ( ModelClassType NativeCallbackRegistration NativeCallbackRegistration NativeCallbackRegistration Pointer )

            return value;
        }
    }
}
