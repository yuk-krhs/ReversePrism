using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  ContextPropagationOptions IL2CPP_TYPE_CLASS
    // 010 PropagateDeadline                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 PropagateCancellation                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ContextPropagationOptions : DataModel
    {
        public bool                                     PropagateDeadline                       { get; set; }
        public bool                                     PropagateCancellation                   { get; set; }

        public static ContextPropagationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextPropagationOptions() { Pointer= p0 };

            value.PropagateDeadline                         = GetBool(new IntPtr(p + 0x010)); // 0246693B51D8 0x10 PropagateDeadline           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PropagateCancellation                     = GetBool(new IntPtr(p + 0x011)); // 0246693B51F8 0x11 PropagateCancellation       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
