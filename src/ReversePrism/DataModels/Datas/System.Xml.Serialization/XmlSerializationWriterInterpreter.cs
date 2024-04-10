using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 TypeMap                                  00018659F0F0 ModelClassType XmlMapping XmlMapping XmlMapping Pointer
    // 050 Format                                   00018672E200 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    public partial class XmlSerializationWriterInterpreter : DataModel
    {
        public XmlMapping?                              TypeMap                                 { get; set; }
        public SerializationFormat                      Format                                  { get; set; }

        public static XmlSerializationWriterInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializationWriterInterpreter() { Pointer= p0 };

            value.TypeMap                                   = GetObject<XmlMapping>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlMapping.FromPointer); // 024667538DA0 0x48 TypeMap                     ( 00018659F0F0 ModelClassType XmlMapping XmlMapping XmlMapping Pointer )
            value.Format                                    = (SerializationFormat)GetInt32(new IntPtr(p + 0x050)); // 024667538DC0 0x50 Format                      ( 00018672E200 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )

            return value;
        }
    }
}
