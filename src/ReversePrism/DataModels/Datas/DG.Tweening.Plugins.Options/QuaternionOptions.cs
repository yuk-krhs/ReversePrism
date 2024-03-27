using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RotateMode                               0001866933A0 ModelEnumType RotateMode RotateMode RotateMode Int32
    // 014 AxisConstraint                           0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 018 Up                                       0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class QuaternionOptions
    {
        public RotateMode                               RotateMode                              { get; set; }
        public AxisConstraint                           AxisConstraint                          { get; set; }
        public Vector3                                  Up                                      { get; set; }

        public static QuaternionOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuaternionOptions();

            value.RotateMode                                = (RotateMode)GetInt32(new IntPtr(p + 0x010)); // 0270DB072B68 0x10 RotateMode                  ( 0001866933A0 ModelEnumType RotateMode RotateMode RotateMode Int32 )
            value.AxisConstraint                            = (AxisConstraint)GetInt32(new IntPtr(p + 0x014)); // 0270DB072B88 0x14 AxisConstraint              ( 0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.Up                                        = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270DB072BA8 0x18 Up                          ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
