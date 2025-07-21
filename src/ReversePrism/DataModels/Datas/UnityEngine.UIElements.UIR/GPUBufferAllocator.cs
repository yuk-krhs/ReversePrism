using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Low                                    ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer
    // 018 M_High                                   ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer
    public partial class GPUBufferAllocator : DataModel
    {
        public BestFitAllocator?                        M_Low                                   { get; set; }
        public BestFitAllocator?                        M_High                                  { get; set; }

        public static GPUBufferAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GPUBufferAllocator() { Pointer= p0 };

            value.M_Low                                     = GetObject<BestFitAllocator>(new IntPtr(p + 0x010), ReversePrism.DataModels.BestFitAllocator.FromPointer); // 0x10 M_Low                       ( ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer )
            value.M_High                                    = GetObject<BestFitAllocator>(new IntPtr(p + 0x018), ReversePrism.DataModels.BestFitAllocator.FromPointer); // 0x18 M_High                      ( ModelClassType BestFitAllocator BestFitAllocator BestFitAllocator Pointer )

            return value;
        }
    }
}
