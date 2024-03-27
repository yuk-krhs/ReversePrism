using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 <DictionaryKeyResolver>k__BackingField   Func`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0C8 DictionaryKeyType                        0001866936B0 ModelClassType Type Type Type Pointer
    // 0D0 DictionaryValueType                      0001866936B0 ModelClassType Type Type Type Pointer
    // 0D8 KeyContract                              000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer
    // 0E0 GenericCollectionDefinitionType          0001866936B0 ModelClassType Type Type Type Pointer
    // 0E8 GenericWrapperType                       000186692850 ModelClassType Type Type Type Pointer
    // 0F0 _genericWrapperCreator                   ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 0F8 _genericTemporaryDictionaryCreator       Func`1<<object>> IL2CPP_TYPE_GENERICINST
    // 100 ShouldCreateWrapper                      0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 108 ParameterizedConstructor                 00018660FE70 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 110 _overrideCreator                         ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 118 _parameterizedCreator                    ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 120 HasParameterizedCreator                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonDictionaryContract
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
            var value   = new JsonDictionaryContract();

            value.DictionaryKeyType                         = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 0270060C5688 0xC8 DictionaryKeyType           ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.DictionaryValueType                       = GetObject<Type>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Type.FromPointer); // 0270060C56A8 0xD0 DictionaryValueType         ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.KeyContract                               = GetObject<JsonContract>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.JsonContract.FromPointer); // 0270060C56C8 0xD8 KeyContract                 ( 000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer )
            value.GenericCollectionDefinitionType           = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0270060C56E8 0xE0 GenericCollectionDefinitionType ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.GenericWrapperType                        = GetObject<Type>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Type.FromPointer); // 0270060C5708 0xE8 GenericWrapperType          ( 000186692850 ModelClassType Type Type Type Pointer )
            value.ShouldCreateWrapper                       = GetBool(new IntPtr(p + 0x100)); // 0270060C5768 0x100 ShouldCreateWrapper         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ParameterizedConstructor                  = GetObject<ConstructorInfo>(new IntPtr(p + 0x108), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0270060C5788 0x108 ParameterizedConstructor    ( 00018660FE70 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.HasParameterizedCreator                   = GetBool(new IntPtr(p + 0x120)); // 0270060C57E8 0x120 HasParameterizedCreator     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
