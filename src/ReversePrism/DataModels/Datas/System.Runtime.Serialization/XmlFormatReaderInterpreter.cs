using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Is_get_only_collection                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 ClassContract                            0001865AFE30 ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer
    // 020 CollectionContract                       0001865C4B80 ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer
    // 028 objectLocal                              <object> IL2CPP_TYPE_OBJECT
    // 030 ObjectType                               000186692850 ModelClassType Type Type Type Pointer
    // 038 XmlReader                                0001865AA5B0 ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer
    // 040 Context                                  0001865A5E80 ModelClassType XmlObjectSerializerReadContext XmlObjectSerializerReadContext XmlObjectSerializerReadContext Pointer
    // 048 MemberNames                              000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 050 MemberNamespaces                         000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 058 ItemName                                 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 060 ItemNamespace                            0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    public partial class XmlFormatReaderInterpreter
    {
        public bool                                     Is_get_only_collection                  { get; set; }
        public ClassDataContract?                       ClassContract                           { get; set; }
        public CollectionDataContract?                  CollectionContract                      { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public XmlReaderDelegator?                      XmlReader                               { get; set; }
        public XmlObjectSerializerReadContext?          Context                                 { get; set; }
        public List<XmlDictionaryString>?               MemberNames                             { get; set; }
        public List<XmlDictionaryString>?               MemberNamespaces                        { get; set; }
        public XmlDictionaryString?                     ItemName                                { get; set; }
        public XmlDictionaryString?                     ItemNamespace                           { get; set; }

        public static XmlFormatReaderInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlFormatReaderInterpreter();

            value.Is_get_only_collection                    = GetBool(new IntPtr(p + 0x010)); // 0270D7DC1E48 0x10 Is_get_only_collection      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ClassContract                             = GetObject<ClassDataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.ClassDataContract.FromPointer); // 0270D7DC1E68 0x18 ClassContract               ( 0001865AFE30 ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer )
            value.CollectionContract                        = GetObject<CollectionDataContract>(new IntPtr(p + 0x020), ReversePrism.DataModels.CollectionDataContract.FromPointer); // 0270D7DC1E88 0x20 CollectionContract          ( 0001865C4B80 ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0270D7DC1EC8 0x30 ObjectType                  ( 000186692850 ModelClassType Type Type Type Pointer )
            value.XmlReader                                 = GetObject<XmlReaderDelegator>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlReaderDelegator.FromPointer); // 0270D7DC1EE8 0x38 XmlReader                   ( 0001865AA5B0 ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer )
            value.Context                                   = GetObject<XmlObjectSerializerReadContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlObjectSerializerReadContext.FromPointer); // 0270D7DC1F08 0x40 Context                     ( 0001865A5E80 ModelClassType XmlObjectSerializerReadContext XmlObjectSerializerReadContext XmlObjectSerializerReadContext Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7DC1F28 0x48 MemberNames                 ( 000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNamespaces                          = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7DC1F48 0x50 MemberNamespaces            ( 000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.ItemName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7DC1F68 0x58 ItemName                    ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ItemNamespace                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7DC1F88 0x60 ItemNamespace               ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )

            return value;
        }
    }
}
