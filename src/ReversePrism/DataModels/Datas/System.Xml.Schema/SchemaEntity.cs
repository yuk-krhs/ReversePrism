using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Qname                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Url                                      000186671910 ModelPrimitiveType string string string String
    // 020 Pubid                                    000186671910 ModelPrimitiveType string string string String
    // 028 Text                                     000186671910 ModelPrimitiveType string string string String
    // 030 Ndata                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 038 LineNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C LinePosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 IsParameter                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsExternal                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 ParsingInProgress                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 043 IsDeclaredInExternal                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 BaseURI                                  000186671910 ModelPrimitiveType string string string String
    // 050 DeclaredURI                              000186671910 ModelPrimitiveType string string string String
    public partial class SchemaEntity : DataModel
    {
        public XmlQualifiedName?                        Qname                                   { get; set; }
        public string                                   Url                                     { get; set; }
        public string                                   Pubid                                   { get; set; }
        public string                                   Text                                    { get; set; }
        public XmlQualifiedName?                        Ndata                                   { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }
        public bool                                     IsParameter                             { get; set; }
        public bool                                     IsExternal                              { get; set; }
        public bool                                     ParsingInProgress                       { get; set; }
        public bool                                     IsDeclaredInExternal                    { get; set; }
        public string                                   BaseURI                                 { get; set; }
        public string                                   DeclaredURI                             { get; set; }

        public static SchemaEntity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaEntity() { Pointer= p0 };

            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246674DDD60 0x10 Qname                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0246674DDD80 0x18 Url                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Pubid                                     = GetString(new IntPtr(p + 0x020)); // 0246674DDDA0 0x20 Pubid                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x028)); // 0246674DDDC0 0x28 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Ndata                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246674DDDE0 0x30 Ndata                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x038)); // 0246674DDE00 0x38 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x03C)); // 0246674DDE20 0x3C LinePosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsParameter                               = GetBool(new IntPtr(p + 0x040)); // 0246674DDE40 0x40 IsParameter                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsExternal                                = GetBool(new IntPtr(p + 0x041)); // 0246674DDE60 0x41 IsExternal                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ParsingInProgress                         = GetBool(new IntPtr(p + 0x042)); // 0246674DDE80 0x42 ParsingInProgress           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDeclaredInExternal                      = GetBool(new IntPtr(p + 0x043)); // 0246674DDEA0 0x43 IsDeclaredInExternal        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x048)); // 0246674DDEC0 0x48 BaseURI                     ( 000186671910 ModelPrimitiveType string string string String )
            value.DeclaredURI                               = GetString(new IntPtr(p + 0x050)); // 0246674DDEE0 0x50 DeclaredURI                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
