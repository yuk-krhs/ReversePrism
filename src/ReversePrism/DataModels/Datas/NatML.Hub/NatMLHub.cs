using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 URL                                      string IL2CPP_TYPE_STRING
    public partial class NatMLHub : DataModel
    {

        public static NatMLHub? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NatMLHub() { Pointer= p0 };


            return value;
        }
    }
}
