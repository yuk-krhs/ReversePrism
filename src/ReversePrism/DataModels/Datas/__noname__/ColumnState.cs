using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 ActualWidth                              000186666050 ModelPrimitiveType float float float Single
    // 024 Width                                    000186666050 ModelPrimitiveType float float float Single
    // 028 Visible                                  000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ColumnState : DataModel
    {
        public int                                      Index                                   { get; set; }
        public string                                   Name                                    { get; set; }
        public float                                    ActualWidth                             { get; set; }
        public float                                    Width                                   { get; set; }
        public bool                                     Visible                                 { get; set; }

        public static ColumnState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnState() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A6860D08 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0245A6860D28 0x18 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ActualWidth                               = GetSingle(new IntPtr(p + 0x020)); // 0245A6860D48 0x20 ActualWidth                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x024)); // 0245A6860D68 0x24 Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Visible                                   = GetBool(new IntPtr(p + 0x028)); // 0245A6860D88 0x28 Visible                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
