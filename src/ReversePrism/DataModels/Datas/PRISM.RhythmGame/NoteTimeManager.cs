using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     000185D278E8 ModelEnumListType List`1<Data> List`1<Data> List<Data> Pointer
    public partial class NoteTimeManager
    {
        public List<Data>?                              List                                    { get; set; }

        public static NoteTimeManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteTimeManager();

            value.List                                      = GetEnumList<Data>(new IntPtr(p + 0x010)); // 0270D4F99380 0x10 List                        ( 000185D278E8 ModelEnumListType List`1<Data> List`1<Data> List<Data> Pointer )

            return value;
        }
    }
}
