using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_list                                   000186532E70 ModelClassType SortedList SortedList SortedList Pointer
    public partial class PathList
    {
        public SortedList?                              M_list                                  { get; set; }

        public static PathList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PathList();

            value.M_list                                    = GetObject<SortedList>(new IntPtr(p + 0x010), ReversePrism.DataModels.SortedList.FromPointer); // 0270D7A37D40 0x10 M_list                      ( 000186532E70 ModelClassType SortedList SortedList SortedList Pointer )

            return value;
        }
    }
}
