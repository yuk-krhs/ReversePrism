using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0D0 TypeMap                                  00018659F0F0 ModelClassType XmlMapping XmlMapping XmlMapping Pointer
    // 0D8 Format                                   00018672E200 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 000 AnyType                                  XmlQualifiedName IL2CPP_TYPE_CLASS
    // 008 empty_array                              <object>[] IL2CPP_TYPE_SZARRAY
    public partial class XmlSerializationReaderInterpreter
    {
        public XmlMapping?                              TypeMap                                 { get; set; }
        public SerializationFormat                      Format                                  { get; set; }

        public static XmlSerializationReaderInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializationReaderInterpreter();

            value.TypeMap                                   = GetObject<XmlMapping>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlMapping.FromPointer); // 0270D74CC928 0xD0 TypeMap                     ( 00018659F0F0 ModelClassType XmlMapping XmlMapping XmlMapping Pointer )
            value.Format                                    = (SerializationFormat)GetInt32(new IntPtr(p + 0x0D8)); // 0270D74CC948 0xD8 Format                      ( 00018672E200 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )

            return value;
        }
    }
}
