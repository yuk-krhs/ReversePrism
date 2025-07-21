using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 CoreReaderNameTable                      ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 ContentEvents                            ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer
    // 028 AttributeEvents                          ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer
    // 030 CachedNode                               ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    // 038 CacheState                               ModelEnumType CachingReaderState CachingReaderState CachingReaderState Int32
    // 03C ContentIndex                             ModelPrimitiveType int int int Int32
    // 040 AttributeCount                           ModelPrimitiveType int int int Int32
    // 044 ReturnOriginalStringValues               ModelPrimitiveType bool bool bool Bool
    // 048 CacheHandler                             ModelClassType CachingEventHandler CachingEventHandler CachingEventHandler Pointer
    // 050 CurrentAttrIndex                         ModelPrimitiveType int int int Int32
    // 054 CurrentContentIndex                      ModelPrimitiveType int int int Int32
    // 058 ReadAhead                                ModelPrimitiveType bool bool bool Bool
    // 060 LineInfo                                 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 068 TextNode                                 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
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

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 CoreReader                  ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CoreReaderNameTable                       = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x18 CoreReaderNameTable         ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.ContentEvents                             = GetObjectList<ValidatingReaderNodeData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0x20 ContentEvents               ( ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer )
            value.AttributeEvents                           = GetObjectList<ValidatingReaderNodeData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0x28 AttributeEvents             ( ModelClassListType ValidatingReaderNodeData[] ValidatingReaderNodeData[] List<ValidatingReaderNodeData> Pointer )
            value.CachedNode                                = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x030), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0x30 CachedNode                  ( ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )
            value.CacheState                                = (CachingReaderState)GetInt32(new IntPtr(p + 0x038)); // 0x38 CacheState                  ( ModelEnumType CachingReaderState CachingReaderState CachingReaderState Int32 )
            value.ContentIndex                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ContentIndex                ( ModelPrimitiveType int int int Int32 )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 AttributeCount              ( ModelPrimitiveType int int int Int32 )
            value.ReturnOriginalStringValues                = GetBool(new IntPtr(p + 0x044)); // 0x44 ReturnOriginalStringValues  ( ModelPrimitiveType bool bool bool Bool )
            value.CacheHandler                              = GetObject<CachingEventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.CachingEventHandler.FromPointer); // 0x48 CacheHandler                ( ModelClassType CachingEventHandler CachingEventHandler CachingEventHandler Pointer )
            value.CurrentAttrIndex                          = GetInt32(new IntPtr(p + 0x050)); // 0x50 CurrentAttrIndex            ( ModelPrimitiveType int int int Int32 )
            value.CurrentContentIndex                       = GetInt32(new IntPtr(p + 0x054)); // 0x54 CurrentContentIndex         ( ModelPrimitiveType int int int Int32 )
            value.ReadAhead                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 ReadAhead                   ( ModelPrimitiveType bool bool bool Bool )
            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0x60 LineInfo                    ( ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.TextNode                                  = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0x68 TextNode                    ( ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )

            return value;
        }
    }
}
