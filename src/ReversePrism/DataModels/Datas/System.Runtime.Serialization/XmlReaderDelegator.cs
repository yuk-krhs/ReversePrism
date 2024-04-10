using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   0001865A9E00 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 DictionaryReader                         000186593E70 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 020 IsEndOfEmptyElement                      000186595480 ModelPrimitiveType bool bool bool Bool
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

            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0245A4CA0FD0 0x10 Reader                      ( 0001865A9E00 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.DictionaryReader                          = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 0245A4CA0FF0 0x18 DictionaryReader            ( 000186593E70 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.IsEndOfEmptyElement                       = GetBool(new IntPtr(p + 0x020)); // 0245A4CA1010 0x20 IsEndOfEmptyElement         ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
