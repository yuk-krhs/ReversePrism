using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultEncoding                          Encoding IL2CPP_TYPE_CLASS
    // 008 unicodeEncoding                          Encoding IL2CPP_TYPE_CLASS
    // 010 BigEndianUnicode                         00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 018 Utf7Encoding                             00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 020 Utf8Encoding                             00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 028 Utf32Encoding                            00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 030 AsciiEncoding                            00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 038 Latin1Encoding                           00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer
    // 040 encodings                                Dictionary`2<int, Encoding> IL2CPP_TYPE_GENERICINST
    // 010 M_codePage                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 DataItem                                 0001865BF200 ModelClassType CodePageDataItem CodePageDataItem CodePageDataItem Pointer
    // 020 M_deserializedFromEverett                0001865976C0 ModelPrimitiveType bool bool bool Bool
    // 021 M_isReadOnly                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 EncoderFallback                          00018672C120 ModelClassType EncoderFallback EncoderFallback EncoderFallback Pointer
    // 030 DecoderFallback                          0001866AC6E0 ModelClassType DecoderFallback DecoderFallback DecoderFallback Pointer
    // 048 s_InternalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    public partial class Encoding : DataModel
    {
        public Encoding?                                BigEndianUnicode                        { get; set; }
        public Encoding?                                Utf7Encoding                            { get; set; }
        public Encoding?                                Utf8Encoding                            { get; set; }
        public Encoding?                                Utf32Encoding                           { get; set; }
        public Encoding?                                AsciiEncoding                           { get; set; }
        public Encoding?                                Latin1Encoding                          { get; set; }
        public int                                      M_codePage                              { get; set; }
        public CodePageDataItem?                        DataItem                                { get; set; }
        public bool                                     M_deserializedFromEverett               { get; set; }
        public bool                                     M_isReadOnly                            { get; set; }
        public EncoderFallback?                         EncoderFallback                         { get; set; }
        public DecoderFallback?                         DecoderFallback                         { get; set; }

        public static Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Encoding() { Pointer= p0 };

            value.BigEndianUnicode                          = GetObject<Encoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.Encoding.FromPointer); // 0245A33DB828 0x10 BigEndianUnicode            ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Utf7Encoding                              = GetObject<Encoding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Encoding.FromPointer); // 0245A33DB848 0x18 Utf7Encoding                ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Utf8Encoding                              = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0245A33DB868 0x20 Utf8Encoding                ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Utf32Encoding                             = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0245A33DB888 0x28 Utf32Encoding               ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.AsciiEncoding                             = GetObject<Encoding>(new IntPtr(p + 0x030), ReversePrism.DataModels.Encoding.FromPointer); // 0245A33DB8A8 0x30 AsciiEncoding               ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Latin1Encoding                            = GetObject<Encoding>(new IntPtr(p + 0x038), ReversePrism.DataModels.Encoding.FromPointer); // 0245A33DB8C8 0x38 Latin1Encoding              ( 00018672E3C0 ModelClassType Encoding Encoding Encoding Pointer )
            value.M_codePage                                = GetInt32(new IntPtr(p + 0x010)); // 0245A33DB908 0x10 M_codePage                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DataItem                                  = GetObject<CodePageDataItem>(new IntPtr(p + 0x018), ReversePrism.DataModels.CodePageDataItem.FromPointer); // 0245A33DB928 0x18 DataItem                    ( 0001865BF200 ModelClassType CodePageDataItem CodePageDataItem CodePageDataItem Pointer )
            value.M_deserializedFromEverett                 = GetBool(new IntPtr(p + 0x020)); // 0245A33DB948 0x20 M_deserializedFromEverett   ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )
            value.M_isReadOnly                              = GetBool(new IntPtr(p + 0x021)); // 0245A33DB968 0x21 M_isReadOnly                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EncoderFallback                           = GetObject<EncoderFallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.EncoderFallback.FromPointer); // 0245A33DB988 0x28 EncoderFallback             ( 00018672C120 ModelClassType EncoderFallback EncoderFallback EncoderFallback Pointer )
            value.DecoderFallback                           = GetObject<DecoderFallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.DecoderFallback.FromPointer); // 0245A33DB9A8 0x30 DecoderFallback             ( 0001866AC6E0 ModelClassType DecoderFallback DecoderFallback DecoderFallback Pointer )

            return value;
        }
    }
}
