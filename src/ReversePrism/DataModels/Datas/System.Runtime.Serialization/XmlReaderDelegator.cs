using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 DictionaryReader                         ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 020 IsEndOfEmptyElement                      ModelPrimitiveType bool bool bool Bool
    public partial class XmlReaderDelegator : DataModel
    {
        public XmlReader?                               Reader                                  { get; set; }
        public XmlDictionaryReader?                     DictionaryReader                        { get; set; }
        public bool                                     IsEndOfEmptyElement                     { get; set; }

        public static XmlReaderDelegator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlReaderDelegator() { Pointer= p0 };

            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 Reader                      ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.DictionaryReader                          = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 0x18 DictionaryReader            ( ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.IsEndOfEmptyElement                       = GetBool(new IntPtr(p + 0x020)); // 0x20 IsEndOfEmptyElement         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
