using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ReadBuffer                               ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer
    public partial class BufferedReadStream : DataModel
    {
        public BufferOffsetSize?                        ReadBuffer                              { get; set; }

        public static BufferedReadStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferedReadStream() { Pointer= p0 };

            value.ReadBuffer                                = GetObject<BufferOffsetSize>(new IntPtr(p + 0x040), ReversePrism.DataModels.BufferOffsetSize.FromPointer); // 0x40 ReadBuffer                  ( ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer )

            return value;
        }
    }
}
