using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Nt                                       0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 018 NsMgr                                    0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 020 DocTypeName                              000186671910 ModelPrimitiveType string string string String
    // 028 PubId                                    000186671910 ModelPrimitiveType string string string String
    // 030 SysId                                    000186671910 ModelPrimitiveType string string string String
    // 038 InternalSubset                           000186671910 ModelPrimitiveType string string string String
    // 040 XmlLang                                  000186671910 ModelPrimitiveType string string string String
    // 048 XmlSpace                                 0001865CA260 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 050 BaseURI                                  000186671910 ModelPrimitiveType string string string String
    // 058 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
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

            value.Nt                                        = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 02466741D150 0x10 Nt                          ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.NsMgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 02466741D170 0x18 NsMgr                       ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.DocTypeName                               = GetString(new IntPtr(p + 0x020)); // 02466741D190 0x20 DocTypeName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PubId                                     = GetString(new IntPtr(p + 0x028)); // 02466741D1B0 0x28 PubId                       ( 000186671910 ModelPrimitiveType string string string String )
            value.SysId                                     = GetString(new IntPtr(p + 0x030)); // 02466741D1D0 0x30 SysId                       ( 000186671910 ModelPrimitiveType string string string String )
            value.InternalSubset                            = GetString(new IntPtr(p + 0x038)); // 02466741D1F0 0x38 InternalSubset              ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x040)); // 02466741D210 0x40 XmlLang                     ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x048)); // 02466741D230 0x48 XmlSpace                    ( 0001865CA260 ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x050)); // 02466741D250 0x50 BaseURI                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x058), ReversePrism.DataModels.Encoding.FromPointer); // 02466741D270 0x58 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )

            return value;
        }
    }
}
