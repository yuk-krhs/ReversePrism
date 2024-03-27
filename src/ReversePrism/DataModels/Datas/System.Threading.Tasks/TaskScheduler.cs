using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_activeTaskSchedulers                   ConditionalWeakTable`2<TaskScheduler, <object>> IL2CPP_TYPE_GENERICINST
    // 008 s_defaultTaskScheduler                   TaskScheduler IL2CPP_TYPE_CLASS
    // 010 S_taskSchedulerIdCounter                 0001865F3B80 ModelPrimitiveType int int int Int32
    // 010 M_taskSchedulerId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 _unobservedTaskException                 EventHandler`1<UnobservedTaskExceptionEventArgs> IL2CPP_TYPE_GENERICINST
    // 020 UnobservedTaskExceptionLockObject        0001865A9420 ModelClassType Lock Lock Lock Pointer
    public partial class TaskScheduler
    {
        public int                                      S_taskSchedulerIdCounter                { get; set; }
        public int                                      M_taskSchedulerId                       { get; set; }
        public Lock?                                    UnobservedTaskExceptionLockObject       { get; set; }

        public static TaskScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskScheduler();

            value.S_taskSchedulerIdCounter                  = GetInt32(new IntPtr(p + 0x010)); // 027003497FD8 0x10 S_taskSchedulerIdCounter    ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.M_taskSchedulerId                         = GetInt32(new IntPtr(p + 0x010)); // 027003497FF8 0x10 M_taskSchedulerId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnobservedTaskExceptionLockObject         = GetObject<Lock>(new IntPtr(p + 0x020), ReversePrism.DataModels.Lock.FromPointer); // 027003498038 0x20 UnobservedTaskExceptionLockObject ( 0001865A9420 ModelClassType Lock Lock Lock Pointer )

            return value;
        }
    }
}
