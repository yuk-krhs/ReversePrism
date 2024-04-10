using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Angle                                  0001866B01B0 ModelEnumType Angle Angle Angle Int32
    // 018 M_Axis                                   0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 M_IsNone                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Rotate : DataModel
    {
        public Angle                                    M_Angle                                 { get; set; }
        public Vector3                                  M_Axis                                  { get; set; }
        public bool                                     M_IsNone                                { get; set; }

        public static Rotate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Rotate() { Pointer= p0 };

            value.M_Angle                                   = (Angle)GetInt32(new IntPtr(p + 0x010)); // 0245A3F20B00 0x10 M_Angle                     ( 0001866B01B0 ModelEnumType Angle Angle Angle Int32 )
            value.M_Axis                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0245A3F20B20 0x18 M_Axis                      ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_IsNone                                  = GetBool(new IntPtr(p + 0x024)); // 0245A3F20B40 0x24 M_IsNone                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
