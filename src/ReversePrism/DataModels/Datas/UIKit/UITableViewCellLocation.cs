using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Alignment                                0001866F7220 ModelEnumType UITableViewCellAlignment UITableViewCellAlignment UITableViewCellAlignment Int32
    // 018 WithMargin                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C Displacement                             000186666050 ModelPrimitiveType float float float Single
    public partial class UITableViewCellLocation
    {
        public int                                      Index                                   { get; set; }
        public UITableViewCellAlignment                 Alignment                               { get; set; }
        public bool                                     WithMargin                              { get; set; }
        public float                                    Displacement                            { get; set; }

        public static UITableViewCellLocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UITableViewCellLocation();

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DBD8AE38 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Alignment                                 = (UITableViewCellAlignment)GetInt32(new IntPtr(p + 0x014)); // 0270DBD8AE58 0x14 Alignment                   ( 0001866F7220 ModelEnumType UITableViewCellAlignment UITableViewCellAlignment UITableViewCellAlignment Int32 )
            value.WithMargin                                = GetBool(new IntPtr(p + 0x018)); // 0270DBD8AE78 0x18 WithMargin                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Displacement                              = GetSingle(new IntPtr(p + 0x01C)); // 0270DBD8AE98 0x1C Displacement                ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
