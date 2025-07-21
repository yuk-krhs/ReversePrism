using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sri                                      ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer
    // 018 TypeMap                                  ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    public partial class ReaderCallbackInfo : DataModel
    {
        public XmlSerializationReaderInterpreter?       Sri                                     { get; set; }
        public XmlTypeMapping?                          TypeMap                                 { get; set; }

        public static ReaderCallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReaderCallbackInfo() { Pointer= p0 };

            value.Sri                                       = GetObject<XmlSerializationReaderInterpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSerializationReaderInterpreter.FromPointer); // 0x10 Sri                         ( ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer )
            value.TypeMap                                   = GetObject<XmlTypeMapping>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0x18 TypeMap                     ( ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )

            return value;
        }
    }
}
