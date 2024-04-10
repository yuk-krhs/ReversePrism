using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class grpcsharp_secure_channel_create_delegate : DataModel
    {

        public static grpcsharp_secure_channel_create_delegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new grpcsharp_secure_channel_create_delegate() { Pointer= p0 };


            return value;
        }
    }
}
