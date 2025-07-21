using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keys                                     ModelClassType Array Array Array Pointer
    // 018 Items                                    ModelClassType Array Array Array Pointer
    // 020 Comparer                                 ModelClassType IComparer IComparer IComparer Pointer
    public partial class SorterGenericArray : DataModel
    {
        public Array?                                   Keys                                    { get; set; }
        public Array?                                   Items                                   { get; set; }
        public IComparer?                               Comparer                                { get; set; }

        public static SorterGenericArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SorterGenericArray() { Pointer= p0 };

            value.Keys                                      = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 0x10 Keys                        ( ModelClassType Array Array Array Pointer )
            value.Items                                     = GetObject<Array>(new IntPtr(p + 0x018), ReversePrism.DataModels.Array.FromPointer); // 0x18 Items                       ( ModelClassType Array Array Array Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IComparer.FromPointer); // 0x20 Comparer                    ( ModelClassType IComparer IComparer IComparer Pointer )

            return value;
        }
    }
}
