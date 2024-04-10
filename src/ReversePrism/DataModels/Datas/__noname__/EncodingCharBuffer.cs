using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 chars                                    IntPtr IL2CPP_TYPE_PTR
    // 018 charStart                                IntPtr IL2CPP_TYPE_PTR
    // 020 charEnd                                  IntPtr IL2CPP_TYPE_PTR
    // 028 CharCountResult                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Enc                                      00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 038 Decoder                                  0001866AD7F0 ModelClassType DecoderNLS DecoderNLS DecoderNLS Pointer
    // 040 byteStart                                IntPtr IL2CPP_TYPE_PTR
    // 048 byteEnd                                  IntPtr IL2CPP_TYPE_PTR
    // 050 bytes                                    IntPtr IL2CPP_TYPE_PTR
    // 058 FallbackBuffer                           0001866ACE20 ModelClassType DecoderFallbackBuffer DecoderFallbackBuffer DecoderFallbackBuffer Pointer
    public partial class EncodingCharBuffer : DataModel
    {
        public int                                      CharCountResult                         { get; set; }
        public Encoding?                                Enc                                     { get; set; }
        public DecoderNLS?                              Decoder                                 { get; set; }
        public DecoderFallbackBuffer?                   FallbackBuffer                          { get; set; }

        public static EncodingCharBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EncodingCharBuffer() { Pointer= p0 };

            value.CharCountResult                           = GetInt32(new IntPtr(p + 0x028)); // 024666BDE7F0 0x28 CharCountResult             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Enc                                       = GetObject<Encoding>(new IntPtr(p + 0x030), ReversePrism.DataModels.Encoding.FromPointer); // 024666BDE810 0x30 Enc                         ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Decoder                                   = GetObject<DecoderNLS>(new IntPtr(p + 0x038), ReversePrism.DataModels.DecoderNLS.FromPointer); // 024666BDE830 0x38 Decoder                     ( 0001866AD7F0 ModelClassType DecoderNLS DecoderNLS DecoderNLS Pointer )
            value.FallbackBuffer                            = GetObject<DecoderFallbackBuffer>(new IntPtr(p + 0x058), ReversePrism.DataModels.DecoderFallbackBuffer.FromPointer); // 024666BDE8B0 0x58 FallbackBuffer              ( 0001866ACE20 ModelClassType DecoderFallbackBuffer DecoderFallbackBuffer DecoderFallbackBuffer Pointer )

            return value;
        }
    }
}
