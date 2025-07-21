using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 size                                     int IL2CPP_TYPE_I4
    // 010 M_Normal                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Distance                               ModelPrimitiveType float float float Single
    public partial class Plane : DataModel
    {
        public Vector3                                  M_Normal                                { get; set; }
        public float                                    M_Distance                              { get; set; }

        public static Plane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Plane() { Pointer= p0 };

            value.M_Normal                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Normal                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Distance                                = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_Distance                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
