using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Low                                    00018674EA00 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer
    // 018 M_High                                   00018674EA00 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer
    public partial class GPUBufferAllocator
    {
        public BestFitAllocator?                        M_Low                                   { get; set; }
        public BestFitAllocator?                        M_High                                  { get; set; }

        public static GPUBufferAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GPUBufferAllocator();

            value.M_Low                                     = GetObject<BestFitAllocator>(new IntPtr(p + 0x010), ReversePrism.DataModels.BestFitAllocator.FromPointer); // 0270068623B8 0x10 M_Low                       ( 00018674EA00 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer )
            value.M_High                                    = GetObject<BestFitAllocator>(new IntPtr(p + 0x018), ReversePrism.DataModels.BestFitAllocator.FromPointer); // 0270068623D8 0x18 M_High                      ( 00018674EA00 ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer )

            return value;
        }
    }
}
