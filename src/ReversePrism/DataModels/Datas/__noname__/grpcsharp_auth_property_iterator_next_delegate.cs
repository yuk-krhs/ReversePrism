using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class grpcsharp_auth_property_iterator_next_delegate : DataModel
    {

        public static grpcsharp_auth_property_iterator_next_delegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new grpcsharp_auth_property_iterator_next_delegate() { Pointer= p0 };


            return value;
        }
    }
}
