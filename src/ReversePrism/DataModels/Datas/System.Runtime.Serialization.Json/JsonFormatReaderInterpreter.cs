using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Is_get_only_collection                   ModelPrimitiveType bool bool bool Bool
    // 018 ClassContract                            ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer
    // 020 CollectionContract                       ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer
    // 028 objectLocal                              <object> IL2CPP_TYPE_OBJECT
    // 030 ObjectType                               ModelClassType Type Type Type Pointer
    // 038 XmlReader                                ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer
    // 040 Context                                  ModelClassType XmlObjectSerializerReadContextComplexJson XmlObjectSerializerReadContextComplexJson XmlObjectSerializerReadContextComplexJson Pointer
    // 048 MemberNames                              ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 050 EmptyDictionaryString                    ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 058 ItemName                                 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 060 ItemNamespace                            ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    public partial class JsonFormatReaderInterpreter : DataModel
    {
        public bool                                     Is_get_only_collection                  { get; set; }
        public ClassDataContract?                       ClassContract                           { get; set; }
        public CollectionDataContract?                  CollectionContract                      { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public XmlReaderDelegator?                      XmlReader                               { get; set; }
        public XmlObjectSerializerReadContextComplexJson? Context                                 { get; set; }
        public List<XmlDictionaryString>?               MemberNames                             { get; set; }
        public XmlDictionaryString?                     EmptyDictionaryString                   { get; set; }
        public XmlDictionaryString?                     ItemName                                { get; set; }
        public XmlDictionaryString?                     ItemNamespace                           { get; set; }

        public static JsonFormatReaderInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatReaderInterpreter() { Pointer= p0 };

            value.Is_get_only_collection                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Is_get_only_collection      ( ModelPrimitiveType bool bool bool Bool )
            value.ClassContract                             = GetObject<ClassDataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.ClassDataContract.FromPointer); // 0x18 ClassContract               ( ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer )
            value.CollectionContract                        = GetObject<CollectionDataContract>(new IntPtr(p + 0x020), ReversePrism.DataModels.CollectionDataContract.FromPointer); // 0x20 CollectionContract          ( ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0x30 ObjectType                  ( ModelClassType Type Type Type Pointer )
            value.XmlReader                                 = GetObject<XmlReaderDelegator>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlReaderDelegator.FromPointer); // 0x38 XmlReader                   ( ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer )
            value.Context                                   = GetObject<XmlObjectSerializerReadContextComplexJson>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlObjectSerializerReadContextComplexJson.FromPointer); // 0x40 Context                     ( ModelClassType XmlObjectSerializerReadContextComplexJson XmlObjectSerializerReadContextComplexJson XmlObjectSerializerReadContextComplexJson Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x48 MemberNames                 ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.EmptyDictionaryString                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x50 EmptyDictionaryString       ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ItemName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x58 ItemName                    ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ItemNamespace                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x60 ItemNamespace               ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )

            return value;
        }
    }
}
