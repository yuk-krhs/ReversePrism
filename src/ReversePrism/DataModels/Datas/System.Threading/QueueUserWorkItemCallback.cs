using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 00018653F270 ModelClassType WaitCallback WaitCallback WaitCallback Pointer
    // 018 Context                                  0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 020 state                                    <object> IL2CPP_TYPE_OBJECT
    // 000 ccb                                      ContextCallback IL2CPP_TYPE_CLASS
    public partial class QueueUserWorkItemCallback : DataModel
    {
        public WaitCallback?                            Callback                                { get; set; }
        public ExecutionContext?                        Context                                 { get; set; }

        public static QueueUserWorkItemCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueueUserWorkItemCallback() { Pointer= p0 };

            value.Callback                                  = GetObject<WaitCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitCallback.FromPointer); // 0245A3AFD488 0x10 Callback                    ( 00018653F270 ModelClassType WaitCallback WaitCallback WaitCallback Pointer )
            value.Context                                   = GetObject<ExecutionContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0245A3AFD4A8 0x18 Context                     ( 0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )

            return value;
        }
    }
}
