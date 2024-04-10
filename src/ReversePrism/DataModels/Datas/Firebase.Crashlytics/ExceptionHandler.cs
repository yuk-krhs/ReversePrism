using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsRegistered                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ExceptionHandler : DataModel
    {
        public bool                                     IsRegistered                            { get; set; }

        public static ExceptionHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionHandler() { Pointer= p0 };

            value.IsRegistered                              = GetBool(new IntPtr(p + 0x010)); // 02466BCDFB88 0x10 IsRegistered                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
