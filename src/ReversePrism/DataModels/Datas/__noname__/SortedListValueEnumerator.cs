using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _sortedList                              SortedList`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 _index                                   int IL2CPP_TYPE_I4
    // 000 _version                                 int IL2CPP_TYPE_I4
    // 000 _currentValue                            <var> IL2CPP_TYPE_VAR
    public partial class SortedListValueEnumerator
    {

        public static SortedListValueEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortedListValueEnumerator();


            return value;
        }
    }
}
