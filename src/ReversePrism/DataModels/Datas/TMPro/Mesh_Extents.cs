using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Max                                      0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class Mesh_Extents : DataModel
    {
        public Vector2                                  Min                                     { get; set; }
        public Vector2                                  Max                                     { get; set; }

        public static Mesh_Extents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mesh_Extents() { Pointer= p0 };

            value.Min                                       = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 02466A674678 0x10 Min                         ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Max                                       = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 02466A674698 0x18 Max                         ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
