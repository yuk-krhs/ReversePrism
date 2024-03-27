using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferWriter                             00018667A3E0 ModelClassType ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter Pointer
    // 018 Quality                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 01C Window                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class BrotliCompressor
    {
        public ReusableLinkedArrayBufferWriter?         BufferWriter                            { get; set; }
        public int                                      Quality                                 { get; set; }
        public int                                      Window                                  { get; set; }

        public static BrotliCompressor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliCompressor();

            value.BufferWriter                              = GetObject<ReusableLinkedArrayBufferWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReusableLinkedArrayBufferWriter.FromPointer); // 0270DAFEC1B0 0x10 BufferWriter                ( 00018667A3E0 ModelClassType ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter Pointer )
            value.Quality                                   = GetInt32(new IntPtr(p + 0x018)); // 0270DAFEC1D0 0x18 Quality                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Window                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270DAFEC1F0 0x1C Window                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
