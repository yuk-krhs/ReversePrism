using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Normal                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class MeshColliderParam
    {
        public Vector3                                  Position                                { get; set; }
        public Vector3                                  Normal                                  { get; set; }

        public static MeshColliderParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshColliderParam();

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0270D4D99998 0x10 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Normal                                    = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0270D4D999B8 0x1C Normal                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
