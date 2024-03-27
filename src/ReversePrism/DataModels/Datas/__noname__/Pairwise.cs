using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 prev                                     <var> IL2CPP_TYPE_VAR
    // 000 isFirst                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class Pairwise
    {

        public static Pairwise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pairwise();


            return value;
        }
    }
}
