using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Slice                                    000186668D70 ModelEnumType Slice Slice Slice Int32
    public partial class SliceMemoryManager
    {
        public Slice                                    Slice                                   { get; set; }

        public static SliceMemoryManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliceMemoryManager();

            value.Slice                                     = (Slice)GetInt32(new IntPtr(p + 0x010)); // 0270D3054498 0x10 Slice                       ( 000186668D70 ModelEnumType Slice Slice Slice Int32 )

            return value;
        }
    }
}
