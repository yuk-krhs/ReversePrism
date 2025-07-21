using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventType                                ModelEnumType XmlEventType XmlEventType XmlEventType Int32
    // 018 S1                                       ModelPrimitiveType string string string String
    // 020 S2                                       ModelPrimitiveType string string string String
    // 028 S3                                       ModelPrimitiveType string string string String
    // 030 o                                        <object> IL2CPP_TYPE_OBJECT
    public partial class XmlEvent : DataModel
    {
        public XmlEventType                             EventType                               { get; set; }
        public string                                   S1                                      { get; set; }
        public string                                   S2                                      { get; set; }
        public string                                   S3                                      { get; set; }

        public static XmlEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlEvent() { Pointer= p0 };

            value.EventType                                 = (XmlEventType)GetInt32(new IntPtr(p + 0x010)); // 0x10 EventType                   ( ModelEnumType XmlEventType XmlEventType XmlEventType Int32 )
            value.S1                                        = GetString(new IntPtr(p + 0x018)); // 0x18 S1                          ( ModelPrimitiveType string string string String )
            value.S2                                        = GetString(new IntPtr(p + 0x020)); // 0x20 S2                          ( ModelPrimitiveType string string string String )
            value.S3                                        = GetString(new IntPtr(p + 0x028)); // 0x28 S3                          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
