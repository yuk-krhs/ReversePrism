using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Offset                                   0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 TiltTopRate                              0001866656B0 ModelPrimitiveType float float float Single
    // 038 SphereRadius                             0001866656B0 ModelPrimitiveType float float float Single
    // 03C AxisY                                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 LightAngle                               0001866656B0 ModelPrimitiveType float float float Single
    // 04C Left                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 Manager                                  00018664E7E0 ModelClassType Render3DManager Render3DManager Render3DManager Pointer
    // 058 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 060 RingRot                                  00018660EBC0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0A0 Center                                   0001866ACE10 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0AC RenderCameraSettingIdFirst               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 RenderCameraSettingIdLast                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B4 Forward                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class AngelRingController
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
        public int                                      RenderCameraSettingIdFirst              { get; set; }
        public int                                      RenderCameraSettingIdLast               { get; set; }
        public Vector3                                  Forward                                 { get; set; }

        public static AngelRingController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AngelRingController();

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 027006A18338 0x20 BaseObject                  ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Offset                                    = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 027006A18358 0x28 Offset                      ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TiltTopRate                               = GetSingle(new IntPtr(p + 0x034)); // 027006A18378 0x34 TiltTopRate                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SphereRadius                              = GetSingle(new IntPtr(p + 0x038)); // 027006A18398 0x38 SphereRadius                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AxisY                                     = (Vector3)GetInt32(new IntPtr(p + 0x03C)); // 027006A183B8 0x3C AxisY                       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LightAngle                                = GetSingle(new IntPtr(p + 0x048)); // 027006A183D8 0x48 LightAngle                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Left                                      = GetBool(new IntPtr(p + 0x04C)); // 027006A183F8 0x4C Left                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Manager                                   = GetObject<Render3DManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.Render3DManager.FromPointer); // 027006A18418 0x50 Manager                     ( 00018664E7E0 ModelClassType Render3DManager Render3DManager Render3DManager Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x058), ReversePrism.DataModels.Character.FromPointer); // 027006A18438 0x58 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.RingRot                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x060)); // 027006A18458 0x60 RingRot                     ( 00018660EBC0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Center                                    = (Vector3)GetInt32(new IntPtr(p + 0x0A0)); // 027006A18478 0xA0 Center                      ( 0001866ACE10 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RenderCameraSettingIdFirst                = GetInt32(new IntPtr(p + 0x0AC)); // 027006A18498 0xAC RenderCameraSettingIdFirst  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RenderCameraSettingIdLast                 = GetInt32(new IntPtr(p + 0x0B0)); // 027006A184B8 0xB0 RenderCameraSettingIdLast   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Forward                                   = (Vector3)GetInt32(new IntPtr(p + 0x0B4)); // 027006A184D8 0xB4 Forward                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
