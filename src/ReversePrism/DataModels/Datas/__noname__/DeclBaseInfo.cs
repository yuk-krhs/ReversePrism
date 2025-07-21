using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Prefix                                   ModelPrimitiveType string string string String
    // 020 TypeName                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 028 TypePrefix                               ModelPrimitiveType string string string String
    // 030 _Default                                 <object> IL2CPP_TYPE_OBJECT
    // 038 _Revises                                 <object> IL2CPP_TYPE_OBJECT
    // 040 MaxOccurs                                ModelPrimitiveType uint uint uint UInt32
    // 044 MinOccurs                                ModelPrimitiveType uint uint uint UInt32
    // 048 Checking                                 ModelPrimitiveType bool bool bool Bool
    // 050 ElementDecl                              ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 058 Attdef                                   ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    // 060 Next                                     ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer
    public partial class DeclBaseInfo : DataModel
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
            var value   = new DeclBaseInfo() { Pointer= p0 };

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 Name                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Prefix                      ( ModelPrimitiveType string string string String )
            value.TypeName                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x20 TypeName                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TypePrefix                                = GetString(new IntPtr(p + 0x028)); // 0x28 TypePrefix                  ( ModelPrimitiveType string string string String )
            value.MaxOccurs                                 = GetUInt32(new IntPtr(p + 0x040)); // 0x40 MaxOccurs                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.MinOccurs                                 = GetUInt32(new IntPtr(p + 0x044)); // 0x44 MinOccurs                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.Checking                                  = GetBool(new IntPtr(p + 0x048)); // 0x48 Checking                    ( ModelPrimitiveType bool bool bool Bool )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x050), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0x50 ElementDecl                 ( ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.Attdef                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x058), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0x58 Attdef                      ( ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )
            value.Next                                      = GetObject<DeclBaseInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.DeclBaseInfo.FromPointer); // 0x60 Next                        ( ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer )

            return value;
        }
    }
}
