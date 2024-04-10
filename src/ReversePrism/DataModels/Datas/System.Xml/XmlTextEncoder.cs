using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextWriter                               00018664BAC0 ModelClassType TextWriter TextWriter TextWriter Pointer
    // 018 InAttribute                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A quoteChar                                char IL2CPP_TYPE_CHAR
    // 020 AttrValue                                000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 028 CacheAttrValue                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    public partial class XmlTextEncoder : DataModel
    {
        public TextWriter?                              TextWriter                              { get; set; }
        public bool                                     InAttribute                             { get; set; }
        public StringBuilder?                           AttrValue                               { get; set; }
        public bool                                     CacheAttrValue                          { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }

        public static XmlTextEncoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTextEncoder() { Pointer= p0 };

            value.TextWriter                                = GetObject<TextWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextWriter.FromPointer); // 02466739A0A8 0x10 TextWriter                  ( 00018664BAC0 ModelClassType TextWriter TextWriter TextWriter Pointer )
            value.InAttribute                               = GetBool(new IntPtr(p + 0x018)); // 02466739A0C8 0x18 InAttribute                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AttrValue                                 = GetObject<StringBuilder>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringBuilder.FromPointer); // 02466739A108 0x20 AttrValue                   ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.CacheAttrValue                            = GetBool(new IntPtr(p + 0x028)); // 02466739A128 0x28 CacheAttrValue              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x030)); // 02466739A148 0x30 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )

            return value;
        }
    }
}
