using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChunkSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 BytesRemaining                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Part                                     000186739480 ModelClassType MimePart MimePart MimePart Pointer
    // 020 ReadState                                00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32
    // 028 ParentReader                             000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 030 StringValue                              000186671910 ModelPrimitiveType string string string String
    // 038 StringOffset                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C NodeType                                 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 040 BinHexStream                             0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer
    // 048 ValueBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 ValueOffset                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 ValueCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 FinishedStream                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XopIncludeReader : DataModel
    {
        public int                                      ChunkSize                               { get; set; }
        public int                                      BytesRemaining                          { get; set; }
        public MimePart?                                Part                                    { get; set; }
        public ReadState                                ReadState                               { get; set; }
        public XmlDictionaryReader?                     ParentReader                            { get; set; }
        public string                                   StringValue                             { get; set; }
        public int                                      StringOffset                            { get; set; }
        public XmlNodeType                              NodeType                                { get; set; }
        public MemoryStream?                            BinHexStream                            { get; set; }
        public List<sbyte>?                             ValueBuffer                             { get; set; }
        public int                                      ValueOffset                             { get; set; }
        public int                                      ValueCount                              { get; set; }
        public bool                                     FinishedStream                          { get; set; }

        public static XopIncludeReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XopIncludeReader() { Pointer= p0 };

            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x010)); // 024667CBDFA0 0x10 ChunkSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BytesRemaining                            = GetInt32(new IntPtr(p + 0x014)); // 024667CBDFC0 0x14 BytesRemaining              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Part                                      = GetObject<MimePart>(new IntPtr(p + 0x018), ReversePrism.DataModels.MimePart.FromPointer); // 024667CBDFE0 0x18 Part                        ( 000186739480 ModelClassType MimePart MimePart MimePart Pointer )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x020)); // 024667CBE000 0x20 ReadState                   ( 00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32 )
            value.ParentReader                              = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 024667CBE020 0x28 ParentReader                ( 000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.StringValue                               = GetString(new IntPtr(p + 0x030)); // 024667CBE040 0x30 StringValue                 ( 000186671910 ModelPrimitiveType string string string String )
            value.StringOffset                              = GetInt32(new IntPtr(p + 0x038)); // 024667CBE060 0x38 StringOffset                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x03C)); // 024667CBE080 0x3C NodeType                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.BinHexStream                              = GetObject<MemoryStream>(new IntPtr(p + 0x040), ReversePrism.DataModels.MemoryStream.FromPointer); // 024667CBE0A0 0x40 BinHexStream                ( 0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer )
            value.ValueBuffer                               = GetSByteList(new IntPtr(p + 0x048)); // 024667CBE0C0 0x48 ValueBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ValueOffset                               = GetInt32(new IntPtr(p + 0x050)); // 024667CBE0E0 0x50 ValueOffset                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValueCount                                = GetInt32(new IntPtr(p + 0x054)); // 024667CBE100 0x54 ValueCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FinishedStream                            = GetBool(new IntPtr(p + 0x058)); // 024667CBE120 0x58 FinishedStream              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
