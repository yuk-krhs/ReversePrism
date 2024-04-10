using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoveFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 MoveMargin                               0001866656B0 ModelPrimitiveType float float float Single
    // 028 MoveTrans                                0001866656B0 ModelPrimitiveType float float float Single
    // 02C UvParam                                  0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 03C AspectRatio                              0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 04C Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 TargetCam                                0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 058 FarTexture                               00018664CFB0 ModelClassType Texture Texture Texture Pointer
    // 060 StartQ                                   000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 070 StartFovY                                0001866656B0 ModelPrimitiveType float float float Single
    // 074 StartPos                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 CurrentCamera                            0001867254B0 ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer
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

            value.MoveFlag                                  = GetBool(new IntPtr(p + 0x020)); // 024664DB7E90 0x20 MoveFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MoveMargin                                = GetSingle(new IntPtr(p + 0x024)); // 024664DB7EB0 0x24 MoveMargin                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MoveTrans                                 = GetSingle(new IntPtr(p + 0x028)); // 024664DB7ED0 0x28 MoveTrans                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.UvParam                                   = (Vector4)GetInt32(new IntPtr(p + 0x02C)); // 024664DB7EF0 0x2C UvParam                     ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.AspectRatio                               = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 024664DB7F10 0x3C AspectRatio                 ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Initialized                               = GetBool(new IntPtr(p + 0x04C)); // 024664DB7F30 0x4C Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TargetCam                                 = GetObject<Camera>(new IntPtr(p + 0x050), ReversePrism.DataModels.Camera.FromPointer); // 024664DB7F50 0x50 TargetCam                   ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.FarTexture                                = GetObject<Texture>(new IntPtr(p + 0x058), ReversePrism.DataModels.Texture.FromPointer); // 024664DB7F70 0x58 FarTexture                  ( 00018664CFB0 ModelClassType Texture Texture Texture Pointer )
            value.StartQ                                    = (Quaternion)GetInt32(new IntPtr(p + 0x060)); // 024664DB7F90 0x60 StartQ                      ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.StartFovY                                 = GetSingle(new IntPtr(p + 0x070)); // 024664DB7FB0 0x70 StartFovY                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StartPos                                  = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 024664DB7FD0 0x74 StartPos                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CurrentCamera                             = GetObject<CameraWorkData>(new IntPtr(p + 0x080), ReversePrism.DataModels.CameraWorkData.FromPointer); // 024664DB7FF0 0x80 CurrentCamera               ( 0001867254B0 ModelClassType CameraWorkData CameraWorkData CameraWorkData Pointer )

            return value;
        }
    }
}
