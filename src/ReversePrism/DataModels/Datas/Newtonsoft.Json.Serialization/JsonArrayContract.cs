using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 CollectionItemType                       ModelClassType Type Type Type Pointer
    // 0C8 IsMultidimensionalArray                  ModelPrimitiveType bool bool bool Bool
    // 0D0 GenericCollectionDefinitionType          ModelClassType Type Type Type Pointer
    // 0D8 GenericWrapperType                       ModelClassType Type Type Type Pointer
    // 0E0 _genericWrapperCreator                   ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0E8 _genericTemporaryCollectionCreator       Func`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0F0 IsArray                                  ModelPrimitiveType bool bool bool Bool
    // 0F1 ShouldCreateWrapper                      ModelPrimitiveType bool bool bool Bool
    // 0F2 CanDeserialize                           ModelPrimitiveType bool bool bool Bool
    // 0F8 ParameterizedConstructor                 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 100 _parameterizedCreator                    ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 108 _overrideCreator                         ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 110 HasParameterizedCreator                  ModelPrimitiveType bool bool bool Bool
    public partial class JsonArrayContract : DataModel
    {
        public Type?                                    CollectionItemType                      { get; set; }
        public bool                                     IsMultidimensionalArray                 { get; set; }
        public Type?                                    GenericCollectionDefinitionType         { get; set; }
        public Type?                                    GenericWrapperType                      { get; set; }
        public bool                                     IsArray                                 { get; set; }
        public bool                                     ShouldCreateWrapper                     { get; set; }
        public bool                                     CanDeserialize                          { get; set; }
        public ConstructorInfo?                         ParameterizedConstructor                { get; set; }
        public bool                                     HasParameterizedCreator                 { get; set; }

        public static JsonArrayContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonArrayContract() { Pointer= p0 };

            value.CollectionItemType                        = GetObject<Type>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Type.FromPointer); // 0xC0 CollectionItemType          ( ModelClassType Type Type Type Pointer )
            value.IsMultidimensionalArray                   = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 IsMultidimensionalArray     ( ModelPrimitiveType bool bool bool Bool )
            value.GenericCollectionDefinitionType           = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 0xD0 GenericCollectionDefinitionType ( ModelClassType Type Type Type Pointer )
            value.GenericWrapperType                        = GetObject<Type>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Type.FromPointer); // 0xD8 GenericWrapperType          ( ModelClassType Type Type Type Pointer )
            value.IsArray                                   = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsArray                     ( ModelPrimitiveType bool bool bool Bool )
            value.ShouldCreateWrapper                       = GetBool(new IntPtr(p + 0x0F1)); // 0xF1 ShouldCreateWrapper         ( ModelPrimitiveType bool bool bool Bool )
            value.CanDeserialize                            = GetBool(new IntPtr(p + 0x0F2)); // 0xF2 CanDeserialize              ( ModelPrimitiveType bool bool bool Bool )
            value.ParameterizedConstructor                  = GetObject<ConstructorInfo>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0xF8 ParameterizedConstructor    ( ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.HasParameterizedCreator                   = GetBool(new IntPtr(p + 0x110)); // 0x110 HasParameterizedCreator     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
