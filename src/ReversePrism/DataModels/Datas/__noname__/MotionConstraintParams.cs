using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseMaxDistance                           ModelPrimitiveType bool bool bool Bool
    // 014 MaxDistanceCurveData                     ModelEnumType float4x4 float4x4 float4x4 Int32
    // 054 UseBackstop                              ModelPrimitiveType bool bool bool Bool
    // 058 BackstopRadius                           ModelPrimitiveType float float float Single
    // 05C BackstopDistanceCurveData                ModelEnumType float4x4 float4x4 float4x4 Int32
    // 09C Stiffness                                ModelPrimitiveType float float float Single
    public partial class MotionConstraintParams : DataModel
    {
        public bool                                     UseMaxDistance                          { get; set; }
        public float4x4                                 MaxDistanceCurveData                    { get; set; }
        public bool                                     UseBackstop                             { get; set; }
        public float                                    BackstopRadius                          { get; set; }
        public float4x4                                 BackstopDistanceCurveData               { get; set; }
        public float                                    Stiffness                               { get; set; }

        public static MotionConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MotionConstraintParams() { Pointer= p0 };

            value.UseMaxDistance                            = GetBool(new IntPtr(p + 0x010)); // 0x10 UseMaxDistance              ( ModelPrimitiveType bool bool bool Bool )
            value.MaxDistanceCurveData                      = (float4x4)GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxDistanceCurveData        ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.UseBackstop                               = GetBool(new IntPtr(p + 0x054)); // 0x54 UseBackstop                 ( ModelPrimitiveType bool bool bool Bool )
            value.BackstopRadius                            = GetSingle(new IntPtr(p + 0x058)); // 0x58 BackstopRadius              ( ModelPrimitiveType float float float Single )
            value.BackstopDistanceCurveData                 = (float4x4)GetInt32(new IntPtr(p + 0x05C)); // 0x5C BackstopDistanceCurveData   ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.Stiffness                                 = GetSingle(new IntPtr(p + 0x09C)); // 0x9C Stiffness                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
