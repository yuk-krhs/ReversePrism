using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RunnerPromise                            ModelClassType IStateMachineRunnerPromise IStateMachineRunnerPromise IStateMachineRunnerPromise Pointer
    // 018 Ex                                       ModelClassType Exception Exception Exception Pointer
    public partial class AsyncUniTaskMethodBuilder : DataModel
    {
        public IStateMachineRunnerPromise?              RunnerPromise                           { get; set; }
        public Exception?                               Ex                                      { get; set; }

        public static AsyncUniTaskMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncUniTaskMethodBuilder() { Pointer= p0 };

            value.RunnerPromise                             = GetObject<IStateMachineRunnerPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStateMachineRunnerPromise.FromPointer); // 0x10 RunnerPromise               ( ModelClassType IStateMachineRunnerPromise IStateMachineRunnerPromise IStateMachineRunnerPromise Pointer )
            value.Ex                                        = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0x18 Ex                          ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
