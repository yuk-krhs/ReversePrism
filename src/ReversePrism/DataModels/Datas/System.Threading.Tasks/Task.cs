using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_taskIdCounter                          int IL2CPP_TYPE_I4
    // 010 M_taskId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_action                                 0001866BAB20 ModelClassType Delegate Delegate Delegate Pointer
    // 020 m_stateObject                            <object> IL2CPP_TYPE_OBJECT
    // 028 M_taskScheduler                          0001866249C0 ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer
    // 030 M_parent                                 000186681890 ModelClassType Task Task Task Pointer
    // 038 M_stateFlags                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 000 OptionsMask                              int IL2CPP_TYPE_I4
    // 000 TASK_STATE_STARTED                       int IL2CPP_TYPE_I4
    // 000 TASK_STATE_DELEGATE_INVOKED              int IL2CPP_TYPE_I4
    // 000 TASK_STATE_DISPOSED                      int IL2CPP_TYPE_I4
    // 000 TASK_STATE_EXCEPTIONOBSERVEDBYPARENT     int IL2CPP_TYPE_I4
    // 000 TASK_STATE_CANCELLATIONACKNOWLEDGED      int IL2CPP_TYPE_I4
    // 000 TASK_STATE_FAULTED                       int IL2CPP_TYPE_I4
    // 000 TASK_STATE_CANCELED                      int IL2CPP_TYPE_I4
    // 000 TASK_STATE_WAITING_ON_CHILDREN           int IL2CPP_TYPE_I4
    // 000 TASK_STATE_RAN_TO_COMPLETION             int IL2CPP_TYPE_I4
    // 000 TASK_STATE_WAITINGFORACTIVATION          int IL2CPP_TYPE_I4
    // 000 TASK_STATE_COMPLETION_RESERVED           int IL2CPP_TYPE_I4
    // 000 TASK_STATE_THREAD_WAS_ABORTED            int IL2CPP_TYPE_I4
    // 000 TASK_STATE_WAIT_COMPLETION_NOTIFICATION  int IL2CPP_TYPE_I4
    // 000 TASK_STATE_COMPLETED_MASK                int IL2CPP_TYPE_I4
    // 000 CANCELLATION_REQUESTED                   int IL2CPP_TYPE_I4
    // 040 m_continuationObject                     <object> IL2CPP_TYPE_OBJECT
    // 008 s_taskCompletionSentinel                 <object> IL2CPP_TYPE_OBJECT
    // 010 S_asyncDebuggingEnabled                  000186595E60 ModelPrimitiveType bool bool bool Bool
    // 048 M_contingentProperties                   0001865EE6B0 ModelClassType ContingentProperties ContingentProperties ContingentProperties Pointer
    // 018 s_taskCancelCallback                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // FFFFFFFF t_currentTask                            Task IL2CPP_TYPE_CLASS
    // FFFFFFFF t_stackGuard                             StackGuard IL2CPP_TYPE_CLASS
    // 020 s_createContingentProperties             Func`1<ContingentProperties> IL2CPP_TYPE_GENERICINST
    // 028 Factory                                  000186623950 ModelClassType TaskFactory TaskFactory TaskFactory Pointer
    // 030 CompletedTask                            000186681AE0 ModelClassType Task Task Task Pointer
    // 038 s_IsExceptionObservedByParentPredicate   Predicate`1<Task> IL2CPP_TYPE_GENERICINST
    // 040 S_ecCallback                             000186614570 ModelClassType ContextCallback ContextCallback ContextCallback Pointer
    // 048 s_IsTaskContinuationNullPredicate        Predicate`1<<object>> IL2CPP_TYPE_GENERICINST
    // 050 s_currentActiveTasks                     Dictionary`2<int, Task> IL2CPP_TYPE_GENERICINST
    // 058 s_activeTasksLock                        <object> IL2CPP_TYPE_OBJECT
    public partial class Task
    {
        public int                                      M_taskId                                { get; set; }
        public Delegate?                                M_action                                { get; set; }
        public TaskScheduler?                           M_taskScheduler                         { get; set; }
        public Task?                                    M_parent                                { get; set; }
        public int                                      M_stateFlags                            { get; set; }
        public bool                                     S_asyncDebuggingEnabled                 { get; set; }
        public ContingentProperties?                    M_contingentProperties                  { get; set; }
        public TaskFactory?                             Factory                                 { get; set; }
        public Task?                                    CompletedTask                           { get; set; }
        public ContextCallback?                         S_ecCallback                            { get; set; }

        public static Task? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Task();

            value.M_taskId                                  = GetInt32(new IntPtr(p + 0x010)); // 027003C2F320 0x10 M_taskId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_action                                  = GetObject<Delegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.Delegate.FromPointer); // 027003C2F340 0x18 M_action                    ( 0001866BAB20 ModelClassType Delegate Delegate Delegate Pointer )
            value.M_taskScheduler                           = GetObject<TaskScheduler>(new IntPtr(p + 0x028), ReversePrism.DataModels.TaskScheduler.FromPointer); // 027003C2F380 0x28 M_taskScheduler             ( 0001866249C0 ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer )
            value.M_parent                                  = GetObject<Task>(new IntPtr(p + 0x030), ReversePrism.DataModels.Task.FromPointer); // 027003C2F3A0 0x30 M_parent                    ( 000186681890 ModelClassType Task Task Task Pointer )
            value.M_stateFlags                              = GetInt32(new IntPtr(p + 0x038)); // 027003C2F3C0 0x38 M_stateFlags                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.S_asyncDebuggingEnabled                   = GetBool(new IntPtr(p + 0x010)); // 027003C2F620 0x10 S_asyncDebuggingEnabled     ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.M_contingentProperties                    = GetObject<ContingentProperties>(new IntPtr(p + 0x048), ReversePrism.DataModels.ContingentProperties.FromPointer); // 027003C2F640 0x48 M_contingentProperties      ( 0001865EE6B0 ModelClassType ContingentProperties ContingentProperties ContingentProperties Pointer )
            value.Factory                                   = GetObject<TaskFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.TaskFactory.FromPointer); // 027003C2F6E0 0x28 Factory                     ( 000186623950 ModelClassType TaskFactory TaskFactory TaskFactory Pointer )
            value.CompletedTask                             = GetObject<Task>(new IntPtr(p + 0x030), ReversePrism.DataModels.Task.FromPointer); // 027003C2F700 0x30 CompletedTask               ( 000186681AE0 ModelClassType Task Task Task Pointer )
            value.S_ecCallback                              = GetObject<ContextCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.ContextCallback.FromPointer); // 027003C2F740 0x40 S_ecCallback                ( 000186614570 ModelClassType ContextCallback ContextCallback ContextCallback Pointer )

            return value;
        }
    }
}
