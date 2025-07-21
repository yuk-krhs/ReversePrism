using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Nt                                       ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 NsMgr                                    ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 020 DocTypeName                              ModelPrimitiveType string string string String
    // 028 PubId                                    ModelPrimitiveType string string string String
    // 030 SysId                                    ModelPrimitiveType string string string String
    // 038 InternalSubset                           ModelPrimitiveType string string string String
    // 040 XmlLang                                  ModelPrimitiveType string string string String
    // 048 XmlSpace                                 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 050 BaseURI                                  ModelPrimitiveType string string string String
    // 058 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    public partial class XmlParserContext : DataModel
    {
        public XmlNameTable?                            Nt                                      { get; set; }
        public XmlNamespaceManager?                     NsMgr                                   { get; set; }
        public string                                   DocTypeName                             { get; set; }
        public string                                   PubId                                   { get; set; }
        public string                                   SysId                                   { get; set; }
        public string                                   InternalSubset                          { get; set; }
        public string                                   XmlLang                                 { get; set; }
        public XmlSpace                                 XmlSpace                                { get; set; }
        public string                                   BaseURI                                 { get; set; }
        public Encoding?                                Encoding                                { get; set; }

        public static XmlParserContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlParserContext() { Pointer= p0 };

            value.Nt                                        = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x10 Nt                          ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.NsMgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x18 NsMgr                       ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.DocTypeName                               = GetString(new IntPtr(p + 0x020)); // 0x20 DocTypeName                 ( ModelPrimitiveType string string string String )
            value.PubId                                     = GetString(new IntPtr(p + 0x028)); // 0x28 PubId                       ( ModelPrimitiveType string string string String )
            value.SysId                                     = GetString(new IntPtr(p + 0x030)); // 0x30 SysId                       ( ModelPrimitiveType string string string String )
            value.InternalSubset                            = GetString(new IntPtr(p + 0x038)); // 0x38 InternalSubset              ( ModelPrimitiveType string string string String )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x040)); // 0x40 XmlLang                     ( ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x048)); // 0x48 XmlSpace                    ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x050)); // 0x50 BaseURI                     ( ModelPrimitiveType string string string String )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x058), ReversePrism.DataModels.Encoding.FromPointer); // 0x58 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )

            return value;
        }
    }
}
