using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 018 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 020 SType                                    0001866EBE30 ModelEnumType SchemaTypes SchemaTypes SchemaTypes Int32
    // 028 ListItemType                             000186692850 ModelClassType Type Type Type Pointer
    // 030 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 038 FullTypeName                             000186671910 ModelPrimitiveType string string string String
    // 040 ListItemTypeData                         0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer
    // 048 MappedType                               0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer
    // 050 Facet                                    0001865BDA60 ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer
    // 058 TypeConvertor                            000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 HasPublicConstructor                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 NullableOverride                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 keywords                                 string[] IL2CPP_TYPE_SZARRAY
    public partial class TypeData
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
            var value   = new TypeData();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D74B4248 0x10 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.ElementName                               = GetString(new IntPtr(p + 0x018)); // 0270D74B4268 0x18 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.SType                                     = (SchemaTypes)GetInt32(new IntPtr(p + 0x020)); // 0270D74B4288 0x20 SType                       ( 0001866EBE30 ModelEnumType SchemaTypes SchemaTypes SchemaTypes Int32 )
            value.ListItemType                              = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0270D74B42A8 0x28 ListItemType                ( 000186692850 ModelClassType Type Type Type Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x030)); // 0270D74B42C8 0x30 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.FullTypeName                              = GetString(new IntPtr(p + 0x038)); // 0270D74B42E8 0x38 FullTypeName                ( 000186671910 ModelPrimitiveType string string string String )
            value.ListItemTypeData                          = GetObject<TypeData>(new IntPtr(p + 0x040), ReversePrism.DataModels.TypeData.FromPointer); // 0270D74B4308 0x40 ListItemTypeData            ( 0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer )
            value.MappedType                                = GetObject<TypeData>(new IntPtr(p + 0x048), ReversePrism.DataModels.TypeData.FromPointer); // 0270D74B4328 0x48 MappedType                  ( 0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer )
            value.Facet                                     = GetObject<XmlSchemaPatternFacet>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaPatternFacet.FromPointer); // 0270D74B4348 0x50 Facet                       ( 0001865BDA60 ModelClassType XmlSchemaPatternFacet XmlSchemaPatternFacet XmlSchemaPatternFacet Pointer )
            value.TypeConvertor                             = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D74B4368 0x58 TypeConvertor               ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.HasPublicConstructor                      = GetBool(new IntPtr(p + 0x060)); // 0270D74B4388 0x60 HasPublicConstructor        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NullableOverride                          = GetBool(new IntPtr(p + 0x061)); // 0270D74B43A8 0x61 NullableOverride            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
