using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Min                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Max                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_Center                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 M_AxisLength                             ModelPrimitiveType float float float Single
    // 038 M_UseDefaultValues                       ModelPrimitiveType int int int Int32
    public partial class HumanLimit : DataModel
    {
        public Vector3                                  M_Min                                   { get; set; }
        public Vector3                                  M_Max                                   { get; set; }
        public Vector3                                  M_Center                                { get; set; }
        public float                                    M_AxisLength                            { get; set; }
        public int                                      M_UseDefaultValues                      { get; set; }

        public static HumanLimit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HumanLimit() { Pointer= p0 };

            value.M_Min                                     = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Min                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Max                                     = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Max                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Center                                  = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Center                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AxisLength                              = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_AxisLength                ( ModelPrimitiveType float float float Single )
            value.M_UseDefaultValues                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_UseDefaultValues          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
