using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoveFlag                                 ModelPrimitiveType bool bool bool Bool
    // 024 MoveMargin                               ModelPrimitiveType float float float Single
    // 028 MoveTrans                                ModelPrimitiveType float float float Single
    // 02C UvParam                                  ModelEnumType Vector4 Vector4 Vector4 Int32
    // 03C AspectRatio                              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 04C Initialized                              ModelPrimitiveType bool bool bool Bool
    // 050 TargetCam                                ModelClassType Camera Camera Camera Pointer
    // 058 FarTexture                               ModelClassType Texture Texture Texture Pointer
    // 060 StartQ                                   ModelEnumType Quaternion Quaternion Quaternion Int32
    // 070 StartFovY                                ModelPrimitiveType float float float Single
    // 074 StartPos                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 CurrentCamera                            ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer
    public partial class FarPlaneFitter : DataModel
    {
        public bool                                     MoveFlag                                { get; set; }
        public float                                    MoveMargin                              { get; set; }
        public float                                    MoveTrans                               { get; set; }
        public Vector4                                  UvParam                                 { get; set; }
        public Vector4                                  AspectRatio                             { get; set; }
        public bool                                     Initialized                             { get; set; }
        public Camera?                                  TargetCam                               { get; set; }
        public Texture?                                 FarTexture                              { get; set; }
        public Quaternion                               StartQ                                  { get; set; }
        public float                                    StartFovY                               { get; set; }
        public Vector3                                  StartPos                                { get; set; }
        public CameraWorkData?                          CurrentCamera                           { get; set; }

        public static FarPlaneFitter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FarPlaneFitter() { Pointer= p0 };

            value.MoveFlag                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 MoveFlag                    ( ModelPrimitiveType bool bool bool Bool )
            value.MoveMargin                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 MoveMargin                  ( ModelPrimitiveType float float float Single )
            value.MoveTrans                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 MoveTrans                   ( ModelPrimitiveType float float float Single )
            value.UvParam                                   = (Vector4)GetInt32(new IntPtr(p + 0x02C)); // 0x2C UvParam                     ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.AspectRatio                               = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 0x3C AspectRatio                 ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Initialized                               = GetBool(new IntPtr(p + 0x04C)); // 0x4C Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.TargetCam                                 = GetObject<Camera>(new IntPtr(p + 0x050), ReversePrism.DataModels.Camera.FromPointer); // 0x50 TargetCam                   ( ModelClassType Camera Camera Camera Pointer )
            value.FarTexture                                = GetObject<Texture>(new IntPtr(p + 0x058), ReversePrism.DataModels.Texture.FromPointer); // 0x58 FarTexture                  ( ModelClassType Texture Texture Texture Pointer )
            value.StartQ                                    = (Quaternion)GetInt32(new IntPtr(p + 0x060)); // 0x60 StartQ                      ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.StartFovY                                 = GetSingle(new IntPtr(p + 0x070)); // 0x70 StartFovY                   ( ModelPrimitiveType float float float Single )
            value.StartPos                                  = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0x74 StartPos                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CurrentCamera                             = GetObject<CameraWorkData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CameraWorkData.FromPointer); // 0x80 CurrentCamera               ( ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer )

            return value;
        }
    }
}
