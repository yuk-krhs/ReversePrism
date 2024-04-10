using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Point1                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Point2                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class LineSegment : DataModel
    {
        public Vector3                                  Point1                                  { get; set; }
        public Vector3                                  Point2                                  { get; set; }

        public static LineSegment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LineSegment() { Pointer= p0 };

            value.Point1                                    = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 02466A6CAB00 0x10 Point1                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Point2                                    = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 02466A6CAB20 0x1C Point2                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
