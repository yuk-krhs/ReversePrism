using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 <DictionaryKeyResolver>k__BackingField   Func`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0C8 DictionaryKeyType                        ModelClassType Type Type Type Pointer
    // 0D0 DictionaryValueType                      ModelClassType Type Type Type Pointer
    // 0D8 KeyContract                              ModelClassType JsonContract JsonContract JsonContract Pointer
    // 0E0 GenericCollectionDefinitionType          ModelClassType Type Type Type Pointer
    // 0E8 GenericWrapperType                       ModelClassType Type Type Type Pointer
    // 0F0 _genericWrapperCreator                   ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0F8 _genericTemporaryDictionaryCreator       Func`1<<object>> IL2CPP_TYPE_GENERICINST
    // 100 ShouldCreateWrapper                      ModelPrimitiveType bool bool bool Bool
    // 108 ParameterizedConstructor                 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 110 _overrideCreator                         ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 118 _parameterizedCreator                    ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 120 HasParameterizedCreator                  ModelPrimitiveType bool bool bool Bool
    public partial class JsonDictionaryContract : DataModel
    {
        public Type?                                    DictionaryKeyType                       { get; set; }
        public Type?                                    DictionaryValueType                     { get; set; }
        public JsonContract?                            KeyContract                             { get; set; }
        public Type?                                    GenericCollectionDefinitionType         { get; set; }
        public Type?                                    GenericWrapperType                      { get; set; }
        public bool                                     ShouldCreateWrapper                     { get; set; }
        public ConstructorInfo?                         ParameterizedConstructor                { get; set; }
        public bool                                     HasParameterizedCreator                 { get; set; }

        public static JsonDictionaryContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonDictionaryContract() { Pointer= p0 };

            value.DictionaryKeyType                         = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 0xC8 DictionaryKeyType           ( ModelClassType Type Type Type Pointer )
            value.DictionaryValueType                       = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 0xD0 DictionaryValueType         ( ModelClassType Type Type Type Pointer )
            value.KeyContract                               = GetObject<JsonContract>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.JsonContract.FromPointer); // 0xD8 KeyContract                 ( ModelClassType JsonContract JsonContract JsonContract Pointer )
            value.GenericCollectionDefinitionType           = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0xE0 GenericCollectionDefinitionType ( ModelClassType Type Type Type Pointer )
            value.GenericWrapperType                        = GetObject<Type>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Type.FromPointer); // 0xE8 GenericWrapperType          ( ModelClassType Type Type Type Pointer )
            value.ShouldCreateWrapper                       = GetBool(new IntPtr(p + 0x100)); // 0x100 ShouldCreateWrapper         ( ModelPrimitiveType bool bool bool Bool )
            value.ParameterizedConstructor                  = GetObject<ConstructorInfo>(new IntPtr(p + 0x108), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0x108 ParameterizedConstructor    ( ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.HasParameterizedCreator                   = GetBool(new IntPtr(p + 0x120)); // 0x120 HasParameterizedCreator     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
