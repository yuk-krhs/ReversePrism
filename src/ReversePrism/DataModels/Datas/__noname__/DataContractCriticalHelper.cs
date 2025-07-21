using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 typeToIDCache                            Dictionary`2<TypeHandleRef, IntRef> IL2CPP_TYPE_GENERICINST
    // 008 dataContractCache                        DataContract[] IL2CPP_TYPE_SZARRAY
    // 010 DataContractID                           ModelPrimitiveType int int int Int32
    // 018 typeToBuiltInContract                    Dictionary`2<Type, DataContract> IL2CPP_TYPE_GENERICINST
    // 020 nameToBuiltInContract                    Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 028 typeNameToBuiltInContract                Dictionary`2<string, DataContract> IL2CPP_TYPE_GENERICINST
    // 030 namespaces                               Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 038 clrTypeStrings                           Dictionary`2<string, XmlDictionaryString> IL2CPP_TYPE_GENERICINST
    // 040 ClrTypeStringsDictionary                 ModelClassType XmlDictionary XmlDictionary XmlDictionary Pointer
    // 048 TypeHandleRef                            ModelClassType TypeHandleRef TypeHandleRef TypeHandleRef Pointer
    // 050 cacheLock                                <object> IL2CPP_TYPE_OBJECT
    // 058 createDataContractLock                   <object> IL2CPP_TYPE_OBJECT
    // 060 initBuiltInContractsLock                 <object> IL2CPP_TYPE_OBJECT
    // 068 namespacesLock                           <object> IL2CPP_TYPE_OBJECT
    // 070 clrTypeStringsLock                       <object> IL2CPP_TYPE_OBJECT
    // 010 UnderlyingType                           ModelClassType Type Type Type Pointer
    // 018 OriginalUnderlyingType                   ModelClassType Type Type Type Pointer
    // 020 IsReference                              ModelPrimitiveType bool bool bool Bool
    // 021 IsValueType                              ModelPrimitiveType bool bool bool Bool
    // 028 StableName                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 030 GenericInfo                              ModelClassType GenericInfo GenericInfo GenericInfo Pointer
    // 038 Name                                     ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 040 Ns                                       ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 048 TypeForInitialization                    ModelClassType Type Type Type Pointer
    // 050 ParseMethod                              ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 ParseMethodSet                           ModelPrimitiveType bool bool bool Bool
    public partial class DataContractCriticalHelper : DataModel
    {
        public int                                      DataContractID                          { get; set; }
        public XmlDictionary?                           ClrTypeStringsDictionary                { get; set; }
        public TypeHandleRef?                           TypeHandleRef                           { get; set; }
        public Type?                                    UnderlyingType                          { get; set; }
        public Type?                                    OriginalUnderlyingType                  { get; set; }
        public bool                                     IsReference                             { get; set; }
        public bool                                     IsValueType                             { get; set; }
        public XmlQualifiedName?                        StableName                              { get; set; }
        public GenericInfo?                             GenericInfo                             { get; set; }
        public XmlDictionaryString?                     Name                                    { get; set; }
        public XmlDictionaryString?                     Ns                                      { get; set; }
        public Type?                                    TypeForInitialization                   { get; set; }
        public MethodInfo?                              ParseMethod                             { get; set; }
        public bool                                     ParseMethodSet                          { get; set; }

        public static DataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractCriticalHelper() { Pointer= p0 };

            value.DataContractID                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 DataContractID              ( ModelPrimitiveType int int int Int32 )
            value.ClrTypeStringsDictionary                  = GetObject<XmlDictionary>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlDictionary.FromPointer); // 0x40 ClrTypeStringsDictionary    ( ModelClassType XmlDictionary XmlDictionary XmlDictionary Pointer )
            value.TypeHandleRef                             = GetObject<TypeHandleRef>(new IntPtr(p + 0x048), ReversePrism.DataModels.TypeHandleRef.FromPointer); // 0x48 TypeHandleRef               ( ModelClassType TypeHandleRef TypeHandleRef TypeHandleRef Pointer )
            value.UnderlyingType                            = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 UnderlyingType              ( ModelClassType Type Type Type Pointer )
            value.OriginalUnderlyingType                    = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 OriginalUnderlyingType      ( ModelClassType Type Type Type Pointer )
            value.IsReference                               = GetBool(new IntPtr(p + 0x020)); // 0x20 IsReference                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsValueType                               = GetBool(new IntPtr(p + 0x021)); // 0x21 IsValueType                 ( ModelPrimitiveType bool bool bool Bool )
            value.StableName                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x28 StableName                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.GenericInfo                               = GetObject<GenericInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.GenericInfo.FromPointer); // 0x30 GenericInfo                 ( ModelClassType GenericInfo GenericInfo GenericInfo Pointer )
            value.Name                                      = GetObject<XmlDictionaryString>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x38 Name                        ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.Ns                                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x40 Ns                          ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.TypeForInitialization                     = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 0x48 TypeForInitialization       ( ModelClassType Type Type Type Pointer )
            value.ParseMethod                               = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x50 ParseMethod                 ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ParseMethodSet                            = GetBool(new IntPtr(p + 0x058)); // 0x58 ParseMethodSet              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
