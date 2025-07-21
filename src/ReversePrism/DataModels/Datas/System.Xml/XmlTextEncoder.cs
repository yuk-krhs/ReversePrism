using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextWriter                               ModelClassType TextWriter TextWriter TextWriter Pointer
    // 018 InAttribute                              ModelPrimitiveType bool bool bool Bool
    // 01A quoteChar                                char IL2CPP_TYPE_CHAR
    // 020 AttrValue                                ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 028 CacheAttrValue                           ModelPrimitiveType bool bool bool Bool
    // 030 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
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

            value.TextWriter                                = GetObject<TextWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextWriter.FromPointer); // 0x10 TextWriter                  ( ModelClassType TextWriter TextWriter TextWriter Pointer )
            value.InAttribute                               = GetBool(new IntPtr(p + 0x018)); // 0x18 InAttribute                 ( ModelPrimitiveType bool bool bool Bool )
            value.AttrValue                                 = GetObject<StringBuilder>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x20 AttrValue                   ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.CacheAttrValue                            = GetBool(new IntPtr(p + 0x028)); // 0x28 CacheAttrValue              ( ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x030)); // 0x30 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )

            return value;
        }
    }
}
