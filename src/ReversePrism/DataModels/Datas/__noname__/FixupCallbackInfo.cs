using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sri                                      0001865C6FA0 ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer
    // 018 Map                                      0001865B1470 ModelClassType ClassMap ClassMap ClassMap Pointer
    // 020 IsValueList                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FixupCallbackInfo
    {
        public XmlSerializationReaderInterpreter?       Sri                                     { get; set; }
        public ClassMap?                                Map                                     { get; set; }
        public bool                                     IsValueList                             { get; set; }

        public static FixupCallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixupCallbackInfo();

            value.Sri                                       = GetObject<XmlSerializationReaderInterpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSerializationReaderInterpreter.FromPointer); // 0270D74CB7B0 0x10 Sri                         ( 0001865C6FA0 ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer )
            value.Map                                       = GetObject<ClassMap>(new IntPtr(p + 0x018), ReversePrism.DataModels.ClassMap.FromPointer); // 0270D74CB7D0 0x18 Map                         ( 0001865B1470 ModelClassType ClassMap ClassMap ClassMap Pointer )
            value.IsValueList                               = GetBool(new IntPtr(p + 0x020)); // 0270D74CB7F0 0x20 IsValueList                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
