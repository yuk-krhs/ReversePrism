using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BaseContract                             ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer
    // 068 Members                                  ModelClassListType List`1<DataMember> List`1<DataMember> List<DataMember> Pointer
    // 070 OnSerializing                            ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 OnSerialized                             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 OnDeserializing                          ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 088 OnDeserialized                           ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 090 ExtensionDataSetMethod                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 098 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 0A0 SerializationExceptionMessage            ModelPrimitiveType string string string String
    // 0A8 IsISerializable                          ModelPrimitiveType bool bool bool Bool
    // 0A9 IsKnownTypeAttributeChecked              ModelPrimitiveType bool bool bool Bool
    // 0AA IsMethodChecked                          ModelPrimitiveType bool bool bool Bool
    // 0AB HasExtensionData                         ModelPrimitiveType bool bool bool Bool
    // 0AC IsNonAttributedType                      ModelPrimitiveType bool bool bool Bool
    // 0AD HasDataContract                          ModelPrimitiveType bool bool bool Bool
    // 0B0 ChildElementNamespaces                   ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 0B8 XmlFormatReaderDelegate                  ModelClassType XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate Pointer
    // 0C0 XmlFormatWriterDelegate                  ModelClassType XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate Pointer
    // 0C8 ContractNamespaces                       ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 0D0 MemberNames                              ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 0D8 MemberNamespaces                         ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 000 serInfoCtorArgs                          Type[] IL2CPP_TYPE_SZARRAY
    public partial class ClassDataContractCriticalHelper : DataModel
    {
        public ClassDataContract?                       BaseContract                            { get; set; }
        public List<DataMember>?                        Members                                 { get; set; }
        public MethodInfo?                              OnSerializing                           { get; set; }
        public MethodInfo?                              OnSerialized                            { get; set; }
        public MethodInfo?                              OnDeserializing                         { get; set; }
        public MethodInfo?                              OnDeserialized                          { get; set; }
        public MethodInfo?                              ExtensionDataSetMethod                  { get; set; }
        public string                                   SerializationExceptionMessage           { get; set; }
        public bool                                     IsISerializable                         { get; set; }
        public bool                                     IsKnownTypeAttributeChecked             { get; set; }
        public bool                                     IsMethodChecked                         { get; set; }
        public bool                                     HasExtensionData                        { get; set; }
        public bool                                     IsNonAttributedType                     { get; set; }
        public bool                                     HasDataContract                         { get; set; }
        public List<XmlDictionaryString>?               ChildElementNamespaces                  { get; set; }
        public XmlFormatClassReaderDelegate?            XmlFormatReaderDelegate                 { get; set; }
        public XmlFormatClassWriterDelegate?            XmlFormatWriterDelegate                 { get; set; }
        public List<XmlDictionaryString>?               ContractNamespaces                      { get; set; }
        public List<XmlDictionaryString>?               MemberNames                             { get; set; }
        public List<XmlDictionaryString>?               MemberNamespaces                        { get; set; }

        public static ClassDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClassDataContractCriticalHelper() { Pointer= p0 };

            value.BaseContract                              = GetObject<ClassDataContract>(new IntPtr(p + 0x060), ReversePrism.DataModels.ClassDataContract.FromPointer); // 0x60 BaseContract                ( ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer )
            value.Members                                   = GetObjectList<DataMember>(new IntPtr(p + 0x068), ReversePrism.DataModels.DataMember.FromPointer); // 0x68 Members                     ( ModelClassListType List`1<DataMember> List`1<DataMember> List<DataMember> Pointer )
            value.OnSerializing                             = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x70 OnSerializing               ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnSerialized                              = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x78 OnSerialized                ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnDeserializing                           = GetObject<MethodInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x80 OnDeserializing             ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnDeserialized                            = GetObject<MethodInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x88 OnDeserialized              ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ExtensionDataSetMethod                    = GetObject<MethodInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x90 ExtensionDataSetMethod      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SerializationExceptionMessage             = GetString(new IntPtr(p + 0x0A0)); // 0xA0 SerializationExceptionMessage ( ModelPrimitiveType string string string String )
            value.IsISerializable                           = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 IsISerializable             ( ModelPrimitiveType bool bool bool Bool )
            value.IsKnownTypeAttributeChecked               = GetBool(new IntPtr(p + 0x0A9)); // 0xA9 IsKnownTypeAttributeChecked ( ModelPrimitiveType bool bool bool Bool )
            value.IsMethodChecked                           = GetBool(new IntPtr(p + 0x0AA)); // 0xAA IsMethodChecked             ( ModelPrimitiveType bool bool bool Bool )
            value.HasExtensionData                          = GetBool(new IntPtr(p + 0x0AB)); // 0xAB HasExtensionData            ( ModelPrimitiveType bool bool bool Bool )
            value.IsNonAttributedType                       = GetBool(new IntPtr(p + 0x0AC)); // 0xAC IsNonAttributedType         ( ModelPrimitiveType bool bool bool Bool )
            value.HasDataContract                           = GetBool(new IntPtr(p + 0x0AD)); // 0xAD HasDataContract             ( ModelPrimitiveType bool bool bool Bool )
            value.ChildElementNamespaces                    = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0xB0 ChildElementNamespaces      ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.XmlFormatReaderDelegate                   = GetObject<XmlFormatClassReaderDelegate>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlFormatClassReaderDelegate.FromPointer); // 0xB8 XmlFormatReaderDelegate     ( ModelClassType XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate Pointer )
            value.XmlFormatWriterDelegate                   = GetObject<XmlFormatClassWriterDelegate>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlFormatClassWriterDelegate.FromPointer); // 0xC0 XmlFormatWriterDelegate     ( ModelClassType XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate Pointer )
            value.ContractNamespaces                        = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0xC8 ContractNamespaces          ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0xD0 MemberNames                 ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNamespaces                          = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0xD8 MemberNamespaces            ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )

            return value;
        }
    }
}
