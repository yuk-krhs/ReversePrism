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
    // 010 BigEndianUnicode                         ModelClassType Encoding Encoding Encoding Pointer
    // 018 Utf7Encoding                             ModelClassType Encoding Encoding Encoding Pointer
    // 020 Utf8Encoding                             ModelClassType Encoding Encoding Encoding Pointer
    // 028 Utf32Encoding                            ModelClassType Encoding Encoding Encoding Pointer
    // 030 AsciiEncoding                            ModelClassType Encoding Encoding Encoding Pointer
    // 038 Latin1Encoding                           ModelClassType Encoding Encoding Encoding Pointer
    // 040 encodings                                Dictionary`2<int, Encoding> IL2CPP_TYPE_GENERICINST
    // 000 MIMECONTF_MAILNEWS                       int IL2CPP_TYPE_I4
    // 000 MIMECONTF_BROWSER                        int IL2CPP_TYPE_I4
    // 000 MIMECONTF_SAVABLE_MAILNEWS               int IL2CPP_TYPE_I4
    // 000 MIMECONTF_SAVABLE_BROWSER                int IL2CPP_TYPE_I4
    // 000 CodePageDefault                          int IL2CPP_TYPE_I4
    // 000 CodePageNoOEM                            int IL2CPP_TYPE_I4
    // 000 CodePageNoMac                            int IL2CPP_TYPE_I4
    // 000 CodePageNoThread                         int IL2CPP_TYPE_I4
    // 000 CodePageNoSymbol                         int IL2CPP_TYPE_I4
    // 000 CodePageUnicode                          int IL2CPP_TYPE_I4
    // 000 CodePageBigEndian                        int IL2CPP_TYPE_I4
    // 000 CodePageWindows1252                      int IL2CPP_TYPE_I4
    // 000 CodePageMacGB2312                        int IL2CPP_TYPE_I4
    // 000 CodePageGB2312                           int IL2CPP_TYPE_I4
    // 000 CodePageMacKorean                        int IL2CPP_TYPE_I4
    // 000 CodePageDLLKorean                        int IL2CPP_TYPE_I4
    // 000 ISO2022JP                                int IL2CPP_TYPE_I4
    // 000 ISO2022JPESC                             int IL2CPP_TYPE_I4
    // 000 ISO2022JPSISO                            int IL2CPP_TYPE_I4
    // 000 ISOKorean                                int IL2CPP_TYPE_I4
    // 000 ISOSimplifiedCN                          int IL2CPP_TYPE_I4
    // 000 EUCJP                                    int IL2CPP_TYPE_I4
    // 000 ChineseHZ                                int IL2CPP_TYPE_I4
    // 000 DuplicateEUCCN                           int IL2CPP_TYPE_I4
    // 000 EUCCN                                    int IL2CPP_TYPE_I4
    // 000 EUCKR                                    int IL2CPP_TYPE_I4
    // 000 CodePageASCII                            int IL2CPP_TYPE_I4
    // 000 ISO_8859_1                               int IL2CPP_TYPE_I4
    // 000 ISCIIAssemese                            int IL2CPP_TYPE_I4
    // 000 ISCIIBengali                             int IL2CPP_TYPE_I4
    // 000 ISCIIDevanagari                          int IL2CPP_TYPE_I4
    // 000 ISCIIGujarathi                           int IL2CPP_TYPE_I4
    // 000 ISCIIKannada                             int IL2CPP_TYPE_I4
    // 000 ISCIIMalayalam                           int IL2CPP_TYPE_I4
    // 000 ISCIIOriya                               int IL2CPP_TYPE_I4
    // 000 ISCIIPanjabi                             int IL2CPP_TYPE_I4
    // 000 ISCIITamil                               int IL2CPP_TYPE_I4
    // 000 ISCIITelugu                              int IL2CPP_TYPE_I4
    // 000 GB18030                                  int IL2CPP_TYPE_I4
    // 000 ISO_8859_8I                              int IL2CPP_TYPE_I4
    // 000 ISO_8859_8_Visual                        int IL2CPP_TYPE_I4
    // 000 ENC50229                                 int IL2CPP_TYPE_I4
    // 000 CodePageUTF7                             int IL2CPP_TYPE_I4
    // 000 CodePageUTF8                             int IL2CPP_TYPE_I4
    // 000 CodePageUTF32                            int IL2CPP_TYPE_I4
    // 000 CodePageUTF32BE                          int IL2CPP_TYPE_I4
    // 010 M_codePage                               ModelPrimitiveType int int int Int32
    // 018 DataItem                                 ModelClassType CodePageDataItem CodePageDataItem CodePageDataItem Pointer
    // 020 M_deserializedFromEverett                ModelPrimitiveType bool bool bool Bool
    // 021 M_isReadOnly                             ModelPrimitiveType bool bool bool Bool
    // 028 EncoderFallback                          ModelClassType EncoderFallback EncoderFallback EncoderFallback Pointer
    // 030 DecoderFallback                          ModelClassType DecoderFallback DecoderFallback DecoderFallback Pointer
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

            value.BigEndianUnicode                          = GetObject<Encoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.Encoding.FromPointer); // 0x10 BigEndianUnicode            ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Utf7Encoding                              = GetObject<Encoding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Encoding.FromPointer); // 0x18 Utf7Encoding                ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Utf8Encoding                              = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0x20 Utf8Encoding                ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Utf32Encoding                             = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0x28 Utf32Encoding               ( ModelClassType Encoding Encoding Encoding Pointer )
            value.AsciiEncoding                             = GetObject<Encoding>(new IntPtr(p + 0x030), ReversePrism.DataModels.Encoding.FromPointer); // 0x30 AsciiEncoding               ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Latin1Encoding                            = GetObject<Encoding>(new IntPtr(p + 0x038), ReversePrism.DataModels.Encoding.FromPointer); // 0x38 Latin1Encoding              ( ModelClassType Encoding Encoding Encoding Pointer )
            value.M_codePage                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_codePage                  ( ModelPrimitiveType int int int Int32 )
            value.DataItem                                  = GetObject<CodePageDataItem>(new IntPtr(p + 0x018), ReversePrism.DataModels.CodePageDataItem.FromPointer); // 0x18 DataItem                    ( ModelClassType CodePageDataItem CodePageDataItem CodePageDataItem Pointer )
            value.M_deserializedFromEverett                 = GetBool(new IntPtr(p + 0x020)); // 0x20 M_deserializedFromEverett   ( ModelPrimitiveType bool bool bool Bool )
            value.M_isReadOnly                              = GetBool(new IntPtr(p + 0x021)); // 0x21 M_isReadOnly                ( ModelPrimitiveType bool bool bool Bool )
            value.EncoderFallback                           = GetObject<EncoderFallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.EncoderFallback.FromPointer); // 0x28 EncoderFallback             ( ModelClassType EncoderFallback EncoderFallback EncoderFallback Pointer )
            value.DecoderFallback                           = GetObject<DecoderFallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.DecoderFallback.FromPointer); // 0x30 DecoderFallback             ( ModelClassType DecoderFallback DecoderFallback DecoderFallback Pointer )

            return value;
        }
    }
}
