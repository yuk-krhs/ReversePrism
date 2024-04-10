using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StaticInstance                           PathListComparer IL2CPP_TYPE_CLASS
    public partial class PathListComparer : DataModel
    {

        public static PathListComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PathListComparer() { Pointer= p0 };


            return value;
        }
    }
}
