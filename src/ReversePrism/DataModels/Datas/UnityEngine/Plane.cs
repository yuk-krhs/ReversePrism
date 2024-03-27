using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Normal                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Distance                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class Plane
    {
        public Vector3                                  M_Normal                                { get; set; }
        public float                                    M_Distance                              { get; set; }

        public static Plane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Plane();

            value.M_Normal                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0270023EEBF8 0x10 M_Normal                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Distance                                = GetSingle(new IntPtr(p + 0x01C)); // 0270023EEC18 0x1C M_Distance                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
