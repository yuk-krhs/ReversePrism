using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 threadLocalInstance                      ThreadLocal`1<DefaultDeserializationContext> IL2CPP_TYPE_GENERICINST
    // 010 BufferReader                             ModelClassType IBufferReader IBufferReader IBufferReader Pointer
    // 018 PayloadLength                            ModelPrimitiveType int int int Int32
    // 020 CachedSliceBuffer                        ModelClassType ReusableSliceBuffer ReusableSliceBuffer ReusableSliceBuffer Pointer
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

            value.BufferReader                              = GetObject<IBufferReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.IBufferReader.FromPointer); // 0x10 BufferReader                ( ModelClassType IBufferReader IBufferReader IBufferReader Pointer )
            value.PayloadLength                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 PayloadLength               ( ModelPrimitiveType int int int Int32 )
            value.CachedSliceBuffer                         = GetObject<ReusableSliceBuffer>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReusableSliceBuffer.FromPointer); // 0x20 CachedSliceBuffer           ( ModelClassType ReusableSliceBuffer ReusableSliceBuffer ReusableSliceBuffer Pointer )

            return value;
        }
    }
}
