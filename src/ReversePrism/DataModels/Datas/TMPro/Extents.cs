using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 zero                                     Extents IL2CPP_TYPE_VALUETYPE
    // 010 Uninitialized                            0001865360E0 ModelEnumType Extents Extents Extents Int32
    // 010 Min                                      0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Max                                      0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class Extents
    {
        public Extents                                  Uninitialized                           { get; set; }
        public Vector2                                  Min                                     { get; set; }
        public Vector2                                  Max                                     { get; set; }

        public static Extents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Extents();

            value.Uninitialized                             = (Extents)GetInt32(new IntPtr(p + 0x010)); // 0270D0954E88 0x10 Uninitialized               ( 0001865360E0 ModelEnumType Extents Extents Extents Int32 )
            value.Min                                       = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270D0954EA8 0x10 Min                         ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Max                                       = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0270D0954EC8 0x18 Max                         ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
