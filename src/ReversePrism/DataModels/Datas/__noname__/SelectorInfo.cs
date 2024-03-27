using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Index                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A NumLabels                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C GlobalLabelIndex                         000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class SelectorInfo
    {
        public string                                   Name                                    { get; set; }
        public ushort                                   Index                                   { get; set; }
        public ushort                                   NumLabels                               { get; set; }
        public ushort                                   GlobalLabelIndex                        { get; set; }

        public static SelectorInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectorInfo();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270DACC20E0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Index                                     = GetUInt16(new IntPtr(p + 0x018)); // 0270DACC2100 0x18 Index                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumLabels                                 = GetUInt16(new IntPtr(p + 0x01A)); // 0270DACC2120 0x1A NumLabels                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.GlobalLabelIndex                          = GetUInt16(new IntPtr(p + 0x01C)); // 0270DACC2140 0x1C GlobalLabelIndex            ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
