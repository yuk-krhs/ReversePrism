using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 M_StartCorner                            ModelEnumType Corner Corner Corner Int32
    // 064 M_StartAxis                              ModelEnumType Axis Axis Axis Int32
    // 068 M_CellSize                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 070 M_Spacing                                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 M_Constraint                             ModelEnumType Constraint Constraint Constraint Int32
    // 07C M_ConstraintCount                        ModelPrimitiveType int int int Int32
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

            value.M_StartCorner                             = (Corner)GetInt32(new IntPtr(p + 0x060)); // 0x60 M_StartCorner               ( ModelEnumType Corner Corner Corner Int32 )
            value.M_StartAxis                               = (Axis)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_StartAxis                 ( ModelEnumType Axis Axis Axis Int32 )
            value.M_CellSize                                = (Vector2)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_CellSize                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Spacing                                 = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_Spacing                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Constraint                              = (Constraint)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_Constraint                ( ModelEnumType Constraint Constraint Constraint Int32 )
            value.M_ConstraintCount                         = GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_ConstraintCount           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
