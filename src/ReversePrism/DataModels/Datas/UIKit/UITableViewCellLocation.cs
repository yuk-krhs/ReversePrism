using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    ModelPrimitiveType int int int Int32
    // 014 Alignment                                ModelEnumType UITableViewCellAlignment UITableViewCellAlignment UITableViewCellAlignment Int32
    // 018 WithMargin                               ModelPrimitiveType bool bool bool Bool
    // 01C Displacement                             ModelPrimitiveType float float float Single
    public partial class UITableViewCellLocation : DataModel
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
            var value   = new UITableViewCellLocation() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Alignment                                 = (UITableViewCellAlignment)GetInt32(new IntPtr(p + 0x014)); // 0x14 Alignment                   ( ModelEnumType UITableViewCellAlignment UITableViewCellAlignment UITableViewCellAlignment Int32 )
            value.WithMargin                                = GetBool(new IntPtr(p + 0x018)); // 0x18 WithMargin                  ( ModelPrimitiveType bool bool bool Bool )
            value.Displacement                              = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Displacement                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
