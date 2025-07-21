using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 7E8 Entries                                  ModelEnumListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    public partial class XMLAttributeText : DataModel
    {
        public List<Entry>?                             Entries                                 { get; set; }

        public static XMLAttributeText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLAttributeText() { Pointer= p0 };

            value.Entries                                   = GetEnumList<Entry>(new IntPtr(p + 0x7E8)); // 0x7E8 Entries                     ( ModelEnumListType List`1<Entry> List`1<Entry> List<Entry> Pointer )

            return value;
        }
    }
}
