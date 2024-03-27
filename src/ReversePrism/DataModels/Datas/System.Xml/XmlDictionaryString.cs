using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MinKey                                   int IL2CPP_TYPE_I4
    // 000 MaxKey                                   int IL2CPP_TYPE_I4
    // 010 Dictionary                               00018669E7C0 ModelClassType IXmlDictionary IXmlDictionary IXmlDictionary Pointer
    // 018 Value                                    000186671910 ModelPrimitiveType string string string String
    // 020 Key                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 emptyStringDictionary                    EmptyStringDictionary IL2CPP_TYPE_CLASS
    public partial class XmlDictionaryString
    {
        public IXmlDictionary?                          Dictionary                              { get; set; }
        public string                                   Value                                   { get; set; }
        public int                                      Key                                     { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }

        public static XmlDictionaryString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDictionaryString();

            value.Dictionary                                = GetObject<IXmlDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.IXmlDictionary.FromPointer); // 027004C66A08 0x10 Dictionary                  ( 00018669E7C0 ModelClassType IXmlDictionary IXmlDictionary IXmlDictionary Pointer )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 027004C66A28 0x18 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Key                                       = GetInt32(new IntPtr(p + 0x020)); // 027004C66A48 0x20 Key                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 027004C66A68 0x28 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
