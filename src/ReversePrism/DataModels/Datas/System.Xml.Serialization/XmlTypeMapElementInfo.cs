using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              ModelPrimitiveType string string string String
    // 018 Namespace                                ModelPrimitiveType string string string String
    // 020 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 028 Member                                   ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer
    // 030 _choiceValue                             <object> IL2CPP_TYPE_OBJECT
    // 038 IsNullable                               ModelPrimitiveType bool bool bool Bool
    // 03C NestingLevel                             ModelPrimitiveType int int int Int32
    // 040 MappedType                               ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    // 048 Type                                     ModelClassType TypeData TypeData TypeData Pointer
    // 050 WrappedElement                           ModelPrimitiveType bool bool bool Bool
    // 054 ExplicitOrder                            ModelPrimitiveType int int int Int32
    public partial class XmlTypeMapElementInfo : DataModel
    {
        public string                                   ElementName                             { get; set; }
        public string                                   Namespace                               { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public XmlTypeMapMember?                        Member                                  { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public int                                      NestingLevel                            { get; set; }
        public XmlTypeMapping?                          MappedType                              { get; set; }
        public TypeData?                                Type                                    { get; set; }
        public bool                                     WrappedElement                          { get; set; }
        public int                                      ExplicitOrder                           { get; set; }

        public static XmlTypeMapElementInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapElementInfo() { Pointer= p0 };

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 0x10 ElementName                 ( ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Namespace                   ( ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x020)); // 0x20 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Member                                    = GetObject<XmlTypeMapMember>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlTypeMapMember.FromPointer); // 0x28 Member                      ( ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsNullable                  ( ModelPrimitiveType bool bool bool Bool )
            value.NestingLevel                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C NestingLevel                ( ModelPrimitiveType int int int Int32 )
            value.MappedType                                = GetObject<XmlTypeMapping>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0x40 MappedType                  ( ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )
            value.Type                                      = GetObject<TypeData>(new IntPtr(p + 0x048), ReversePrism.DataModels.TypeData.FromPointer); // 0x48 Type                        ( ModelClassType TypeData TypeData TypeData Pointer )
            value.WrappedElement                            = GetBool(new IntPtr(p + 0x050)); // 0x50 WrappedElement              ( ModelPrimitiveType bool bool bool Bool )
            value.ExplicitOrder                             = GetInt32(new IntPtr(p + 0x054)); // 0x54 ExplicitOrder               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
