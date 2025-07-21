using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kEpsilon                                 double IL2CPP_TYPE_R8
    // 008 kMaxIntersectionTolerance                int IL2CPP_TYPE_I4
    public partial class PlanarGraph : DataModel
    {

        public static PlanarGraph? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlanarGraph() { Pointer= p0 };


            return value;
        }
    }
}
