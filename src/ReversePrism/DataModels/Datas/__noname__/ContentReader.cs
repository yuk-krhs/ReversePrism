using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ECache                                   00018667D490 ModelEnumType NamespaceCache NamespaceCache NamespaceCache Int32
    // 020 ACache                                   00018667D490 ModelEnumType NamespaceCache NamespaceCache NamespaceCache Int32
    // 030 LineInfo                                 00018669FE10 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 038 CurrentContainer                         000186573360 ModelClassType XContainer XContainer XContainer Pointer
    // 040 BaseUri                                  000186671910 ModelPrimitiveType string string string String
    public partial class ContentReader
    {
        public NamespaceCache                           ECache                                  { get; set; }
        public NamespaceCache                           ACache                                  { get; set; }
        public IXmlLineInfo?                            LineInfo                                { get; set; }
        public XContainer?                              CurrentContainer                        { get; set; }
        public string                                   BaseUri                                 { get; set; }

        public static ContentReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentReader();

            value.ECache                                    = (NamespaceCache)GetInt32(new IntPtr(p + 0x010)); // 0270DBC16C88 0x10 ECache                      ( 00018667D490 ModelEnumType NamespaceCache NamespaceCache NamespaceCache Int32 )
            value.ACache                                    = (NamespaceCache)GetInt32(new IntPtr(p + 0x020)); // 0270DBC16CA8 0x20 ACache                      ( 00018667D490 ModelEnumType NamespaceCache NamespaceCache NamespaceCache Int32 )
            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0270DBC16CC8 0x30 LineInfo                    ( 00018669FE10 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.CurrentContainer                          = GetObject<XContainer>(new IntPtr(p + 0x038), ReversePrism.DataModels.XContainer.FromPointer); // 0270DBC16CE8 0x38 CurrentContainer            ( 000186573360 ModelClassType XContainer XContainer XContainer Pointer )
            value.BaseUri                                   = GetString(new IntPtr(p + 0x040)); // 0270DBC16D08 0x40 BaseUri                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
