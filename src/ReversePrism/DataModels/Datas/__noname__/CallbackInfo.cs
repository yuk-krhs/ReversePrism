using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Swi                                      0001865C7BA0 ModelClassType XmlSerializationWriterInterpreter XmlSerializationWriterInterpreter XmlSerializationWriterInterpreter Pointer
    // 018 TypeMap                                  0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    public partial class CallbackInfo
    {
        public XmlSerializationWriterInterpreter?       Swi                                     { get; set; }
        public XmlTypeMapping?                          TypeMap                                 { get; set; }

        public static CallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackInfo();

            value.Swi                                       = GetObject<XmlSerializationWriterInterpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSerializationWriterInterpreter.FromPointer); // 0270D74D0158 0x10 Swi                         ( 0001865C7BA0 ModelClassType XmlSerializationWriterInterpreter XmlSerializationWriterInterpreter XmlSerializationWriterInterpreter Pointer )
            value.TypeMap                                   = GetObject<XmlTypeMapping>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0270D74D0178 0x18 TypeMap                     ( 0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )

            return value;
        }
    }
}
