using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sri                                      ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer
    // 018 Map                                      ModelClassType ClassMap ClassMap ClassMap Pointer
    // 020 IsValueList                              ModelPrimitiveType bool bool bool Bool
    public partial class FixupCallbackInfo : DataModel
    {
        public XmlSerializationReaderInterpreter?       Sri                                     { get; set; }
        public ClassMap?                                Map                                     { get; set; }
        public bool                                     IsValueList                             { get; set; }

        public static FixupCallbackInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixupCallbackInfo() { Pointer= p0 };

            value.Sri                                       = GetObject<XmlSerializationReaderInterpreter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSerializationReaderInterpreter.FromPointer); // 0x10 Sri                         ( ModelClassType XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter XmlSerializationReaderInterpreter Pointer )
            value.Map                                       = GetObject<ClassMap>(new IntPtr(p + 0x018), ReversePrism.DataModels.ClassMap.FromPointer); // 0x18 Map                         ( ModelClassType ClassMap ClassMap ClassMap Pointer )
            value.IsValueList                               = GetBool(new IntPtr(p + 0x020)); // 0x20 IsValueList                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
