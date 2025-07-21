using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChunkSize                                ModelPrimitiveType int int int Int32
    // 014 BytesRemaining                           ModelPrimitiveType int int int Int32
    // 018 Part                                     ModelClassType MimePart MimePart MimePart Pointer
    // 020 ReadState                                ModelEnumType ReadState ReadState ReadState Int32
    // 028 ParentReader                             ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 030 StringValue                              ModelPrimitiveType string string string String
    // 038 StringOffset                             ModelPrimitiveType int int int Int32
    // 03C NodeType                                 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 040 BinHexStream                             ModelClassType MemoryStream MemoryStream MemoryStream Pointer
    // 048 ValueBuffer                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 ValueOffset                              ModelPrimitiveType int int int Int32
    // 054 ValueCount                               ModelPrimitiveType int int int Int32
    // 058 FinishedStream                           ModelPrimitiveType bool bool bool Bool
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

            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChunkSize                   ( ModelPrimitiveType int int int Int32 )
            value.BytesRemaining                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 BytesRemaining              ( ModelPrimitiveType int int int Int32 )
            value.Part                                      = GetObject<MimePart>(new IntPtr(p + 0x018), ReversePrism.DataModels.MimePart.FromPointer); // 0x18 Part                        ( ModelClassType MimePart MimePart MimePart Pointer )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x020)); // 0x20 ReadState                   ( ModelEnumType ReadState ReadState ReadState Int32 )
            value.ParentReader                              = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 0x28 ParentReader                ( ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.StringValue                               = GetString(new IntPtr(p + 0x030)); // 0x30 StringValue                 ( ModelPrimitiveType string string string String )
            value.StringOffset                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 StringOffset                ( ModelPrimitiveType int int int Int32 )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C NodeType                    ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.BinHexStream                              = GetObject<MemoryStream>(new IntPtr(p + 0x040), ReversePrism.DataModels.MemoryStream.FromPointer); // 0x40 BinHexStream                ( ModelClassType MemoryStream MemoryStream MemoryStream Pointer )
            value.ValueBuffer                               = GetSByteList(new IntPtr(p + 0x048)); // 0x48 ValueBuffer                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ValueOffset                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 ValueOffset                 ( ModelPrimitiveType int int int Int32 )
            value.ValueCount                                = GetInt32(new IntPtr(p + 0x054)); // 0x54 ValueCount                  ( ModelPrimitiveType int int int Int32 )
            value.FinishedStream                            = GetBool(new IntPtr(p + 0x058)); // 0x58 FinishedStream              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
