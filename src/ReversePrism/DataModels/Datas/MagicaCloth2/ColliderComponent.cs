using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Center                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C Size                                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 teamIdSet                                HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ColliderComponent : DataModel
    {
        public Vector3                                  Center                                  { get; set; }
        public Vector3                                  Size                                    { get; set; }

        public static ColliderComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderComponent() { Pointer= p0 };

            value.Center                                    = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 Center                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Size                                      = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Size                        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
