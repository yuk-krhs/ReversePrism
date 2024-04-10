using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C B                                        0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class ControlPoint : DataModel
    {
        public Vector3                                  A                                       { get; set; }
        public Vector3                                  B                                       { get; set; }

        public static ControlPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlPoint() { Pointer= p0 };

            value.A                                         = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 02466B140AD8 0x10 A                           ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.B                                         = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 02466B140AF8 0x1C B                           ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
