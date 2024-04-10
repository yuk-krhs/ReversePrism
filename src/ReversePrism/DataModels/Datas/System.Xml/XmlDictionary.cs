using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 empty                                    IXmlDictionary IL2CPP_TYPE_CLASS
    // 010 lookup                                   Dictionary`2<string, XmlDictionaryString> IL2CPP_TYPE_GENERICINST
    // 018 Strings                                  000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 020 NextId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlDictionary : DataModel
    {
        public List<XmlDictionaryString>?               Strings                                 { get; set; }
        public int                                      NextId                                  { get; set; }

        public static XmlDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDictionary() { Pointer= p0 };

            value.Strings                                   = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4C714A0 0x18 Strings                     ( 000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.NextId                                    = GetInt32(new IntPtr(p + 0x020)); // 0245A4C714C0 0x20 NextId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
