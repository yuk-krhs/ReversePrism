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
    // 01A NumGraphs                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Type                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 RandomRange                              000186666050 ModelPrimitiveType float float float Single
    // 024 ControlId                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 026 Dummy                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class GlobalAisacInfoForMarshaling
    {
        public ushort                                   Index                                   { get; set; }
        public ushort                                   NumGraphs                               { get; set; }
        public uint                                     Type                                    { get; set; }
        public float                                    RandomRange                             { get; set; }
        public ushort                                   ControlId                               { get; set; }
        public ushort                                   Dummy                                   { get; set; }

        public static GlobalAisacInfoForMarshaling? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalAisacInfoForMarshaling();

            value.Index                                     = GetUInt16(new IntPtr(p + 0x018)); // 0270DACC2538 0x18 Index                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumGraphs                                 = GetUInt16(new IntPtr(p + 0x01A)); // 0270DACC2558 0x1A NumGraphs                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Type                                      = GetUInt32(new IntPtr(p + 0x01C)); // 0270DACC2578 0x1C Type                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.RandomRange                               = GetSingle(new IntPtr(p + 0x020)); // 0270DACC2598 0x20 RandomRange                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.ControlId                                 = GetUInt16(new IntPtr(p + 0x024)); // 0270DACC25B8 0x24 ControlId                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Dummy                                     = GetUInt16(new IntPtr(p + 0x026)); // 0270DACC25D8 0x26 Dummy                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
