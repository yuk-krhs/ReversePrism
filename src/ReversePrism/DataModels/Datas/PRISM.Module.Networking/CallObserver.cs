using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Error                                    ModelClassType INetworkError INetworkError INetworkError Pointer
    // 018 Subscription                             ModelClassType IDisposable IDisposable IDisposable Pointer
    // 020 Logger                                   ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    // 028 callSubject                              Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 requestCount                             int IL2CPP_TYPE_I4
    // 008 lockObject                               <object> IL2CPP_TYPE_OBJECT
    public partial class CallObserver : DataModel
    {
        public INetworkError?                           Error                                   { get; set; }
        public IDisposable?                             Subscription                            { get; set; }
        public NetworkLoggerBase?                       Logger                                  { get; set; }

        public static CallObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallObserver() { Pointer= p0 };

            value.Error                                     = GetObject<INetworkError>(new IntPtr(p + 0x010), ReversePrism.DataModels.INetworkError.FromPointer); // 0x10 Error                       ( ModelClassType INetworkError INetworkError INetworkError Pointer )
            value.Subscription                              = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0x18 Subscription                ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Logger                                    = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 0x20 Logger                      ( ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )

            return value;
        }
    }
}
