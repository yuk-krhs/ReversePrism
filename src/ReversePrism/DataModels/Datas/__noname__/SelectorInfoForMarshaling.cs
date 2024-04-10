using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 namePtr                                  <int> IL2CPP_TYPE_I
    // 018 Index                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A NumLabels                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C GlobalLabelIndex                         000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class SelectorInfoForMarshaling : DataModel
    {
        public ushort                                   Index                                   { get; set; }
        public ushort                                   NumLabels                               { get; set; }
        public ushort                                   GlobalLabelIndex                        { get; set; }

        public static SelectorInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectorInfoForMarshaling() { Pointer= p0 };

            value.Index                                     = GetUInt16(new IntPtr(p + 0x018)); // 02466AD2A680 0x18 Index                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumLabels                                 = GetUInt16(new IntPtr(p + 0x01A)); // 02466AD2A6A0 0x1A NumLabels                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.GlobalLabelIndex                          = GetUInt16(new IntPtr(p + 0x01C)); // 02466AD2A6C0 0x1C GlobalLabelIndex            ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
