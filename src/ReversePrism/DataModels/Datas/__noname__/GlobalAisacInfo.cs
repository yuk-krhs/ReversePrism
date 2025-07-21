using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Index                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 01A NumGraphs                                ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Type                                     ModelEnumType AisacType AisacType AisacType Int32
    // 020 RandomRange                              ModelPrimitiveType float float float Single
    // 024 ControlId                                ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Index                                     = GetUInt16(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.NumGraphs                                 = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A NumGraphs                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Type                                      = (AisacType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Type                        ( ModelEnumType AisacType AisacType AisacType Int32 )
            value.RandomRange                               = GetSingle(new IntPtr(p + 0x020)); // 0x20 RandomRange                 ( ModelPrimitiveType float float float Single )
            value.ControlId                                 = GetUInt16(new IntPtr(p + 0x024)); // 0x24 ControlId                   ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
