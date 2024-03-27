using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Queues                                 LinkedList`1<WeakReference> IL2CPP_TYPE_GENERICINST
    // 008 s_NewQueues                              LinkedList`1<WeakReference> IL2CPP_TYPE_GENERICINST
    // 010 S_ThreadState                            0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 S_ThreadReadyEvent                       000186729000 ModelClassType AutoResetEvent AutoResetEvent AutoResetEvent Pointer
    // 020 S_ThreadShutdownEvent                    00018660A880 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 028 S_ThreadEvents                           000185CB2428 ModelClassListType WaitHandle[] WaitHandle[] List<WaitHandle> Pointer
    // 030 S_CacheScanIteration                     0001865F38E0 ModelPrimitiveType int int int Int32
    // 038 S_QueuesCache                            0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class TimerThread
    {
        public int                                      S_ThreadState                           { get; set; }
        public AutoResetEvent?                          S_ThreadReadyEvent                      { get; set; }
        public ManualResetEvent?                        S_ThreadShutdownEvent                   { get; set; }
        public List<WaitHandle>?                        S_ThreadEvents                          { get; set; }
        public int                                      S_CacheScanIteration                    { get; set; }
        public Hashtable?                               S_QueuesCache                           { get; set; }

        public static TimerThread? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerThread();

            value.S_ThreadState                             = GetInt32(new IntPtr(p + 0x010)); // 0270D7A14B88 0x10 S_ThreadState               ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_ThreadReadyEvent                        = GetObject<AutoResetEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.AutoResetEvent.FromPointer); // 0270D7A14BA8 0x18 S_ThreadReadyEvent          ( 000186729000 ModelClassType AutoResetEvent AutoResetEvent AutoResetEvent Pointer )
            value.S_ThreadShutdownEvent                     = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0270D7A14BC8 0x20 S_ThreadShutdownEvent       ( 00018660A880 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.S_ThreadEvents                            = GetObjectList<WaitHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.WaitHandle.FromPointer); // 0270D7A14BE8 0x28 S_ThreadEvents              ( 000185CB2428 ModelClassListType WaitHandle[] WaitHandle[] List<WaitHandle> Pointer )
            value.S_CacheScanIteration                      = GetInt32(new IntPtr(p + 0x030)); // 0270D7A14C08 0x30 S_CacheScanIteration        ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_QueuesCache                             = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7A14C28 0x38 S_QueuesCache               ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
