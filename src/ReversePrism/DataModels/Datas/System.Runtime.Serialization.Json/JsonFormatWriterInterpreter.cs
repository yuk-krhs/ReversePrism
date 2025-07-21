using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClassContract                            ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer
    // 018 CollectionContract                       ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer
    // 020 Writer                                   ModelClassType XmlWriterDelegator XmlWriterDelegator XmlWriterDelegator Pointer
    // 028 obj                                      <object> IL2CPP_TYPE_OBJECT
    // 030 Context                                  ModelClassType XmlObjectSerializerWriteContextComplexJson XmlObjectSerializerWriteContextComplexJson XmlObjectSerializerWriteContextComplexJson Pointer
    // 038 DataContract                             ModelClassType DataContract DataContract DataContract Pointer
    // 040 objLocal                                 <object> IL2CPP_TYPE_OBJECT
    // 048 MemberNames                              ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 050 TypeIndex                                ModelPrimitiveType int int int Int32
    // 054 ChildElementIndex                        ModelPrimitiveType int int int Int32
    public partial class JsonFormatWriterInterpreter : DataModel
    {
        public ClassDataContract?                       ClassContract                           { get; set; }
        public CollectionDataContract?                  CollectionContract                      { get; set; }
        public XmlWriterDelegator?                      Writer                                  { get; set; }
        public XmlObjectSerializerWriteContextComplexJson? Context                                 { get; set; }
        public DataContract?                            DataContract                            { get; set; }
        public List<XmlDictionaryString>?               MemberNames                             { get; set; }
        public int                                      TypeIndex                               { get; set; }
        public int                                      ChildElementIndex                       { get; set; }

        public static JsonFormatWriterInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatWriterInterpreter() { Pointer= p0 };

            value.ClassContract                             = GetObject<ClassDataContract>(new IntPtr(p + 0x010), ReversePrism.DataModels.ClassDataContract.FromPointer); // 0x10 ClassContract               ( ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer )
            value.CollectionContract                        = GetObject<CollectionDataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.CollectionDataContract.FromPointer); // 0x18 CollectionContract          ( ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer )
            value.Writer                                    = GetObject<XmlWriterDelegator>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlWriterDelegator.FromPointer); // 0x20 Writer                      ( ModelClassType XmlWriterDelegator XmlWriterDelegator XmlWriterDelegator Pointer )
            value.Context                                   = GetObject<XmlObjectSerializerWriteContextComplexJson>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlObjectSerializerWriteContextComplexJson.FromPointer); // 0x30 Context                     ( ModelClassType XmlObjectSerializerWriteContextComplexJson XmlObjectSerializerWriteContextComplexJson XmlObjectSerializerWriteContextComplexJson Pointer )
            value.DataContract                              = GetObject<DataContract>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataContract.FromPointer); // 0x38 DataContract                ( ModelClassType DataContract DataContract DataContract Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x48 MemberNames                 ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.TypeIndex                                 = GetInt32(new IntPtr(p + 0x050)); // 0x50 TypeIndex                   ( ModelPrimitiveType int int int Int32 )
            value.ChildElementIndex                         = GetInt32(new IntPtr(p + 0x054)); // 0x54 ChildElementIndex           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
