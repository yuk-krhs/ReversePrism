using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Contents                                 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class StringDictionary : DataModel
    {
        public Hashtable?                               Contents                                { get; set; }

        public static StringDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringDictionary() { Pointer= p0 };

            value.Contents                                  = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 024667A0B388 0x10 Contents                    ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
