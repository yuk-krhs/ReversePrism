using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Start>k__BackingField                   Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 018 <End>k__BackingField                     Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 020 <Step>k__BackingField                    Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ArraySliceFilter
    {

        public static ArraySliceFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArraySliceFilter();


            return value;
        }
    }
}
