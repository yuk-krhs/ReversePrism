using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class GaussianWindow1D_Quaternion : DataModel
    {

        public static GaussianWindow1D_Quaternion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GaussianWindow1D_Quaternion() { Pointer= p0 };


            return value;
        }
    }
}
