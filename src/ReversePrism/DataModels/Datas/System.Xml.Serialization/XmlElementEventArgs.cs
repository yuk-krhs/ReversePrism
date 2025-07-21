using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 o                                        <object> IL2CPP_TYPE_OBJECT
    // 018 Elem                                     ModelClassType XmlElement XmlElement XmlElement Pointer
    // 020 Qnames                                   ModelPrimitiveType string string string String
    // 028 LineNumber                               ModelPrimitiveType int int int Int32
    // 02C LinePosition                             ModelPrimitiveType int int int Int32
    public partial class XmlElementEventArgs : DataModel
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
            var value   = new XmlElementEventArgs() { Pointer= p0 };

            value.Elem                                      = GetObject<XmlElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlElement.FromPointer); // 0x18 Elem                        ( ModelClassType XmlElement XmlElement XmlElement Pointer )
            value.Qnames                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Qnames                      ( ModelPrimitiveType string string string String )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 LineNumber                  ( ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C LinePosition                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
