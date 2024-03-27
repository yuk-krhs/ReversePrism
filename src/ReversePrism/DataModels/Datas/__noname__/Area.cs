using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     000186651230 ModelEnumType RectInt RectInt RectInt Int32
    // 020 Allocator                                00018674EC40 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer
    public partial class Area
    {
        public RectInt                                  Rect                                    { get; set; }
        public BestFitAllocator?                        Allocator                               { get; set; }

        public static Area? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Area();

            value.Rect                                      = (RectInt)GetInt32(new IntPtr(p + 0x010)); // 02700685F9C8 0x10 Rect                        ( 000186651230 ModelEnumType RectInt RectInt RectInt Int32 )
            value.Allocator                                 = GetObject<BestFitAllocator>(new IntPtr(p + 0x020), ReversePrism.DataModels.BestFitAllocator.FromPointer); // 02700685F9E8 0x20 Allocator                   ( 00018674EC40 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer )

            return value;
        }
    }
}
