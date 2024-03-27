using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Data                                     IntPtr IL2CPP_TYPE_PTR
    // 000 Comp                                     <var> IL2CPP_TYPE_VAR
    // 000 Length                                   int IL2CPP_TYPE_I4
    // 000 SegmentWidth                             int IL2CPP_TYPE_I4
    public partial class SegmentSortMerge
    {

        public static SegmentSortMerge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SegmentSortMerge();


            return value;
        }
    }
}
