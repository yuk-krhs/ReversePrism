using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Normal                                   0001867766A0 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C D                                        000186666050 ModelPrimitiveType float float float Single
    public partial class Plane : DataModel
    {
        public Vector3                                  Normal                                  { get; set; }
        public float                                    D                                       { get; set; }

        public static Plane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Plane() { Pointer= p0 };

            value.Normal                                    = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0245A44FDE78 0x10 Normal                      ( 0001867766A0 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.D                                         = GetSingle(new IntPtr(p + 0x01C)); // 0245A44FDE98 0x1C D                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
