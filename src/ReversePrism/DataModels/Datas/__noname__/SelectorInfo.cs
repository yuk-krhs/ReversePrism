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
    public partial class SelectorInfo : DataModel
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
            var value   = new SelectorInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466AD2A0E0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Index                                     = GetUInt16(new IntPtr(p + 0x018)); // 02466AD2A100 0x18 Index                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumLabels                                 = GetUInt16(new IntPtr(p + 0x01A)); // 02466AD2A120 0x1A NumLabels                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.GlobalLabelIndex                          = GetUInt16(new IntPtr(p + 0x01C)); // 02466AD2A140 0x1C GlobalLabelIndex            ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
