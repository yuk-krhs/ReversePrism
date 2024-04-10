using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 CoreReaderNameTable                      0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 ContentEvents                            000185CB0008 ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer
    // 028 AttributeEvents                          000185CB0008 ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer
    // 030 CachedNode                               000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    // 038 CacheState                               0001867550F0 ModelEnumType CachingReaderState CachingReaderState CachingReaderState Int32
    // 03C ContentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 AttributeCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 ReturnOriginalStringValues               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 CacheHandler                             000186523530 ModelClassType CachingEventHandler CachingEventHandler CachingEventHandler Pointer
    // 050 CurrentAttrIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 CurrentContentIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 ReadAhead                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 LineInfo                                 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 068 TextNode                                 000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    public partial class XsdCachingReader : DataModel
    {
        public XmlReader?                               CoreReader                              { get; set; }
        public XmlNameTable?                            CoreReaderNameTable                     { get; set; }
        public List<ValidatingReaderNodeData>?          ContentEvents                           { get; set; }
        public List<ValidatingReaderNodeData>?          AttributeEvents                         { get; set; }
        public ValidatingReaderNodeData?                CachedNode                              { get; set; }
        public CachingReaderState                       CacheState                              { get; set; }
        public int                                      ContentIndex                            { get; set; }
        public int                                      AttributeCount                          { get; set; }
        public bool                                     ReturnOriginalStringValues              { get; set; }
        public CachingEventHandler?                     CacheHandler                            { get; set; }
        public int                                      CurrentAttrIndex                        { get; set; }
        public int                                      CurrentContentIndex                     { get; set; }
        public bool                                     ReadAhead                               { get; set; }
        public IXmlLineInfo?                            LineInfo                                { get; set; }
        public ValidatingReaderNodeData?                TextNode                                { get; set; }

        public static XsdCachingReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdCachingReader() { Pointer= p0 };

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0246674914E8 0x10 CoreReader                  ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CoreReaderNameTable                       = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667491508 0x18 CoreReaderNameTable         ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.ContentEvents                             = GetObjectList<ValidatingReaderNodeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 024667491528 0x20 ContentEvents               ( 000185CB0008 ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer )
            value.AttributeEvents                           = GetObjectList<ValidatingReaderNodeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 024667491548 0x28 AttributeEvents             ( 000185CB0008 ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer )
            value.CachedNode                                = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 024667491568 0x30 CachedNode                  ( 000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )
            value.CacheState                                = (CachingReaderState)GetInt32(new IntPtr(p + 0x038)); // 024667491588 0x38 CacheState                  ( 0001867550F0 ModelEnumType CachingReaderState CachingReaderState CachingReaderState Int32 )
            value.ContentIndex                              = GetInt32(new IntPtr(p + 0x03C)); // 0246674915A8 0x3C ContentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x040)); // 0246674915C8 0x40 AttributeCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReturnOriginalStringValues                = GetBool(new IntPtr(p + 0x044)); // 0246674915E8 0x44 ReturnOriginalStringValues  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CacheHandler                              = GetObject<CachingEventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.CachingEventHandler.FromPointer); // 024667491608 0x48 CacheHandler                ( 000186523530 ModelClassType CachingEventHandler CachingEventHandler CachingEventHandler Pointer )
            value.CurrentAttrIndex                          = GetInt32(new IntPtr(p + 0x050)); // 024667491628 0x50 CurrentAttrIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentContentIndex                       = GetInt32(new IntPtr(p + 0x054)); // 024667491648 0x54 CurrentContentIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadAhead                                 = GetBool(new IntPtr(p + 0x058)); // 024667491668 0x58 ReadAhead                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 024667491688 0x60 LineInfo                    ( 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.TextNode                                  = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0246674916A8 0x68 TextNode                    ( 000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )

            return value;
        }
    }
}
