using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Keys                                     000186589390 ModelClassType Array Array Array Pointer
    // 018 Items                                    000186589390 ModelClassType Array Array Array Pointer
    // 020 Comparer                                 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer
    public partial class SorterGenericArray
    {
        public Array?                                   Keys                                    { get; set; }
        public Array?                                   Items                                   { get; set; }
        public IComparer?                               Comparer                                { get; set; }

        public static SorterGenericArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SorterGenericArray();

            value.Keys                                      = GetObject<Array>(new IntPtr(p + 0x010), ReversePrism.DataModels.Array.FromPointer); // 0270D6A37688 0x10 Keys                        ( 000186589390 ModelClassType Array Array Array Pointer )
            value.Items                                     = GetObject<Array>(new IntPtr(p + 0x018), ReversePrism.DataModels.Array.FromPointer); // 0270D6A376A8 0x18 Items                       ( 000186589390 ModelClassType Array Array Array Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IComparer.FromPointer); // 0270D6A376C8 0x20 Comparer                    ( 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer )

            return value;
        }
    }
}
