using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseEC                                    ModelPrimitiveType bool bool bool Bool
    // 018 Ec                                       ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 020 Thread                                   ModelClassType Thread Thread Thread Pointer
    public partial class AsyncFlowControl : DataModel
    {
        public bool                                     UseEC                                   { get; set; }
        public ExecutionContext?                        Ec                                      { get; set; }
        public Thread?                                  Thread                                  { get; set; }

        public static AsyncFlowControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncFlowControl() { Pointer= p0 };

            value.UseEC                                     = GetBool(new IntPtr(p + 0x010)); // 0x10 UseEC                       ( ModelPrimitiveType bool bool bool Bool )
            value.Ec                                        = GetObject<ExecutionContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x18 Ec                          ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.Thread                                    = GetObject<Thread>(new IntPtr(p + 0x020), ReversePrism.DataModels.Thread.FromPointer); // 0x20 Thread                      ( ModelClassType Thread Thread Thread Pointer )

            return value;
        }
    }
}
