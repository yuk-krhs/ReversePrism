using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 encodingLookup                           KeyValuePair`2<sbyte[], Encoding>[] IL2CPP_TYPE_SZARRAY
    // 008 targetEncoding                           Encoding IL2CPP_TYPE_CLASS
    public partial class EncodingUtility : DataModel
    {

        public static EncodingUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncodingUtility() { Pointer= p0 };


            return value;
        }
    }
}
