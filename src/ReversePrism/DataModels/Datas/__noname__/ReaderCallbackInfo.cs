using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sri                                      0001865C6FA0 ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer
    // 018 TypeMap                                  0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    public partial class ReaderCallbackInfo
    {
        public XmlSerializationReaderInterpreter?       Sri                                     { get; set; }
        public XmlTypeMapping?                          TypeMap                                 { get; set; }

        public static ReaderCallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderCallbackInfo();

            value.Sri                                       = GetObject<XmlSerializationReaderInterpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSerializationReaderInterpreter.FromPointer); // 0270D74CD6E8 0x10 Sri                         ( 0001865C6FA0 ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer )
            value.TypeMap                                   = GetObject<XmlTypeMapping>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0270D74CD708 0x18 TypeMap                     ( 0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )

            return value;
        }
    }
}
