using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   DelayFrameObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 pool                                     QueuePool<<var>> IL2CPP_TYPE_GENERICINST
    // 000 runningEnumeratorCount                   int IL2CPP_TYPE_I4
    // 000 readyDrainEnumerator                     bool IL2CPP_TYPE_BOOLEAN
    // 000 running                                  bool IL2CPP_TYPE_BOOLEAN
    // 000 sourceSubscription                       IDisposable IL2CPP_TYPE_CLASS
    // 000 currentQueueReference                    Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 calledCompleted                          bool IL2CPP_TYPE_BOOLEAN
    // 000 hasError                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 error                                    Exception IL2CPP_TYPE_CLASS
    // 000 cancelationToken                         BooleanDisposable IL2CPP_TYPE_CLASS
    public partial class DelayFrame : DataModel
    {

        public static DelayFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelayFrame() { Pointer= p0 };


            return value;
        }
    }
}
