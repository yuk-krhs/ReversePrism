using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Up                                       0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Right                                    0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 Forward                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class Axes : DataModel
    {
        public Vector3                                  Up                                      { get; set; }
        public Vector3                                  Right                                   { get; set; }
        public Vector3                                  Forward                                 { get; set; }

        public static Axes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Axes() { Pointer= p0 };

            value.Up                                        = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0246690BA250 0x10 Up                          ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Right                                     = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0246690BA270 0x1C Right                       ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Forward                                   = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0246690BA290 0x28 Forward                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
