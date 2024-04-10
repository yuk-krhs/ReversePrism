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
    // 01A NumGraphs                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Type                                     000186547EA0 ModelEnumType AisacType AisacType AisacType Int32
    // 020 RandomRange                              000186666050 ModelPrimitiveType float float float Single
    // 024 ControlId                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class GlobalAisacInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public ushort                                   Index                                   { get; set; }
        public ushort                                   NumGraphs                               { get; set; }
        public AisacType                                Type                                    { get; set; }
        public float                                    RandomRange                             { get; set; }
        public ushort                                   ControlId                               { get; set; }

        public static GlobalAisacInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalAisacInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466AD2A020 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Index                                     = GetUInt16(new IntPtr(p + 0x018)); // 02466AD2A040 0x18 Index                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumGraphs                                 = GetUInt16(new IntPtr(p + 0x01A)); // 02466AD2A060 0x1A NumGraphs                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Type                                      = (AisacType)GetInt32(new IntPtr(p + 0x01C)); // 02466AD2A080 0x1C Type                        ( 000186547EA0 ModelEnumType AisacType AisacType AisacType Int32 )
            value.RandomRange                               = GetSingle(new IntPtr(p + 0x020)); // 02466AD2A0A0 0x20 RandomRange                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.ControlId                                 = GetUInt16(new IntPtr(p + 0x024)); // 02466AD2A0C0 0x24 ControlId                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
