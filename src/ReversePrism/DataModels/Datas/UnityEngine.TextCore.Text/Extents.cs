using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Max                                      ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class Extents : DataModel
    {
        public Vector2                                  Min                                     { get; set; }
        public Vector2                                  Max                                     { get; set; }

        public static Extents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Extents() { Pointer= p0 };

            value.Min                                       = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Min                         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Max                                       = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 Max                         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
