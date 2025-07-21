using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 JsonFormatReaderDelegate                 ModelClassType JsonFormatClassReaderDelegate JsonFormatClassReaderDelegate JsonFormatClassReaderDelegate Pointer
    // 030 JsonFormatWriterDelegate                 ModelClassType JsonFormatClassWriterDelegate JsonFormatClassWriterDelegate JsonFormatClassWriterDelegate Pointer
    // 038 MemberNames                              ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 040 TraditionalClassDataContract             ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer
    // 048 TypeName                                 ModelPrimitiveType string string string String
    public partial class JsonClassDataContractCriticalHelper : DataModel
    {
        public JsonFormatClassReaderDelegate?           JsonFormatReaderDelegate                { get; set; }
        public JsonFormatClassWriterDelegate?           JsonFormatWriterDelegate                { get; set; }
        public List<XmlDictionaryString>?               MemberNames                             { get; set; }
        public ClassDataContract?                       TraditionalClassDataContract            { get; set; }
        public string                                   TypeName                                { get; set; }

        public static JsonClassDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonClassDataContractCriticalHelper() { Pointer= p0 };

            value.JsonFormatReaderDelegate                  = GetObject<JsonFormatClassReaderDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.JsonFormatClassReaderDelegate.FromPointer); // 0x28 JsonFormatReaderDelegate    ( ModelClassType JsonFormatClassReaderDelegate JsonFormatClassReaderDelegate JsonFormatClassReaderDelegate Pointer )
            value.JsonFormatWriterDelegate                  = GetObject<JsonFormatClassWriterDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonFormatClassWriterDelegate.FromPointer); // 0x30 JsonFormatWriterDelegate    ( ModelClassType JsonFormatClassWriterDelegate JsonFormatClassWriterDelegate JsonFormatClassWriterDelegate Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x38 MemberNames                 ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.TraditionalClassDataContract              = GetObject<ClassDataContract>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClassDataContract.FromPointer); // 0x40 TraditionalClassDataContract ( ModelClassType ClassDataContract ClassDataContract ClassDataContract Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x048)); // 0x48 TypeName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
