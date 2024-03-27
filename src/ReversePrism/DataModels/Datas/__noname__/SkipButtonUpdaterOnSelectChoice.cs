using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Text                                     000186671910 ModelPrimitiveType string string string String
    // 020 ExistChoice                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SkipButtonUpdaterOnSelectChoice
    {
        public ushort                                   Index                                   { get; set; }
        public string                                   Text                                    { get; set; }
        public bool                                     ExistChoice                             { get; set; }

        public static SkipButtonUpdaterOnSelectChoice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipButtonUpdaterOnSelectChoice();

            value.Index                                     = GetUInt16(new IntPtr(p + 0x010)); // 0270D5DD4D28 0x10 Index                       ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0270D5DD4D48 0x18 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ExistChoice                               = GetBool(new IntPtr(p + 0x020)); // 0270D5DD4D68 0x20 ExistChoice                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
