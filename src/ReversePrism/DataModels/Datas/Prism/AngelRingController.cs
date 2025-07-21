using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 Offset                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 TiltTopRate                              ModelPrimitiveType float float float Single
    // 038 SphereRadius                             ModelPrimitiveType float float float Single
    // 03C AxisY                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 LightAngle                               ModelPrimitiveType float float float Single
    // 04C Left                                     ModelPrimitiveType bool bool bool Bool
    // 050 Manager                                  ModelClassType Render3DManager Render3DManager Render3DManager Pointer
    // 058 Character                                ModelClassType Character Character Character Pointer
    // 060 RingRot                                  ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0A0 Center                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class AngelRingController : DataModel
    {
        public GameObject?                              BaseObject                              { get; set; }
        public Vector3                                  Offset                                  { get; set; }
        public float                                    TiltTopRate                             { get; set; }
        public float                                    SphereRadius                            { get; set; }
        public Vector3                                  AxisY                                   { get; set; }
        public float                                    LightAngle                              { get; set; }
        public bool                                     Left                                    { get; set; }
        public Render3DManager?                         Manager                                 { get; set; }
        public Character?                               Character                               { get; set; }
        public Matrix4x4                                RingRot                                 { get; set; }
        public Vector3                                  Center                                  { get; set; }

        public static AngelRingController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AngelRingController() { Pointer= p0 };

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 BaseObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Offset                                    = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 Offset                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TiltTopRate                               = GetSingle(new IntPtr(p + 0x034)); // 0x34 TiltTopRate                 ( ModelPrimitiveType float float float Single )
            value.SphereRadius                              = GetSingle(new IntPtr(p + 0x038)); // 0x38 SphereRadius                ( ModelPrimitiveType float float float Single )
            value.AxisY                                     = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C AxisY                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LightAngle                                = GetSingle(new IntPtr(p + 0x048)); // 0x48 LightAngle                  ( ModelPrimitiveType float float float Single )
            value.Left                                      = GetBool(new IntPtr(p + 0x04C)); // 0x4C Left                        ( ModelPrimitiveType bool bool bool Bool )
            value.Manager                                   = GetObject<Render3DManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.Render3DManager.FromPointer); // 0x50 Manager                     ( ModelClassType Render3DManager Render3DManager Render3DManager Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x058), ReversePrism.DataModels.Character.FromPointer); // 0x58 Character                   ( ModelClassType Character Character Character Pointer )
            value.RingRot                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x060)); // 0x60 RingRot                     ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Center                                    = (Vector3)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Center                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
