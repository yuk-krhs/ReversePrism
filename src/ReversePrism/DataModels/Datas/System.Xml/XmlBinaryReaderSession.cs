using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxArrayEntries                          int IL2CPP_TYPE_I4
    // 010 Strings                                  ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 018 stringDict                               Dictionary`2<int, XmlDictionaryString> IL2CPP_TYPE_GENERICINST
    public partial class XmlBinaryReaderSession : DataModel
    {
        public List<XmlDictionaryString>?               Strings                                 { get; set; }

        public static XmlBinaryReaderSession? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBinaryReaderSession() { Pointer= p0 };

            value.Strings                                   = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x10 Strings                     ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )

            return value;
        }
    }
}
