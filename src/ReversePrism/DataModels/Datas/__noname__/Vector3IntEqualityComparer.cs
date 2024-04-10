using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  Vector3IntEqualityComparer IL2CPP_TYPE_CLASS
    public partial class Vector3IntEqualityComparer : DataModel
    {

        public static Vector3IntEqualityComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3IntEqualityComparer() { Pointer= p0 };


            return value;
        }
    }
}
