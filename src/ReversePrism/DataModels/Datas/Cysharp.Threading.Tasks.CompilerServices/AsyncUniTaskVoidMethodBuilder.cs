using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Runner                                   0001865E4180 ModelClassType IStateMachineRunner IStateMachineRunner IStateMachineRunner Pointer
    public partial class AsyncUniTaskVoidMethodBuilder : DataModel
    {
        public IStateMachineRunner?                     Runner                                  { get; set; }

        public static AsyncUniTaskVoidMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncUniTaskVoidMethodBuilder() { Pointer= p0 };

            value.Runner                                    = GetObject<IStateMachineRunner>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStateMachineRunner.FromPointer); // 0245A3DDA260 0x10 Runner                      ( 0001865E4180 ModelClassType IStateMachineRunner IStateMachineRunner IStateMachineRunner Pointer )

            return value;
        }
    }
}
