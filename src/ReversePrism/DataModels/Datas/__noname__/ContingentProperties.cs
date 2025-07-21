using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_capturedContext                        ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 018 M_completionEvent                        ModelClassType ManualResetEventSlim ManualResetEventSlim ManualResetEventSlim Pointer
    // 020 M_exceptionsHolder                       ModelClassType TaskExceptionHolder TaskExceptionHolder TaskExceptionHolder Pointer
    // 028 M_cancellationToken                      ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 m_cancellationRegistration               <object> IL2CPP_TYPE_OBJECT
    // 038 M_internalCancellationRequested          ModelPrimitiveType int int int Int32
    // 03C M_completionCountdown                    ModelPrimitiveType int int int Int32
    // 040 m_exceptionalChildren                    LowLevelListWithIList`1<Task> IL2CPP_TYPE_GENERICINST
    public partial class ContingentProperties : DataModel
    {
        public ExecutionContext?                        M_capturedContext                       { get; set; }
        public ManualResetEventSlim?                    M_completionEvent                       { get; set; }
        public TaskExceptionHolder?                     M_exceptionsHolder                      { get; set; }
        public CancellationToken                        M_cancellationToken                     { get; set; }
        public int                                      M_internalCancellationRequested         { get; set; }
        public int                                      M_completionCountdown                   { get; set; }

        public static ContingentProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContingentProperties() { Pointer= p0 };

            value.M_capturedContext                         = GetObject<ExecutionContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x10 M_capturedContext           ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.M_completionEvent                         = GetObject<ManualResetEventSlim>(new IntPtr(p + 0x018), ReversePrism.DataModels.ManualResetEventSlim.FromPointer); // 0x18 M_completionEvent           ( ModelClassType ManualResetEventSlim ManualResetEventSlim ManualResetEventSlim Pointer )
            value.M_exceptionsHolder                        = GetObject<TaskExceptionHolder>(new IntPtr(p + 0x020), ReversePrism.DataModels.TaskExceptionHolder.FromPointer); // 0x20 M_exceptionsHolder          ( ModelClassType TaskExceptionHolder TaskExceptionHolder TaskExceptionHolder Pointer )
            value.M_cancellationToken                       = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_cancellationToken         ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.M_internalCancellationRequested           = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_internalCancellationRequested ( ModelPrimitiveType int int int Int32 )
            value.M_completionCountdown                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_completionCountdown       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
