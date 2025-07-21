using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 ElementName                              ModelPrimitiveType string string string String
    // 020 SType                                    ModelEnumType SchemaTypes SchemaTypes SchemaTypes Int32
    // 028 ListItemType                             ModelClassType Type Type Type Pointer
    // 030 TypeName                                 ModelPrimitiveType string string string String
    // 038 FullTypeName                             ModelPrimitiveType string string string String
    // 040 ListItemTypeData                         ModelClassType TypeData TypeData TypeData Pointer
    // 048 MappedType                               ModelClassType TypeData TypeData TypeData Pointer
    // 050 Facet                                    ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer
    // 058 TypeConvertor                            ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 HasPublicConstructor                     ModelPrimitiveType bool bool bool Bool
    // 061 NullableOverride                         ModelPrimitiveType bool bool bool Bool
    // 000 keywords                                 string[] IL2CPP_TYPE_SZARRAY
    public partial class TypeData : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public string                                   ElementName                             { get; set; }
        public SchemaTypes                              SType                                   { get; set; }
        public Type?                                    ListItemType                            { get; set; }
        public string                                   TypeName                                { get; set; }
        public string                                   FullTypeName                            { get; set; }
        public TypeData?                                ListItemTypeData                        { get; set; }
        public TypeData?                                MappedType                              { get; set; }
        public XmlSchemaPatternFacet?                   Facet                                   { get; set; }
        public MethodInfo?                              TypeConvertor                           { get; set; }
        public bool                                     HasPublicConstructor                    { get; set; }
        public bool                                     NullableOverride                        { get; set; }

        public static TypeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeData() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.ElementName                               = GetString(new IntPtr(p + 0x018)); // 0x18 ElementName                 ( ModelPrimitiveType string string string String )
            value.SType                                     = (SchemaTypes)GetInt32(new IntPtr(p + 0x020)); // 0x20 SType                       ( ModelEnumType SchemaTypes SchemaTypes SchemaTypes Int32 )
            value.ListItemType                              = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 ListItemType                ( ModelClassType Type Type Type Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x030)); // 0x30 TypeName                    ( ModelPrimitiveType string string string String )
            value.FullTypeName                              = GetString(new IntPtr(p + 0x038)); // 0x38 FullTypeName                ( ModelPrimitiveType string string string String )
            value.ListItemTypeData                          = GetObject<TypeData>(new IntPtr(p + 0x040), ReversePrism.DataModels.TypeData.FromPointer); // 0x40 ListItemTypeData            ( ModelClassType TypeData TypeData TypeData Pointer )
            value.MappedType                                = GetObject<TypeData>(new IntPtr(p + 0x048), ReversePrism.DataModels.TypeData.FromPointer); // 0x48 MappedType                  ( ModelClassType TypeData TypeData TypeData Pointer )
            value.Facet                                     = GetObject<XmlSchemaPatternFacet>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaPatternFacet.FromPointer); // 0x50 Facet                       ( ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer )
            value.TypeConvertor                             = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x58 TypeConvertor               ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.HasPublicConstructor                      = GetBool(new IntPtr(p + 0x060)); // 0x60 HasPublicConstructor        ( ModelPrimitiveType bool bool bool Bool )
            value.NullableOverride                          = GetBool(new IntPtr(p + 0x061)); // 0x61 NullableOverride            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
