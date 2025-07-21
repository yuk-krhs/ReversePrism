using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnchorPosition                           ModelEnumType float3 float3 float3 Int32
    // 01C AnchorRotation                           ModelEnumType quaternion quaternion quaternion Int32
    // 02C OldAnchorPosition                        ModelEnumType float3 float3 float3 Int32
    // 038 OldAnchorRotation                        ModelEnumType quaternion quaternion quaternion Int32
    // 048 AnchorComponentLocalPosition             ModelEnumType float3 float3 float3 Int32
    // 054 CenterTransformIndex                     ModelPrimitiveType int int int Int32
    // 058 ComponentWorldPosition                   ModelEnumType float3 float3 float3 Int32
    // 064 ComponentWorldRotation                   ModelEnumType quaternion quaternion quaternion Int32
    // 074 OldComponentWorldPosition                ModelEnumType float3 float3 float3 Int32
    // 080 OldComponentWorldRotation                ModelEnumType quaternion quaternion quaternion Int32
    // 090 FrameComponentShiftVector                ModelEnumType float3 float3 float3 Int32
    // 09C FrameComponentShiftRotation              ModelEnumType quaternion quaternion quaternion Int32
    // 0AC FrameMovingSpeed                         ModelPrimitiveType float float float Single
    // 0B0 FrameMovingDirection                     ModelEnumType float3 float3 float3 Int32
    // 0BC FrameWorldPosition                       ModelEnumType float3 float3 float3 Int32
    // 0C8 FrameWorldRotation                       ModelEnumType quaternion quaternion quaternion Int32
    // 0D8 FrameWorldScale                          ModelEnumType float3 float3 float3 Int32
    // 0E4 FrameLocalPosition                       ModelEnumType float3 float3 float3 Int32
    // 0F0 OldFrameWorldPosition                    ModelEnumType float3 float3 float3 Int32
    // 0FC OldFrameWorldRotation                    ModelEnumType quaternion quaternion quaternion Int32
    // 10C OldFrameWorldScale                       ModelEnumType float3 float3 float3 Int32
    // 118 NowWorldPosition                         ModelEnumType float3 float3 float3 Int32
    // 124 NowWorldRotation                         ModelEnumType quaternion quaternion quaternion Int32
    // 134 NowWorldScale                            ModelEnumType float3 float3 float3 Int32
    // 140 OldWorldPosition                         ModelEnumType float3 float3 float3 Int32
    // 14C OldWorldRotation                         ModelEnumType quaternion quaternion quaternion Int32
    // 15C StepMoveInertiaRatio                     ModelPrimitiveType float float float Single
    // 160 StepRotationInertiaRatio                 ModelPrimitiveType float float float Single
    // 164 StepVector                               ModelEnumType float3 float3 float3 Int32
    // 170 StepRotation                             ModelEnumType quaternion quaternion quaternion Int32
    // 180 InertiaVector                            ModelEnumType float3 float3 float3 Int32
    // 18C InertiaRotation                          ModelEnumType quaternion quaternion quaternion Int32
    // 19C StepMovingSpeed                          ModelPrimitiveType float float float Single
    // 1A0 StepMovingDirection                      ModelEnumType float3 float3 float3 Int32
    // 1AC AngularVelocity                          ModelPrimitiveType float float float Single
    // 1B0 RotationAxis                             ModelEnumType float3 float3 float3 Int32
    // 1BC InitLocalGravityDirection                ModelEnumType float3 float3 float3 Int32
    // 1C8 SmoothingVelocity                        ModelEnumType float3 float3 float3 Int32
    public partial class CenterData : DataModel
    {
        public float3                                   AnchorPosition                          { get; set; }
        public quaternion                               AnchorRotation                          { get; set; }
        public float3                                   OldAnchorPosition                       { get; set; }
        public quaternion                               OldAnchorRotation                       { get; set; }
        public float3                                   AnchorComponentLocalPosition            { get; set; }
        public int                                      CenterTransformIndex                    { get; set; }
        public float3                                   ComponentWorldPosition                  { get; set; }
        public quaternion                               ComponentWorldRotation                  { get; set; }
        public float3                                   OldComponentWorldPosition               { get; set; }
        public quaternion                               OldComponentWorldRotation               { get; set; }
        public float3                                   FrameComponentShiftVector               { get; set; }
        public quaternion                               FrameComponentShiftRotation             { get; set; }
        public float                                    FrameMovingSpeed                        { get; set; }
        public float3                                   FrameMovingDirection                    { get; set; }
        public float3                                   FrameWorldPosition                      { get; set; }
        public quaternion                               FrameWorldRotation                      { get; set; }
        public float3                                   FrameWorldScale                         { get; set; }
        public float3                                   FrameLocalPosition                      { get; set; }
        public float3                                   OldFrameWorldPosition                   { get; set; }
        public quaternion                               OldFrameWorldRotation                   { get; set; }
        public float3                                   OldFrameWorldScale                      { get; set; }
        public float3                                   NowWorldPosition                        { get; set; }
        public quaternion                               NowWorldRotation                        { get; set; }
        public float3                                   NowWorldScale                           { get; set; }
        public float3                                   OldWorldPosition                        { get; set; }
        public quaternion                               OldWorldRotation                        { get; set; }
        public float                                    StepMoveInertiaRatio                    { get; set; }
        public float                                    StepRotationInertiaRatio                { get; set; }
        public float3                                   StepVector                              { get; set; }
        public quaternion                               StepRotation                            { get; set; }
        public float3                                   InertiaVector                           { get; set; }
        public quaternion                               InertiaRotation                         { get; set; }
        public float                                    StepMovingSpeed                         { get; set; }
        public float3                                   StepMovingDirection                     { get; set; }
        public float                                    AngularVelocity                         { get; set; }
        public float3                                   RotationAxis                            { get; set; }
        public float3                                   InitLocalGravityDirection               { get; set; }
        public float3                                   SmoothingVelocity                       { get; set; }

        public static CenterData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CenterData() { Pointer= p0 };

            value.AnchorPosition                            = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 AnchorPosition              ( ModelEnumType float3 float3 float3 Int32 )
            value.AnchorRotation                            = (quaternion)GetInt32(new IntPtr(p + 0x01C)); // 0x1C AnchorRotation              ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.OldAnchorPosition                         = (float3)GetInt32(new IntPtr(p + 0x02C)); // 0x2C OldAnchorPosition           ( ModelEnumType float3 float3 float3 Int32 )
            value.OldAnchorRotation                         = (quaternion)GetInt32(new IntPtr(p + 0x038)); // 0x38 OldAnchorRotation           ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.AnchorComponentLocalPosition              = (float3)GetInt32(new IntPtr(p + 0x048)); // 0x48 AnchorComponentLocalPosition ( ModelEnumType float3 float3 float3 Int32 )
            value.CenterTransformIndex                      = GetInt32(new IntPtr(p + 0x054)); // 0x54 CenterTransformIndex        ( ModelPrimitiveType int int int Int32 )
            value.ComponentWorldPosition                    = (float3)GetInt32(new IntPtr(p + 0x058)); // 0x58 ComponentWorldPosition      ( ModelEnumType float3 float3 float3 Int32 )
            value.ComponentWorldRotation                    = (quaternion)GetInt32(new IntPtr(p + 0x064)); // 0x64 ComponentWorldRotation      ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.OldComponentWorldPosition                 = (float3)GetInt32(new IntPtr(p + 0x074)); // 0x74 OldComponentWorldPosition   ( ModelEnumType float3 float3 float3 Int32 )
            value.OldComponentWorldRotation                 = (quaternion)GetInt32(new IntPtr(p + 0x080)); // 0x80 OldComponentWorldRotation   ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.FrameComponentShiftVector                 = (float3)GetInt32(new IntPtr(p + 0x090)); // 0x90 FrameComponentShiftVector   ( ModelEnumType float3 float3 float3 Int32 )
            value.FrameComponentShiftRotation               = (quaternion)GetInt32(new IntPtr(p + 0x09C)); // 0x9C FrameComponentShiftRotation ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.FrameMovingSpeed                          = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC FrameMovingSpeed            ( ModelPrimitiveType float float float Single )
            value.FrameMovingDirection                      = (float3)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 FrameMovingDirection        ( ModelEnumType float3 float3 float3 Int32 )
            value.FrameWorldPosition                        = (float3)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC FrameWorldPosition          ( ModelEnumType float3 float3 float3 Int32 )
            value.FrameWorldRotation                        = (quaternion)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 FrameWorldRotation          ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.FrameWorldScale                           = (float3)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 FrameWorldScale             ( ModelEnumType float3 float3 float3 Int32 )
            value.FrameLocalPosition                        = (float3)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 FrameLocalPosition          ( ModelEnumType float3 float3 float3 Int32 )
            value.OldFrameWorldPosition                     = (float3)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 OldFrameWorldPosition       ( ModelEnumType float3 float3 float3 Int32 )
            value.OldFrameWorldRotation                     = (quaternion)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC OldFrameWorldRotation       ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.OldFrameWorldScale                        = (float3)GetInt32(new IntPtr(p + 0x10C)); // 0x10C OldFrameWorldScale          ( ModelEnumType float3 float3 float3 Int32 )
            value.NowWorldPosition                          = (float3)GetInt32(new IntPtr(p + 0x118)); // 0x118 NowWorldPosition            ( ModelEnumType float3 float3 float3 Int32 )
            value.NowWorldRotation                          = (quaternion)GetInt32(new IntPtr(p + 0x124)); // 0x124 NowWorldRotation            ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.NowWorldScale                             = (float3)GetInt32(new IntPtr(p + 0x134)); // 0x134 NowWorldScale               ( ModelEnumType float3 float3 float3 Int32 )
            value.OldWorldPosition                          = (float3)GetInt32(new IntPtr(p + 0x140)); // 0x140 OldWorldPosition            ( ModelEnumType float3 float3 float3 Int32 )
            value.OldWorldRotation                          = (quaternion)GetInt32(new IntPtr(p + 0x14C)); // 0x14C OldWorldRotation            ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.StepMoveInertiaRatio                      = GetSingle(new IntPtr(p + 0x15C)); // 0x15C StepMoveInertiaRatio        ( ModelPrimitiveType float float float Single )
            value.StepRotationInertiaRatio                  = GetSingle(new IntPtr(p + 0x160)); // 0x160 StepRotationInertiaRatio    ( ModelPrimitiveType float float float Single )
            value.StepVector                                = (float3)GetInt32(new IntPtr(p + 0x164)); // 0x164 StepVector                  ( ModelEnumType float3 float3 float3 Int32 )
            value.StepRotation                              = (quaternion)GetInt32(new IntPtr(p + 0x170)); // 0x170 StepRotation                ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.InertiaVector                             = (float3)GetInt32(new IntPtr(p + 0x180)); // 0x180 InertiaVector               ( ModelEnumType float3 float3 float3 Int32 )
            value.InertiaRotation                           = (quaternion)GetInt32(new IntPtr(p + 0x18C)); // 0x18C InertiaRotation             ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.StepMovingSpeed                           = GetSingle(new IntPtr(p + 0x19C)); // 0x19C StepMovingSpeed             ( ModelPrimitiveType float float float Single )
            value.StepMovingDirection                       = (float3)GetInt32(new IntPtr(p + 0x1A0)); // 0x1A0 StepMovingDirection         ( ModelEnumType float3 float3 float3 Int32 )
            value.AngularVelocity                           = GetSingle(new IntPtr(p + 0x1AC)); // 0x1AC AngularVelocity             ( ModelPrimitiveType float float float Single )
            value.RotationAxis                              = (float3)GetInt32(new IntPtr(p + 0x1B0)); // 0x1B0 RotationAxis                ( ModelEnumType float3 float3 float3 Int32 )
            value.InitLocalGravityDirection                 = (float3)GetInt32(new IntPtr(p + 0x1BC)); // 0x1BC InitLocalGravityDirection   ( ModelEnumType float3 float3 float3 Int32 )
            value.SmoothingVelocity                         = (float3)GetInt32(new IntPtr(p + 0x1C8)); // 0x1C8 SmoothingVelocity           ( ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
