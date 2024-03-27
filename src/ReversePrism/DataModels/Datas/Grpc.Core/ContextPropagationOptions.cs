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
    public partial class ContextPropagationOptions
    {
        public bool                                     PropagateDeadline                       { get; set; }
        public bool                                     PropagateCancellation                   { get; set; }

        public static ContextPropagationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextPropagationOptions();

            value.PropagateDeadline                         = GetBool(new IntPtr(p + 0x010)); // 0270D9362FD0 0x10 PropagateDeadline           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PropagateCancellation                     = GetBool(new IntPtr(p + 0x011)); // 0270D9362FF0 0x11 PropagateCancellation       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
