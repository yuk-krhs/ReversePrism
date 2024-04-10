using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_StartCorner                            0001865231E0 ModelEnumType Corner Corner Corner Int32
    // 064 M_StartAxis                              0001865221E0 ModelEnumType Axis Axis Axis Int32
    // 068 M_CellSize                               0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 070 M_Spacing                                0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 M_Constraint                             000186522A10 ModelEnumType Constraint Constraint Constraint Int32
    // 07C M_ConstraintCount                        0001865F3220 ModelPrimitiveType int int int Int32
    public partial class GridLayoutGroup : DataModel
    {
        public Corner                                   M_StartCorner                           { get; set; }
        public Axis                                     M_StartAxis                             { get; set; }
        public Vector2                                  M_CellSize                              { get; set; }
        public Vector2                                  M_Spacing                               { get; set; }
        public Constraint                               M_Constraint                            { get; set; }
        public int                                      M_ConstraintCount                       { get; set; }

        public static GridLayoutGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GridLayoutGroup() { Pointer= p0 };

            value.M_StartCorner                             = (Corner)GetInt32(new IntPtr(p + 0x060)); // 024660D52E18 0x60 M_StartCorner               ( 0001865231E0 ModelEnumType Corner Corner Corner Int32 )
            value.M_StartAxis                               = (Axis)GetInt32(new IntPtr(p + 0x064)); // 024660D52E38 0x64 M_StartAxis                 ( 0001865221E0 ModelEnumType Axis Axis Axis Int32 )
            value.M_CellSize                                = (Vector2)GetInt32(new IntPtr(p + 0x068)); // 024660D52E58 0x68 M_CellSize                  ( 0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Spacing                                 = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 024660D52E78 0x70 M_Spacing                   ( 0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Constraint                              = (Constraint)GetInt32(new IntPtr(p + 0x078)); // 024660D52E98 0x78 M_Constraint                ( 000186522A10 ModelEnumType Constraint Constraint Constraint Int32 )
            value.M_ConstraintCount                         = GetInt32(new IntPtr(p + 0x07C)); // 024660D52EB8 0x7C M_ConstraintCount           ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
