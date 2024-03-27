using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_capturedContext                        0001865CCD10 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 018 M_completionEvent                        0001865CFCA0 ModelClassType ManualResetEventSlim ManualResetEventSlim ManualResetEventSlim Pointer
    // 020 M_exceptionsHolder                       000186623000 ModelClassType TaskExceptionHolder TaskExceptionHolder TaskExceptionHolder Pointer
    // 028 M_cancellationToken                      00018653CDF0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 030 m_cancellationRegistration               <object> IL2CPP_TYPE_OBJECT
    // 038 M_internalCancellationRequested          0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C M_completionCountdown                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 040 m_exceptionalChildren                    LowLevelListWithIList`1<Task> IL2CPP_TYPE_GENERICINST
    public partial class ContingentProperties
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
            var value   = new ContingentProperties();

            value.M_capturedContext                         = GetObject<ExecutionContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExecutionContext.FromPointer); // 027003C40C70 0x10 M_capturedContext           ( 0001865CCD10 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.M_completionEvent                         = GetObject<ManualResetEventSlim>(new IntPtr(p + 0x018), ReversePrism.DataModels.ManualResetEventSlim.FromPointer); // 027003C40C90 0x18 M_completionEvent           ( 0001865CFCA0 ModelClassType ManualResetEventSlim ManualResetEventSlim ManualResetEventSlim Pointer )
            value.M_exceptionsHolder                        = GetObject<TaskExceptionHolder>(new IntPtr(p + 0x020), ReversePrism.DataModels.TaskExceptionHolder.FromPointer); // 027003C40CB0 0x20 M_exceptionsHolder          ( 000186623000 ModelClassType TaskExceptionHolder TaskExceptionHolder TaskExceptionHolder Pointer )
            value.M_cancellationToken                       = (CancellationToken)GetInt32(new IntPtr(p + 0x028)); // 027003C40CD0 0x28 M_cancellationToken         ( 00018653CDF0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.M_internalCancellationRequested           = GetInt32(new IntPtr(p + 0x038)); // 027003C40D10 0x38 M_internalCancellationRequested ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_completionCountdown                     = GetInt32(new IntPtr(p + 0x03C)); // 027003C40D30 0x3C M_completionCountdown       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
