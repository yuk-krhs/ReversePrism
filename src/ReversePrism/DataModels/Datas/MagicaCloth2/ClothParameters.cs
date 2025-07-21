using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Gravity                                  ModelPrimitiveType float float float Single
    // 014 GravityDirection                         ModelEnumType float3 float3 float3 Int32
    // 020 GravityFalloff                           ModelPrimitiveType float float float Single
    // 024 StablizationTimeAfterReset               ModelPrimitiveType float float float Single
    // 028 BlendWeight                              ModelPrimitiveType float float float Single
    // 02C DampingCurveData                         ModelEnumType float4x4 float4x4 float4x4 Int32
    // 06C RadiusCurveData                          ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0AC NormalAxis                               ModelEnumType ClothNormalAxis ClothNormalAxis ClothNormalAxis Int32
    // 0B0 RotationalInterpolation                  ModelPrimitiveType float float float Single
    // 0B4 RootRotation                             ModelPrimitiveType float float float Single
    // 0B8 InertiaConstraint                        ModelEnumType InertiaConstraintParams InertiaConstraintParams InertiaConstraintParams Int32
    // 0F0 TetherConstraint                         ModelEnumType TetherConstraintParams TetherConstraintParams TetherConstraintParams Int32
    // 0F8 DistanceConstraint                       ModelEnumType DistanceConstraintParams DistanceConstraintParams DistanceConstraintParams Int32
    // 13C TriangleBendingConstraint                ModelEnumType TriangleBendingConstraintParams TriangleBendingConstraintParams TriangleBendingConstraintParams Int32
    // 144 AngleConstraint                          ModelEnumType AngleConstraintParams AngleConstraintParams AngleConstraintParams Int32
    // 1D8 MotionConstraint                         ModelEnumType MotionConstraintParams MotionConstraintParams MotionConstraintParams Int32
    // 268 ColliderCollisionConstraint              ModelEnumType ColliderCollisionConstraintParams ColliderCollisionConstraintParams ColliderCollisionConstraintParams Int32
    // 2B4 SelfCollisionConstraint                  ModelEnumType SelfCollisionConstraintParams SelfCollisionConstraintParams SelfCollisionConstraintParams Int32
    // 300 Wind                                     ModelEnumType WindParams WindParams WindParams Int32
    // 31C SpringConstraint                         ModelEnumType SpringConstraintParams SpringConstraintParams SpringConstraintParams Int32
    public partial class ClothParameters : DataModel
    {
        public float                                    Gravity                                 { get; set; }
        public float3                                   GravityDirection                        { get; set; }
        public float                                    GravityFalloff                          { get; set; }
        public float                                    StablizationTimeAfterReset              { get; set; }
        public float                                    BlendWeight                             { get; set; }
        public float4x4                                 DampingCurveData                        { get; set; }
        public float4x4                                 RadiusCurveData                         { get; set; }
        public ClothNormalAxis                          NormalAxis                              { get; set; }
        public float                                    RotationalInterpolation                 { get; set; }
        public float                                    RootRotation                            { get; set; }
        public InertiaConstraintParams                  InertiaConstraint                       { get; set; }
        public TetherConstraintParams                   TetherConstraint                        { get; set; }
        public DistanceConstraintParams                 DistanceConstraint                      { get; set; }
        public TriangleBendingConstraintParams          TriangleBendingConstraint               { get; set; }
        public AngleConstraintParams                    AngleConstraint                         { get; set; }
        public MotionConstraintParams                   MotionConstraint                        { get; set; }
        public ColliderCollisionConstraintParams        ColliderCollisionConstraint             { get; set; }
        public SelfCollisionConstraintParams            SelfCollisionConstraint                 { get; set; }
        public WindParams                               Wind                                    { get; set; }
        public SpringConstraintParams                   SpringConstraint                        { get; set; }

        public static ClothParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothParameters() { Pointer= p0 };

            value.Gravity                                   = GetSingle(new IntPtr(p + 0x010)); // 0x10 Gravity                     ( ModelPrimitiveType float float float Single )
            value.GravityDirection                          = (float3)GetInt32(new IntPtr(p + 0x014)); // 0x14 GravityDirection            ( ModelEnumType float3 float3 float3 Int32 )
            value.GravityFalloff                            = GetSingle(new IntPtr(p + 0x020)); // 0x20 GravityFalloff              ( ModelPrimitiveType float float float Single )
            value.StablizationTimeAfterReset                = GetSingle(new IntPtr(p + 0x024)); // 0x24 StablizationTimeAfterReset  ( ModelPrimitiveType float float float Single )
            value.BlendWeight                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 BlendWeight                 ( ModelPrimitiveType float float float Single )
            value.DampingCurveData                          = (float4x4)GetInt32(new IntPtr(p + 0x02C)); // 0x2C DampingCurveData            ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.RadiusCurveData                           = (float4x4)GetInt32(new IntPtr(p + 0x06C)); // 0x6C RadiusCurveData             ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.NormalAxis                                = (ClothNormalAxis)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC NormalAxis                  ( ModelEnumType ClothNormalAxis ClothNormalAxis ClothNormalAxis Int32 )
            value.RotationalInterpolation                   = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 RotationalInterpolation     ( ModelPrimitiveType float float float Single )
            value.RootRotation                              = GetSingle(new IntPtr(p + 0x0B4)); // 0xB4 RootRotation                ( ModelPrimitiveType float float float Single )
            value.InertiaConstraint                         = (InertiaConstraintParams)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 InertiaConstraint           ( ModelEnumType InertiaConstraintParams InertiaConstraintParams InertiaConstraintParams Int32 )
            value.TetherConstraint                          = (TetherConstraintParams)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 TetherConstraint            ( ModelEnumType TetherConstraintParams TetherConstraintParams TetherConstraintParams Int32 )
            value.DistanceConstraint                        = (DistanceConstraintParams)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 DistanceConstraint          ( ModelEnumType DistanceConstraintParams DistanceConstraintParams DistanceConstraintParams Int32 )
            value.TriangleBendingConstraint                 = (TriangleBendingConstraintParams)GetInt32(new IntPtr(p + 0x13C)); // 0x13C TriangleBendingConstraint   ( ModelEnumType TriangleBendingConstraintParams TriangleBendingConstraintParams TriangleBendingConstraintParams Int32 )
            value.AngleConstraint                           = (AngleConstraintParams)GetInt32(new IntPtr(p + 0x144)); // 0x144 AngleConstraint             ( ModelEnumType AngleConstraintParams AngleConstraintParams AngleConstraintParams Int32 )
            value.MotionConstraint                          = (MotionConstraintParams)GetInt32(new IntPtr(p + 0x1D8)); // 0x1D8 MotionConstraint            ( ModelEnumType MotionConstraintParams MotionConstraintParams MotionConstraintParams Int32 )
            value.ColliderCollisionConstraint               = (ColliderCollisionConstraintParams)GetInt32(new IntPtr(p + 0x268)); // 0x268 ColliderCollisionConstraint ( ModelEnumType ColliderCollisionConstraintParams ColliderCollisionConstraintParams ColliderCollisionConstraintParams Int32 )
            value.SelfCollisionConstraint                   = (SelfCollisionConstraintParams)GetInt32(new IntPtr(p + 0x2B4)); // 0x2B4 SelfCollisionConstraint     ( ModelEnumType SelfCollisionConstraintParams SelfCollisionConstraintParams SelfCollisionConstraintParams Int32 )
            value.Wind                                      = (WindParams)GetInt32(new IntPtr(p + 0x300)); // 0x300 Wind                        ( ModelEnumType WindParams WindParams WindParams Int32 )
            value.SpringConstraint                          = (SpringConstraintParams)GetInt32(new IntPtr(p + 0x31C)); // 0x31C SpringConstraint            ( ModelEnumType SpringConstraintParams SpringConstraintParams SpringConstraintParams Int32 )

            return value;
        }
    }
}
