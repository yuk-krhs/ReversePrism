using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 List                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class ReadOnlyArrayList : DataModel
    {
        public ArrayList?                               List                                    { get; set; }

        public static ReadOnlyArrayList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadOnlyArrayList() { Pointer= p0 };

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
