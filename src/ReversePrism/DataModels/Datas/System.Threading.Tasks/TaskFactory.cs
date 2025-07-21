using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_defaultCancellationToken               ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 018 M_defaultScheduler                       ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer
    // 020 M_defaultCreationOptions                 ModelEnumType TaskCreationOptions TaskCreationOptions TaskCreationOptions Int32
    // 024 M_defaultContinuationOptions             ModelEnumType TaskContinuationOptions TaskContinuationOptions TaskContinuationOptions Int32
    public partial class TaskFactory : DataModel
    {
        public CancellationToken                        M_defaultCancellationToken              { get; set; }
        public TaskScheduler?                           M_defaultScheduler                      { get; set; }
        public TaskCreationOptions                      M_defaultCreationOptions                { get; set; }
        public TaskContinuationOptions                  M_defaultContinuationOptions            { get; set; }

        public static TaskFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskFactory() { Pointer= p0 };

            value.M_defaultCancellationToken                = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_defaultCancellationToken  ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.M_defaultScheduler                        = GetObject<TaskScheduler>(new IntPtr(p + 0x018), ReversePrism.DataModels.TaskScheduler.FromPointer); // 0x18 M_defaultScheduler          ( ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer )
            value.M_defaultCreationOptions                  = (TaskCreationOptions)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_defaultCreationOptions    ( ModelEnumType TaskCreationOptions TaskCreationOptions TaskCreationOptions Int32 )
            value.M_defaultContinuationOptions              = (TaskContinuationOptions)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_defaultContinuationOptions ( ModelEnumType TaskContinuationOptions TaskContinuationOptions TaskContinuationOptions Int32 )

            return value;
        }
    }
}
