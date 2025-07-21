using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferWriter                             ModelClassType ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter Pointer
    // 018 Quality                                  ModelPrimitiveType int int int Int32
    // 01C Window                                   ModelPrimitiveType int int int Int32
    public partial class BrotliCompressor : DataModel
    {
        public ReusableLinkedArrayBufferWriter?         BufferWriter                            { get; set; }
        public int                                      Quality                                 { get; set; }
        public int                                      Window                                  { get; set; }

        public static BrotliCompressor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliCompressor() { Pointer= p0 };

            value.BufferWriter                              = GetObject<ReusableLinkedArrayBufferWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReusableLinkedArrayBufferWriter.FromPointer); // 0x10 BufferWriter                ( ModelClassType ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter Pointer )
            value.Quality                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Quality                     ( ModelPrimitiveType int int int Int32 )
            value.Window                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Window                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
