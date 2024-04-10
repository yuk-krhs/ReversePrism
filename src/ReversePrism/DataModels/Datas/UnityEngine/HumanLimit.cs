using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Min                                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Max                                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_Center                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 M_AxisLength                             0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_UseDefaultValues                       0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.M_Min                                     = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0245A227E930 0x10 M_Min                       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Max                                     = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0245A227E950 0x1C M_Max                       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Center                                  = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0245A227E970 0x28 M_Center                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AxisLength                              = GetSingle(new IntPtr(p + 0x034)); // 0245A227E990 0x34 M_AxisLength                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_UseDefaultValues                        = GetInt32(new IntPtr(p + 0x038)); // 0245A227E9B0 0x38 M_UseDefaultValues          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
