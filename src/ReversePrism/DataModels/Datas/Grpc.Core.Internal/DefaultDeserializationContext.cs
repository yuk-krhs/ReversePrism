using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 threadLocalInstance                      ThreadLocal`1<DefaultDeserializationContext> IL2CPP_TYPE_GENERICINST
    // 010 BufferReader                             000186712550 ModelClassType IBufferReader IBufferReader IBufferReader Pointer
    // 018 PayloadLength                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CachedSliceBuffer                        00018667BC20 ModelClassType ReusableSliceBuffer ReusableSliceBuffer ReusableSliceBuffer Pointer
    public partial class DefaultDeserializationContext : DataModel
    {
        public IBufferReader?                           BufferReader                            { get; set; }
        public int                                      PayloadLength                           { get; set; }
        public ReusableSliceBuffer?                     CachedSliceBuffer                       { get; set; }

        public static DefaultDeserializationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultDeserializationContext() { Pointer= p0 };

            value.BufferReader                              = GetObject<IBufferReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.IBufferReader.FromPointer); // 024662FB8408 0x10 BufferReader                ( 000186712550 ModelClassType IBufferReader IBufferReader IBufferReader Pointer )
            value.PayloadLength                             = GetInt32(new IntPtr(p + 0x018)); // 024662FB8428 0x18 PayloadLength               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CachedSliceBuffer                         = GetObject<ReusableSliceBuffer>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReusableSliceBuffer.FromPointer); // 024662FB8448 0x20 CachedSliceBuffer           ( 00018667BC20 ModelClassType ReusableSliceBuffer ReusableSliceBuffer ReusableSliceBuffer Pointer )

            return value;
        }
    }
}
