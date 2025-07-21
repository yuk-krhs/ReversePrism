using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Center                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Extents                                ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class Bounds : DataModel
    {
        public Vector3                                  M_Center                                { get; set; }
        public Vector3                                  M_Extents                               { get; set; }

        public static Bounds? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Bounds() { Pointer= p0 };

            value.M_Center                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Center                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Extents                                 = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Extents                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
