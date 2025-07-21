using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _exception                               <object> IL2CPP_TYPE_OBJECT
    // 018 IsTerminating                            ModelPrimitiveType bool bool bool Bool
    public partial class UnhandledExceptionEventArgs : DataModel
    {
        public bool                                     IsTerminating                           { get; set; }

        public static UnhandledExceptionEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnhandledExceptionEventArgs() { Pointer= p0 };

            value.IsTerminating                             = GetBool(new IntPtr(p + 0x018)); // 0x18 IsTerminating               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
