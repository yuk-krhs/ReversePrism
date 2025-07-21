using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_exception                              ModelClassType AggregateException AggregateException AggregateException Pointer
    // 018 M_observed                               ModelPrimitiveType bool bool bool Bool
    public partial class UnobservedTaskExceptionEventArgs : DataModel
    {
        public AggregateException?                      M_exception                             { get; set; }
        public bool                                     M_observed                              { get; set; }

        public static UnobservedTaskExceptionEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnobservedTaskExceptionEventArgs() { Pointer= p0 };

            value.M_exception                               = GetObject<AggregateException>(new IntPtr(p + 0x010), ReversePrism.DataModels.AggregateException.FromPointer); // 0x10 M_exception                 ( ModelClassType AggregateException AggregateException AggregateException Pointer )
            value.M_observed                                = GetBool(new IntPtr(p + 0x018)); // 0x18 M_observed                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
