using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class ReadOnlyCollectionBase : DataModel
    {
        public ArrayList?                               List                                    { get; set; }

        public static ReadOnlyCollectionBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadOnlyCollectionBase() { Pointer= p0 };

            value.List                                      = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0x10 List                        ( ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
