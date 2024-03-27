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
    // 040 ByteCountResult                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 Enc                                      00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 050 Encoder                                  00018672CFA0 ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer
    // 058 FallbackBuffer                           00018672C7E0 ModelClassType EncoderFallbackBuffer EncoderFallbackBuffer EncoderFallbackBuffer Pointer
    public partial class EncodingByteBuffer
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
            var value   = new EncodingByteBuffer();

            value.ByteCountResult                           = GetInt32(new IntPtr(p + 0x040)); // 0270D6B66E28 0x40 ByteCountResult             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Enc                                       = GetObject<Encoding>(new IntPtr(p + 0x048), ReversePrism.DataModels.Encoding.FromPointer); // 0270D6B66E48 0x48 Enc                         ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Encoder                                   = GetObject<EncoderNLS>(new IntPtr(p + 0x050), ReversePrism.DataModels.EncoderNLS.FromPointer); // 0270D6B66E68 0x50 Encoder                     ( 00018672CFA0 ModelClassType EncoderNLS EncoderNLS EncoderNLS Pointer )
            value.FallbackBuffer                            = GetObject<EncoderFallbackBuffer>(new IntPtr(p + 0x058), ReversePrism.DataModels.EncoderFallbackBuffer.FromPointer); // 0270D6B66E88 0x58 FallbackBuffer              ( 00018672C7E0 ModelClassType EncoderFallbackBuffer EncoderFallbackBuffer EncoderFallbackBuffer Pointer )

            return value;
        }
    }
}
