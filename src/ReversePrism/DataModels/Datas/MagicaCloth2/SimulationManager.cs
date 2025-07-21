using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamIdArray                              ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 018 nextPosArray                             ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 oldPosArray                              ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 oldRotArray                              ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 030 basePosArray                             ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 baseRotArray                             ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 040 oldPositionArray                         ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 oldRotationArray                         ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 050 velocityPosArray                         ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 dispPosArray                             ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 velocityArray                            ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 realVelocityArray                        ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 frictionArray                            ExNativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 078 staticFrictionArray                      ExNativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 080 collisionNormalArray                     ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 088 DistanceConstraint                       ModelClassType DistanceConstraint DistanceConstraint DistanceConstraint Pointer
    // 090 BendingConstraint                        ModelClassType TriangleBendingConstraint TriangleBendingConstraint TriangleBendingConstraint Pointer
    // 098 TetherConstraint                         ModelClassType TetherConstraint TetherConstraint TetherConstraint Pointer
    // 0A0 AngleConstraint                          ModelClassType AngleConstraint AngleConstraint AngleConstraint Pointer
    // 0A8 InertiaConstraint                        ModelClassType InertiaConstraint InertiaConstraint InertiaConstraint Pointer
    // 0B0 ColliderCollisionConstraint              ModelClassType ColliderCollisionConstraint ColliderCollisionConstraint ColliderCollisionConstraint Pointer
    // 0B8 MotionConstraint                         ModelClassType MotionConstraint MotionConstraint MotionConstraint Pointer
    // 0C0 SelfCollisionConstraint                  ModelClassType SelfCollisionConstraint SelfCollisionConstraint SelfCollisionConstraint Pointer
    // 0C8 processingStepParticle                   ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 0D0 processingStepTriangleBending            ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 0D8 processingStepEdgeCollision              ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 0E0 processingStepCollider                   ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 0E8 processingStepBaseLine                   ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 0F0 processingStepMotionParticle             ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 0F8 processingSelfParticle                   ExProcessingList`1<int> IL2CPP_TYPE_GENERICINST
    // 100 processingSelfPointTriangle              ExProcessingList`1<uint> IL2CPP_TYPE_GENERICINST
    // 108 processingSelfEdgeEdge                   ExProcessingList`1<uint> IL2CPP_TYPE_GENERICINST
    // 110 processingSelfTrianglePoint              ExProcessingList`1<uint> IL2CPP_TYPE_GENERICINST
    // 118 tempFloat3Buffer                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 128 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 138 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 148 stepBasicPositionBuffer                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 158 stepBasicRotationBuffer                  NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 168 SimulationStepCount                      ModelPrimitiveType int int int Int32
    // 16C IsValid                                  ModelPrimitiveType bool bool bool Bool
    public partial class SimulationManager : DataModel
    {
        public DistanceConstraint?                      DistanceConstraint                      { get; set; }
        public TriangleBendingConstraint?               BendingConstraint                       { get; set; }
        public TetherConstraint?                        TetherConstraint                        { get; set; }
        public AngleConstraint?                         AngleConstraint                         { get; set; }
        public InertiaConstraint?                       InertiaConstraint                       { get; set; }
        public ColliderCollisionConstraint?             ColliderCollisionConstraint             { get; set; }
        public MotionConstraint?                        MotionConstraint                        { get; set; }
        public SelfCollisionConstraint?                 SelfCollisionConstraint                 { get; set; }
        public int                                      SimulationStepCount                     { get; set; }
        public bool                                     IsValid                                 { get; set; }

        public static SimulationManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimulationManager() { Pointer= p0 };

            value.DistanceConstraint                        = GetObject<DistanceConstraint>(new IntPtr(p + 0x088), ReversePrism.DataModels.DistanceConstraint.FromPointer); // 0x88 DistanceConstraint          ( ModelClassType DistanceConstraint DistanceConstraint DistanceConstraint Pointer )
            value.BendingConstraint                         = GetObject<TriangleBendingConstraint>(new IntPtr(p + 0x090), ReversePrism.DataModels.TriangleBendingConstraint.FromPointer); // 0x90 BendingConstraint           ( ModelClassType TriangleBendingConstraint TriangleBendingConstraint TriangleBendingConstraint Pointer )
            value.TetherConstraint                          = GetObject<TetherConstraint>(new IntPtr(p + 0x098), ReversePrism.DataModels.TetherConstraint.FromPointer); // 0x98 TetherConstraint            ( ModelClassType TetherConstraint TetherConstraint TetherConstraint Pointer )
            value.AngleConstraint                           = GetObject<AngleConstraint>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AngleConstraint.FromPointer); // 0xA0 AngleConstraint             ( ModelClassType AngleConstraint AngleConstraint AngleConstraint Pointer )
            value.InertiaConstraint                         = GetObject<InertiaConstraint>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.InertiaConstraint.FromPointer); // 0xA8 InertiaConstraint           ( ModelClassType InertiaConstraint InertiaConstraint InertiaConstraint Pointer )
            value.ColliderCollisionConstraint               = GetObject<ColliderCollisionConstraint>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ColliderCollisionConstraint.FromPointer); // 0xB0 ColliderCollisionConstraint ( ModelClassType ColliderCollisionConstraint ColliderCollisionConstraint ColliderCollisionConstraint Pointer )
            value.MotionConstraint                          = GetObject<MotionConstraint>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MotionConstraint.FromPointer); // 0xB8 MotionConstraint            ( ModelClassType MotionConstraint MotionConstraint MotionConstraint Pointer )
            value.SelfCollisionConstraint                   = GetObject<SelfCollisionConstraint>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SelfCollisionConstraint.FromPointer); // 0xC0 SelfCollisionConstraint     ( ModelClassType SelfCollisionConstraint SelfCollisionConstraint SelfCollisionConstraint Pointer )
            value.SimulationStepCount                       = GetInt32(new IntPtr(p + 0x168)); // 0x168 SimulationStepCount         ( ModelPrimitiveType int int int Int32 )
            value.IsValid                                   = GetBool(new IntPtr(p + 0x16C)); // 0x16C IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
