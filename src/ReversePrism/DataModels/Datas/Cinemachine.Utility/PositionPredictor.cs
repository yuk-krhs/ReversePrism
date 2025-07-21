using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Velocity                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_SmoothDampVelocity                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_Pos                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 M_HavePos                                ModelPrimitiveType bool bool bool Bool
    // 038 Smoothing                                ModelPrimitiveType float float float Single
    public partial class PositionPredictor : DataModel
    {
        public Vector3                                  M_Velocity                              { get; set; }
        public Vector3                                  M_SmoothDampVelocity                    { get; set; }
        public Vector3                                  M_Pos                                   { get; set; }
        public bool                                     M_HavePos                               { get; set; }
        public float                                    Smoothing                               { get; set; }

        public static PositionPredictor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PositionPredictor() { Pointer= p0 };

            value.M_Velocity                                = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Velocity                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_SmoothDampVelocity                      = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_SmoothDampVelocity        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Pos                                     = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Pos                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_HavePos                                 = GetBool(new IntPtr(p + 0x034)); // 0x34 M_HavePos                   ( ModelPrimitiveType bool bool bool Bool )
            value.Smoothing                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 Smoothing                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
