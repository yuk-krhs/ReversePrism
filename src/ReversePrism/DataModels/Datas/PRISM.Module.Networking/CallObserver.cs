using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Error                                    0001865C0390 ModelClassType INetworkError INetworkError INetworkError Pointer
    // 018 Subscription                             0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Logger                                   00018669C140 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    // 028 callSubject                              Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 requestCount                             int IL2CPP_TYPE_I4
    // 008 lockObject                               <object> IL2CPP_TYPE_OBJECT
    public partial class CallObserver
    {
        public INetworkError?                           Error                                   { get; set; }
        public IDisposable?                             Subscription                            { get; set; }
        public NetworkLoggerBase?                       Logger                                  { get; set; }

        public static CallObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallObserver();

            value.Error                                     = GetObject<INetworkError>(new IntPtr(p + 0x010), ReversePrism.DataModels.INetworkError.FromPointer); // 02700756BB60 0x10 Error                       ( 0001865C0390 ModelClassType INetworkError INetworkError INetworkError Pointer )
            value.Subscription                              = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 02700756BB80 0x18 Subscription                ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Logger                                    = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 02700756BBA0 0x20 Logger                      ( 00018669C140 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )

            return value;
        }
    }
}
