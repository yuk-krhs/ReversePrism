using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseEC                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Ec                                       0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 020 Thread                                   000186688A80 ModelClassType Thread Thread Thread Pointer
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

            value.UseEC                                     = GetBool(new IntPtr(p + 0x010)); // 024666B2AF80 0x10 UseEC                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ec                                        = GetObject<ExecutionContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExecutionContext.FromPointer); // 024666B2AFA0 0x18 Ec                          ( 0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.Thread                                    = GetObject<Thread>(new IntPtr(p + 0x020), ReversePrism.DataModels.Thread.FromPointer); // 024666B2AFC0 0x20 Thread                      ( 000186688A80 ModelClassType Thread Thread Thread Pointer )

            return value;
        }
    }
}
