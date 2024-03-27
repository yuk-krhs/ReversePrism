using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_failFastOnUnobservedException          bool IL2CPP_TYPE_BOOLEAN
    // 010 M_task                                   000186681620 ModelClassType Task Task Task Pointer
    // 018 m_faultExceptions                        LowLevelListWithIList`1<ExceptionDispatchInfo> IL2CPP_TYPE_GENERICINST
    // 020 M_cancellationException                  0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 028 M_isHandled                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TaskExceptionHolder
    {
        public Task?                                    M_task                                  { get; set; }
        public ExceptionDispatchInfo?                   M_cancellationException                 { get; set; }
        public bool                                     M_isHandled                             { get; set; }

        public static TaskExceptionHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskExceptionHolder();

            value.M_task                                    = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 0270D6B24A28 0x10 M_task                      ( 000186681620 ModelClassType Task Task Task Pointer )
            value.M_cancellationException                   = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D6B24A68 0x20 M_cancellationException     ( 0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.M_isHandled                               = GetBool(new IntPtr(p + 0x028)); // 0270D6B24A88 0x28 M_isHandled                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
