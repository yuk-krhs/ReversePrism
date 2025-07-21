using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cullingMode                              CullingMode IL2CPP_TYPE_VALUETYPE
    // 020 QueueWorker                              ModelClassType ThreadSafeQueueWorker ThreadSafeQueueWorker ThreadSafeQueueWorker Pointer
    // 028 unhandledExceptionCallback               Action`1<Exception> IL2CPP_TYPE_GENERICINST
    // 030 UpdateMicroCoroutine                     ModelClassType MicroCoroutine MicroCoroutine MicroCoroutine Pointer
    // 038 FixedUpdateMicroCoroutine                ModelClassType MicroCoroutine MicroCoroutine MicroCoroutine Pointer
    // 040 EndOfFrameMicroCoroutine                 ModelClassType MicroCoroutine MicroCoroutine MicroCoroutine Pointer
    // 008 instance                                 MainThreadDispatcher IL2CPP_TYPE_CLASS
    // 010 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 011 IsQuitting                               ModelPrimitiveType bool bool bool Bool
    // FFFFFFFF mainThreadToken                          <object> IL2CPP_TYPE_OBJECT
    // 048 update                                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 lateUpdate                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onApplicationFocus                       Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 onApplicationPause                       Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 068 onApplicationQuit                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class MainThreadDispatcher : DataModel
    {
        public ThreadSafeQueueWorker?                   QueueWorker                             { get; set; }
        public MicroCoroutine?                          UpdateMicroCoroutine                    { get; set; }
        public MicroCoroutine?                          FixedUpdateMicroCoroutine               { get; set; }
        public MicroCoroutine?                          EndOfFrameMicroCoroutine                { get; set; }
        public bool                                     Initialized                             { get; set; }
        public bool                                     IsQuitting                              { get; set; }

        public static MainThreadDispatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainThreadDispatcher() { Pointer= p0 };

            value.QueueWorker                               = GetObject<ThreadSafeQueueWorker>(new IntPtr(p + 0x020), ReversePrism.DataModels.ThreadSafeQueueWorker.FromPointer); // 0x20 QueueWorker                 ( ModelClassType ThreadSafeQueueWorker ThreadSafeQueueWorker ThreadSafeQueueWorker Pointer )
            value.UpdateMicroCoroutine                      = GetObject<MicroCoroutine>(new IntPtr(p + 0x030), ReversePrism.DataModels.MicroCoroutine.FromPointer); // 0x30 UpdateMicroCoroutine        ( ModelClassType MicroCoroutine MicroCoroutine MicroCoroutine Pointer )
            value.FixedUpdateMicroCoroutine                 = GetObject<MicroCoroutine>(new IntPtr(p + 0x038), ReversePrism.DataModels.MicroCoroutine.FromPointer); // 0x38 FixedUpdateMicroCoroutine   ( ModelClassType MicroCoroutine MicroCoroutine MicroCoroutine Pointer )
            value.EndOfFrameMicroCoroutine                  = GetObject<MicroCoroutine>(new IntPtr(p + 0x040), ReversePrism.DataModels.MicroCoroutine.FromPointer); // 0x40 EndOfFrameMicroCoroutine    ( ModelClassType MicroCoroutine MicroCoroutine MicroCoroutine Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x010)); // 0x10 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsQuitting                                = GetBool(new IntPtr(p + 0x011)); // 0x11 IsQuitting                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
