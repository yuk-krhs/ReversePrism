using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BaseContract                             0001865AFE30 ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer
    // 068 Members                                  000185CD5F58 ModelClassListType List`1<DataMember> List`1<DataMember> List<DataMember> Pointer
    // 070 OnSerializing                            000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 078 OnSerialized                             000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 080 OnDeserializing                          000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 088 OnDeserialized                           000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 090 ExtensionDataSetMethod                   000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 098 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 0A0 SerializationExceptionMessage            000186671910 ModelPrimitiveType string string string String
    // 0A8 IsISerializable                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A9 IsKnownTypeAttributeChecked              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AA IsMethodChecked                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AB HasExtensionData                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AC IsNonAttributedType                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AD HasDataContract                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 ChildElementNamespaces                   000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 0B8 XmlFormatReaderDelegate                  00018659AFE0 ModelClassType XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate Pointer
    // 0C0 XmlFormatWriterDelegate                  00018659B4A0 ModelClassType XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate Pointer
    // 0C8 ContractNamespaces                       000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 0D0 MemberNames                              000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 0D8 MemberNamespaces                         000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
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

            value.BaseContract                              = GetObject<ClassDataContract>(new IntPtr(p + 0x060), ReversePrism.DataModels.ClassDataContract.FromPointer); // 0245A4CD75C8 0x60 BaseContract                ( 0001865AFE30 ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer )
            value.Members                                   = GetObjectList<DataMember>(new IntPtr(p + 0x068), ReversePrism.DataModels.DataMember.FromPointer); // 0245A4CD75E8 0x68 Members                     ( 000185CD5F58 ModelClassListType List`1<DataMember> List`1<DataMember> List<DataMember> Pointer )
            value.OnSerializing                             = GetObject<MethodInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A4CD7608 0x70 OnSerializing               ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnSerialized                              = GetObject<MethodInfo>(new IntPtr(p + 0x078), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A4CD7628 0x78 OnSerialized                ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnDeserializing                           = GetObject<MethodInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A4CD7648 0x80 OnDeserializing             ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.OnDeserialized                            = GetObject<MethodInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A4CD7668 0x88 OnDeserialized              ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ExtensionDataSetMethod                    = GetObject<MethodInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A4CD7688 0x90 ExtensionDataSetMethod      ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SerializationExceptionMessage             = GetString(new IntPtr(p + 0x0A0)); // 0245A4CD76C8 0xA0 SerializationExceptionMessage ( 000186671910 ModelPrimitiveType string string string String )
            value.IsISerializable                           = GetBool(new IntPtr(p + 0x0A8)); // 0245A4CD76E8 0xA8 IsISerializable             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsKnownTypeAttributeChecked               = GetBool(new IntPtr(p + 0x0A9)); // 0245A4CD7708 0xA9 IsKnownTypeAttributeChecked ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsMethodChecked                           = GetBool(new IntPtr(p + 0x0AA)); // 0245A4CD7728 0xAA IsMethodChecked             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasExtensionData                          = GetBool(new IntPtr(p + 0x0AB)); // 0245A4CD7748 0xAB HasExtensionData            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNonAttributedType                       = GetBool(new IntPtr(p + 0x0AC)); // 0245A4CD7768 0xAC IsNonAttributedType         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasDataContract                           = GetBool(new IntPtr(p + 0x0AD)); // 0245A4CD7788 0xAD HasDataContract             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ChildElementNamespaces                    = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CD77A8 0xB0 ChildElementNamespaces      ( 000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.XmlFormatReaderDelegate                   = GetObject<XmlFormatClassReaderDelegate>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlFormatClassReaderDelegate.FromPointer); // 0245A4CD77C8 0xB8 XmlFormatReaderDelegate     ( 00018659AFE0 ModelClassType XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate XmlFormatClassReaderDelegate Pointer )
            value.XmlFormatWriterDelegate                   = GetObject<XmlFormatClassWriterDelegate>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlFormatClassWriterDelegate.FromPointer); // 0245A4CD77E8 0xC0 XmlFormatWriterDelegate     ( 00018659B4A0 ModelClassType XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate XmlFormatClassWriterDelegate Pointer )
            value.ContractNamespaces                        = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CD7808 0xC8 ContractNamespaces          ( 000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CD7828 0xD0 MemberNames                 ( 000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNamespaces                          = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CD7848 0xD8 MemberNamespaces            ( 000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )

            return value;
        }
    }
}
