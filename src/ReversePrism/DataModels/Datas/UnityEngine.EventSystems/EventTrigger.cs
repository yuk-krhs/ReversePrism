using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Delegates                              ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer
    public partial class EventTrigger : DataModel
    {
        public List<Entry>?                             M_Delegates                             { get; set; }

        public static EventTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventTrigger() { Pointer= p0 };

            value.M_Delegates                               = GetObjectList<Entry>(new IntPtr(p + 0x020), ReversePrism.DataModels.Entry.FromPointer); // 0x20 M_Delegates                 ( ModelClassListType List`1<Entry> List`1<Entry> List<Entry> Pointer )

            return value;
        }
    }
}
