using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Qname                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Url                                      ModelPrimitiveType string string string String
    // 020 Pubid                                    ModelPrimitiveType string string string String
    // 028 Text                                     ModelPrimitiveType string string string String
    // 030 Ndata                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 038 LineNumber                               ModelPrimitiveType int int int Int32
    // 03C LinePosition                             ModelPrimitiveType int int int Int32
    // 040 IsParameter                              ModelPrimitiveType bool bool bool Bool
    // 041 IsExternal                               ModelPrimitiveType bool bool bool Bool
    // 042 ParsingInProgress                        ModelPrimitiveType bool bool bool Bool
    // 043 IsDeclaredInExternal                     ModelPrimitiveType bool bool bool Bool
    // 048 BaseURI                                  ModelPrimitiveType string string string String
    // 050 DeclaredURI                              ModelPrimitiveType string string string String
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

            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 Qname                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Url                         ( ModelPrimitiveType string string string String )
            value.Pubid                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Pubid                       ( ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Text                        ( ModelPrimitiveType string string string String )
            value.Ndata                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x30 Ndata                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 LineNumber                  ( ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C LinePosition                ( ModelPrimitiveType int int int Int32 )
            value.IsParameter                               = GetBool(new IntPtr(p + 0x040)); // 0x40 IsParameter                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsExternal                                = GetBool(new IntPtr(p + 0x041)); // 0x41 IsExternal                  ( ModelPrimitiveType bool bool bool Bool )
            value.ParsingInProgress                         = GetBool(new IntPtr(p + 0x042)); // 0x42 ParsingInProgress           ( ModelPrimitiveType bool bool bool Bool )
            value.IsDeclaredInExternal                      = GetBool(new IntPtr(p + 0x043)); // 0x43 IsDeclaredInExternal        ( ModelPrimitiveType bool bool bool Bool )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x048)); // 0x48 BaseURI                     ( ModelPrimitiveType string string string String )
            value.DeclaredURI                               = GetString(new IntPtr(p + 0x050)); // 0x50 DeclaredURI                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
