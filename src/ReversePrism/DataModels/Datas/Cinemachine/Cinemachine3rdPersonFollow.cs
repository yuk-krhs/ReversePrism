using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Damping                                  ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 ShoulderOffset                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 VerticalArmLength                        ModelPrimitiveType float float float Single
    // 044 CameraSide                               ModelPrimitiveType float float float Single
    // 048 CameraDistance                           ModelPrimitiveType float float float Single
    // 04C CameraCollisionFilter                    ModelEnumType LayerMask LayerMask LayerMask Int32
    // 050 IgnoreTag                                ModelPrimitiveType string string string String
    // 058 CameraRadius                             ModelPrimitiveType float float float Single
    // 05C DampingIntoCollision                     ModelPrimitiveType float float float Single
    // 060 DampingFromCollision                     ModelPrimitiveType float float float Single
    // 064 M_PreviousFollowTargetPosition           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 M_DampingCorrection                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 07C M_CamPosCollisionCorrection              ModelPrimitiveType float float float Single
    public partial class Cinemachine3rdPersonFollow : DataModel
    {
        public Vector3                                  Damping                                 { get; set; }
        public Vector3                                  ShoulderOffset                          { get; set; }
        public float                                    VerticalArmLength                       { get; set; }
        public float                                    CameraSide                              { get; set; }
        public float                                    CameraDistance                          { get; set; }
        public LayerMask                                CameraCollisionFilter                   { get; set; }
        public string                                   IgnoreTag                               { get; set; }
        public float                                    CameraRadius                            { get; set; }
        public float                                    DampingIntoCollision                    { get; set; }
        public float                                    DampingFromCollision                    { get; set; }
        public Vector3                                  M_PreviousFollowTargetPosition          { get; set; }
        public Vector3                                  M_DampingCorrection                     { get; set; }
        public float                                    M_CamPosCollisionCorrection             { get; set; }

        public static Cinemachine3rdPersonFollow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cinemachine3rdPersonFollow() { Pointer= p0 };

            value.Damping                                   = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 Damping                     ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ShoulderOffset                            = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 ShoulderOffset              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.VerticalArmLength                         = GetSingle(new IntPtr(p + 0x040)); // 0x40 VerticalArmLength           ( ModelPrimitiveType float float float Single )
            value.CameraSide                                = GetSingle(new IntPtr(p + 0x044)); // 0x44 CameraSide                  ( ModelPrimitiveType float float float Single )
            value.CameraDistance                            = GetSingle(new IntPtr(p + 0x048)); // 0x48 CameraDistance              ( ModelPrimitiveType float float float Single )
            value.CameraCollisionFilter                     = (LayerMask)GetInt32(new IntPtr(p + 0x04C)); // 0x4C CameraCollisionFilter       ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.IgnoreTag                                 = GetString(new IntPtr(p + 0x050)); // 0x50 IgnoreTag                   ( ModelPrimitiveType string string string String )
            value.CameraRadius                              = GetSingle(new IntPtr(p + 0x058)); // 0x58 CameraRadius                ( ModelPrimitiveType float float float Single )
            value.DampingIntoCollision                      = GetSingle(new IntPtr(p + 0x05C)); // 0x5C DampingIntoCollision        ( ModelPrimitiveType float float float Single )
            value.DampingFromCollision                      = GetSingle(new IntPtr(p + 0x060)); // 0x60 DampingFromCollision        ( ModelPrimitiveType float float float Single )
            value.M_PreviousFollowTargetPosition            = (Vector3)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_PreviousFollowTargetPosition ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_DampingCorrection                       = (Vector3)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_DampingCorrection         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CamPosCollisionCorrection               = GetSingle(new IntPtr(p + 0x07C)); // 0x7C M_CamPosCollisionCorrection ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
