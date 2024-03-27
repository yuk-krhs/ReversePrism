using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 o                                        <object> IL2CPP_TYPE_OBJECT
    // 018 Elem                                     000186597700 ModelClassType XmlElement XmlElement XmlElement Pointer
    // 020 Qnames                                   000186671910 ModelPrimitiveType string string string String
    // 028 LineNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C LinePosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlElementEventArgs
    {
        public XmlElement?                              Elem                                    { get; set; }
        public string                                   Qnames                                  { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }

        public static XmlElementEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlElementEventArgs();

            value.Elem                                      = GetObject<XmlElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlElement.FromPointer); // 0270D749EB48 0x18 Elem                        ( 000186597700 ModelClassType XmlElement XmlElement XmlElement Pointer )
            value.Qnames                                    = GetString(new IntPtr(p + 0x020)); // 0270D749EB68 0x20 Qnames                      ( 000186671910 ModelPrimitiveType string string string String )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x028)); // 0270D749EB88 0x28 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x02C)); // 0270D749EBA8 0x2C LinePosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
