using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_action                                 00018666D410 ModelClassType ITaskCompletionAction ITaskCompletionAction ITaskCompletionAction Pointer
    // 018 M_completingTask                         000186681620 ModelClassType Task Task Task Pointer
    public partial class CompletionActionInvoker : DataModel
    {
        public ITaskCompletionAction?                   M_action                                { get; set; }
        public Task?                                    M_completingTask                        { get; set; }

        public static CompletionActionInvoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompletionActionInvoker() { Pointer= p0 };

            value.M_action                                  = GetObject<ITaskCompletionAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITaskCompletionAction.FromPointer); // 024662CFCC40 0x10 M_action                    ( 00018666D410 ModelClassType ITaskCompletionAction ITaskCompletionAction ITaskCompletionAction Pointer )
            value.M_completingTask                          = GetObject<Task>(new IntPtr(p + 0x018), ReversePrism.DataModels.Task.FromPointer); // 024662CFCC60 0x18 M_completingTask            ( 000186681620 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
