using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 List                                     000186532E70 ModelClassType SortedList SortedList SortedList Pointer
    // 050 _root                                    <object> IL2CPP_TYPE_OBJECT
    public partial class SyncSortedList : DataModel
    {
        public SortedList?                              List                                    { get; set; }

        public static SyncSortedList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncSortedList() { Pointer= p0 };

            value.List                                      = GetObject<SortedList>(new IntPtr(p + 0x048), ReversePrism.DataModels.SortedList.FromPointer); // 024666DD01E0 0x48 List                        ( 000186532E70 ModelClassType SortedList SortedList SortedList Pointer )

            return value;
        }
    }
}
