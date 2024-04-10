using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dictionary                               000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer
    public partial class DictionaryTraceRecord : DataModel
    {
        public IDictionary?                             Dictionary                              { get; set; }

        public static DictionaryTraceRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DictionaryTraceRecord() { Pointer= p0 };

            value.Dictionary                                = GetObject<IDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDictionary.FromPointer); // 0245A4D28818 0x10 Dictionary                  ( 000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer )

            return value;
        }
    }
}
