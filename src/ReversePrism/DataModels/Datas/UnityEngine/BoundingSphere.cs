using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Radius                                   ModelPrimitiveType float float float Single
    public partial class BoundingSphere : DataModel
    {
        public Vector3                                  Position                                { get; set; }
        public float                                    Radius                                  { get; set; }

        public static BoundingSphere? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundingSphere() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Radius                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
