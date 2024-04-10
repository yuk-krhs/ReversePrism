using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class APIUpdaterRuntimeHelpers : DataModel
    {

        public static APIUpdaterRuntimeHelpers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new APIUpdaterRuntimeHelpers() { Pointer= p0 };


            return value;
        }
    }
}
