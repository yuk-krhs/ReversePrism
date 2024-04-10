using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnobservedTaskException                  Action`1<Exception> IL2CPP_TYPE_GENERICINST
    // 008 PropagateOperationCanceledException      bool IL2CPP_TYPE_BOOLEAN
    // 00C UnobservedExceptionWriteLogType          LogType IL2CPP_TYPE_VALUETYPE
    // 010 DispatchUnityMainThread                  000186596380 ModelPrimitiveType bool bool bool Bool
    // 018 HandleExceptionInvoke                    0001867255F0 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    public partial class UniTaskScheduler : DataModel
    {
        public bool                                     DispatchUnityMainThread                 { get; set; }
        public SendOrPostCallback?                      HandleExceptionInvoke                   { get; set; }

        public static UniTaskScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniTaskScheduler() { Pointer= p0 };

            value.DispatchUnityMainThread                   = GetBool(new IntPtr(p + 0x010)); // 0245A3EE4170 0x10 DispatchUnityMainThread     ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.HandleExceptionInvoke                     = GetObject<SendOrPostCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 0245A3EE4190 0x18 HandleExceptionInvoke       ( 0001867255F0 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )

            return value;
        }
    }
}
