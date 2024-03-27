using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _buckets                                 int[] IL2CPP_TYPE_SZARRAY
    // 000 _entries                                 Entry<<var>>[] IL2CPP_TYPE_SZARRAY
    // 000 _numEntries                              int IL2CPP_TYPE_I4
    // 000 _extractKey                              ExtractKeyDelegate<<var>> IL2CPP_TYPE_GENERICINST
    public partial class XHashtableState
    {

        public static XHashtableState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XHashtableState();


            return value;
        }
    }
}
