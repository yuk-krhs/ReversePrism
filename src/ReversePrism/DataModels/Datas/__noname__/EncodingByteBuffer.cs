using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 bytes                                    IntPtr IL2CPP_TYPE_PTR
    // 018 byteStart                                IntPtr IL2CPP_TYPE_PTR
    // 020 byteEnd                                  IntPtr IL2CPP_TYPE_PTR
    // 028 chars                                    IntPtr IL2CPP_TYPE_PTR
    // 030 charStart                                IntPtr IL2CPP_TYPE_PTR
    // 038 charEnd                                  IntPtr IL2CPP_TYPE_PTR
    // 040 ByteCountResult                          ModelPrimitiveType int int int Int32
    // 048 Enc                                      ModelClassType Encoding Encoding Encoding Pointer
    // 050 Encoder                                  ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer
    // 058 FallbackBuffer                           ModelClassType EncoderFallbackBuffer EncoderFallbackBuffer EncoderFallbackBuffer Pointer
    public partial class EncodingByteBuffer : DataModel
    {
        public int                                      ByteCountResult                         { get; set; }
        public Encoding?                                Enc                                     { get; set; }
        public EncoderNLS?                              Encoder                                 { get; set; }
        public EncoderFallbackBuffer?                   FallbackBuffer                          { get; set; }

        public static EncodingByteBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncodingByteBuffer() { Pointer= p0 };

            value.ByteCountResult                           = GetInt32(new IntPtr(p + 0x040)); // 0x40 ByteCountResult             ( ModelPrimitiveType int int int Int32 )
            value.Enc                                       = GetObject<Encoding>(new IntPtr(p + 0x048), ReversePrism.DataModels.Encoding.FromPointer); // 0x48 Enc                         ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Encoder                                   = GetObject<EncoderNLS>(new IntPtr(p + 0x050), ReversePrism.DataModels.EncoderNLS.FromPointer); // 0x50 Encoder                     ( ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer )
            value.FallbackBuffer                            = GetObject<EncoderFallbackBuffer>(new IntPtr(p + 0x058), ReversePrism.DataModels.EncoderFallbackBuffer.FromPointer); // 0x58 FallbackBuffer              ( ModelClassType EncoderFallbackBuffer EncoderFallbackBuffer EncoderFallbackBuffer Pointer )

            return value;
        }
    }
}
