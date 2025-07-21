using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RotateMode                               ModelEnumType RotateMode RotateMode RotateMode Int32
    // 014 AxisConstraint                           ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 018 Up                                       ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class QuaternionOptions : DataModel
    {
        public RotateMode                               RotateMode                              { get; set; }
        public AxisConstraint                           AxisConstraint                          { get; set; }
        public Vector3                                  Up                                      { get; set; }

        public static QuaternionOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuaternionOptions() { Pointer= p0 };

            value.RotateMode                                = (RotateMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 RotateMode                  ( ModelEnumType RotateMode RotateMode RotateMode Int32 )
            value.AxisConstraint                            = (AxisConstraint)GetInt32(new IntPtr(p + 0x014)); // 0x14 AxisConstraint              ( ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.Up                                        = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Up                          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
