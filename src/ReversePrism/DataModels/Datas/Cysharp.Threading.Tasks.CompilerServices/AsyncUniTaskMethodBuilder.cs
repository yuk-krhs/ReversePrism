using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RunnerPromise                            0001865E4880 ModelClassType IStateMachineRunnerPromise IStateMachineRunnerPromise IStateMachineRunnerPromise Pointer
    // 018 Ex                                       0001865CA820 ModelClassType Exception Exception Exception Pointer
    public partial class AsyncUniTaskMethodBuilder
    {
        public IStateMachineRunnerPromise?              RunnerPromise                           { get; set; }
        public Exception?                               Ex                                      { get; set; }

        public static AsyncUniTaskMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncUniTaskMethodBuilder();

            value.RunnerPromise                             = GetObject<IStateMachineRunnerPromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStateMachineRunnerPromise.FromPointer); // 027003CBBD20 0x10 RunnerPromise               ( 0001865E4880 ModelClassType IStateMachineRunnerPromise IStateMachineRunnerPromise IStateMachineRunnerPromise Pointer )
            value.Ex                                        = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 027003CBBD40 0x18 Ex                          ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
