using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Prefix                                   000186671BA0 ModelPrimitiveType string string string String
    // 020 TypeName                                 0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 TypePrefix                               000186671BA0 ModelPrimitiveType string string string String
    // 030 _Default                                 <object> IL2CPP_TYPE_OBJECT
    // 038 _Revises                                 <object> IL2CPP_TYPE_OBJECT
    // 040 MaxOccurs                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 044 MinOccurs                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 048 Checking                                 000186595210 ModelPrimitiveType bool bool bool Bool
    // 050 ElementDecl                              0001866E8630 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 058 Attdef                                   0001866E7090 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    // 060 Next                                     000186725C20 ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer
    public partial class DeclBaseInfo
    {
        public XmlQualifiedName?                        Name                                    { get; set; }
        public string                                   Prefix                                  { get; set; }
        public XmlQualifiedName?                        TypeName                                { get; set; }
        public string                                   TypePrefix                              { get; set; }
        public uint                                     MaxOccurs                               { get; set; }
        public uint                                     MinOccurs                               { get; set; }
        public bool                                     Checking                                { get; set; }
        public SchemaElementDecl?                       ElementDecl                             { get; set; }
        public SchemaAttDef?                            Attdef                                  { get; set; }
        public DeclBaseInfo?                            Next                                    { get; set; }

        public static DeclBaseInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeclBaseInfo();

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7582BD8 0x10 Name                        ( 0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0270D7582BF8 0x18 Prefix                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TypeName                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7582C18 0x20 TypeName                    ( 0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TypePrefix                                = GetString(new IntPtr(p + 0x028)); // 0270D7582C38 0x28 TypePrefix                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.MaxOccurs                                 = GetUInt32(new IntPtr(p + 0x040)); // 0270D7582C98 0x40 MaxOccurs                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MinOccurs                                 = GetUInt32(new IntPtr(p + 0x044)); // 0270D7582CB8 0x44 MinOccurs                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Checking                                  = GetBool(new IntPtr(p + 0x048)); // 0270D7582CD8 0x48 Checking                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x050), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0270D7582CF8 0x50 ElementDecl                 ( 0001866E8630 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.Attdef                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x058), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0270D7582D18 0x58 Attdef                      ( 0001866E7090 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )
            value.Next                                      = GetObject<DeclBaseInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.DeclBaseInfo.FromPointer); // 0270D7582D38 0x60 Next                        ( 000186725C20 ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer )

            return value;
        }
    }
}
