using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 PointerMemoryManager                     00018651BFF0 ModelClassType SliceMemoryManager SliceMemoryManager SliceMemoryManager Pointer
    public partial class SliceSegment : DataModel
    {
        public SliceMemoryManager?                      PointerMemoryManager                    { get; set; }

        public static SliceSegment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliceSegment() { Pointer= p0 };

            value.PointerMemoryManager                      = GetObject<SliceMemoryManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.SliceMemoryManager.FromPointer); // 024662FBAA98 0x30 PointerMemoryManager        ( 00018651BFF0 ModelClassType SliceMemoryManager SliceMemoryManager SliceMemoryManager Pointer )

            return value;
        }
    }
}
