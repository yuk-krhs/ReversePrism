using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 UserBuffer                               ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer
    // 040 CurrentSize                              ModelPrimitiveType int int int Int32
    public partial class AsyncReadOrWriteRequest : DataModel
    {
        public BufferOffsetSize?                        UserBuffer                              { get; set; }
        public int                                      CurrentSize                             { get; set; }

        public static AsyncReadOrWriteRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncReadOrWriteRequest() { Pointer= p0 };

            value.UserBuffer                                = GetObject<BufferOffsetSize>(new IntPtr(p + 0x038), ReversePrism.DataModels.BufferOffsetSize.FromPointer); // 0x38 UserBuffer                  ( ModelClassType BufferOffsetSize BufferOffsetSize BufferOffsetSize Pointer )
            value.CurrentSize                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentSize                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
