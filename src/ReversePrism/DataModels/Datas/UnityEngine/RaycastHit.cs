using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Point                                  0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Normal                                 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_FaceID                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 02C M_Distance                               000186665900 ModelPrimitiveType float float float Single
    // 030 M_UV                                     0001866A8240 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 038 M_Collider                               0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class RaycastHit
    {
        public Vector3                                  M_Point                                 { get; set; }
        public Vector3                                  M_Normal                                { get; set; }
        public uint                                     M_FaceID                                { get; set; }
        public float                                    M_Distance                              { get; set; }
        public Vector2                                  M_UV                                    { get; set; }
        public int                                      M_Collider                              { get; set; }

        public static RaycastHit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RaycastHit();

            value.M_Point                                   = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 02700214E910 0x10 M_Point                     ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Normal                                  = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 02700214E930 0x1C M_Normal                    ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_FaceID                                  = GetUInt32(new IntPtr(p + 0x028)); // 02700214E950 0x28 M_FaceID                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_Distance                                = GetSingle(new IntPtr(p + 0x02C)); // 02700214E970 0x2C M_Distance                  ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_UV                                      = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 02700214E990 0x30 M_UV                        ( 0001866A8240 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Collider                                = GetInt32(new IntPtr(p + 0x038)); // 02700214E9B0 0x38 M_Collider                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
