using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_defaultCancellationToken               00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 018 M_defaultScheduler                       0001866250D0 ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer
    // 020 M_defaultCreationOptions                 000186682E20 ModelEnumType TaskCreationOptions TaskCreationOptions TaskCreationOptions Int32
    // 024 M_defaultContinuationOptions             000186622630 ModelEnumType TaskContinuationOptions TaskContinuationOptions TaskContinuationOptions Int32
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

            value.M_defaultCancellationToken                = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 0245A3C38028 0x10 M_defaultCancellationToken  ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.M_defaultScheduler                        = GetObject<TaskScheduler>(new IntPtr(p + 0x018), ReversePrism.DataModels.TaskScheduler.FromPointer); // 0245A3C38048 0x18 M_defaultScheduler          ( 0001866250D0 ModelClassType TaskScheduler TaskScheduler TaskScheduler Pointer )
            value.M_defaultCreationOptions                  = (TaskCreationOptions)GetInt32(new IntPtr(p + 0x020)); // 0245A3C38068 0x20 M_defaultCreationOptions    ( 000186682E20 ModelEnumType TaskCreationOptions TaskCreationOptions TaskCreationOptions Int32 )
            value.M_defaultContinuationOptions              = (TaskContinuationOptions)GetInt32(new IntPtr(p + 0x024)); // 0245A3C38088 0x24 M_defaultContinuationOptions ( 000186622630 ModelEnumType TaskContinuationOptions TaskContinuationOptions TaskContinuationOptions Int32 )

            return value;
        }
    }
}
