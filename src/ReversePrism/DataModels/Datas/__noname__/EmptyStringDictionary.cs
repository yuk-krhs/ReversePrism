using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Empty                                    ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    public partial class EmptyStringDictionary : DataModel
    {
        public XmlDictionaryString?                     Empty                                   { get; set; }

        public static EmptyStringDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EmptyStringDictionary() { Pointer= p0 };

            value.Empty                                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x10 Empty                       ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )

            return value;
        }
    }
}
