using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   DelayObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 hasFailed                                bool IL2CPP_TYPE_BOOLEAN
    // 000 running                                  bool IL2CPP_TYPE_BOOLEAN
    // 000 active                                   bool IL2CPP_TYPE_BOOLEAN
    // 000 exception                                Exception IL2CPP_TYPE_CLASS
    // 000 queue                                    Queue`1<Timestamped`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 onCompleted                              bool IL2CPP_TYPE_BOOLEAN
    // 000 completeAt                               DateTimeOffset IL2CPP_TYPE_VALUETYPE
    // 000 sourceSubscription                       IDisposable IL2CPP_TYPE_CLASS
    // 000 delay                                    TimeSpan IL2CPP_TYPE_VALUETYPE
    // 000 ready                                    bool IL2CPP_TYPE_BOOLEAN
    // 000 cancelable                               SerialDisposable IL2CPP_TYPE_CLASS
    public partial class Delay
    {

        public static Delay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Delay();


            return value;
        }
    }
}
