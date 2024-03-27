using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _exception                               <object> IL2CPP_TYPE_OBJECT
    // 018 IsTerminating                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UnhandledExceptionEventArgs
    {
        public bool                                     IsTerminating                           { get; set; }

        public static UnhandledExceptionEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnhandledExceptionEventArgs();

            value.IsTerminating                             = GetBool(new IntPtr(p + 0x018)); // 0270D6A041E0 0x18 IsTerminating               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
