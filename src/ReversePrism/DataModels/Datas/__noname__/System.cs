using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefineSymbol                             string IL2CPP_TYPE_STRING
    // 000 LatestPreBuildVersion                    int IL2CPP_TYPE_I4
    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    // 000 MaxRendererCount                         int IL2CPP_TYPE_I4
    // 000 MinimumGridSize                          float IL2CPP_TYPE_R4
    // 000 MaximumTeamCount                         int IL2CPP_TYPE_I4
    // 000 DefaultSimulationFrequency               int IL2CPP_TYPE_I4
    // 000 SimulationFrequency_Low                  int IL2CPP_TYPE_I4
    // 000 SimulationFrequency_Hi                   int IL2CPP_TYPE_I4
    // 000 DefaultMaxSimulationCountPerFrame        int IL2CPP_TYPE_I4
    // 000 MaxSimulationCountPerFrame_Low           int IL2CPP_TYPE_I4
    // 000 MaxSimulationCountPerFrame_Hi            int IL2CPP_TYPE_I4
    // 000 SameSurfaceAngle                         float IL2CPP_TYPE_R4
    // 000 ReductionEnable                          bool IL2CPP_TYPE_BOOLEAN
    // 000 ReductionSameDistance                    float IL2CPP_TYPE_R4
    // 000 ReductionDontMakeLine                    bool IL2CPP_TYPE_BOOLEAN
    // 000 ReductionJoinPositionAdjustment          float IL2CPP_TYPE_R4
    // 000 ReductionMaxStep                         int IL2CPP_TYPE_I4
    // 000 MaxProxyMeshVertexCount                  int IL2CPP_TYPE_I4
    // 000 MaxProxyMeshEdgeCount                    int IL2CPP_TYPE_I4
    // 000 MaxProxyMeshTriangleCount                int IL2CPP_TYPE_I4
    // 000 ProxyMeshTrianglePairAngle               float IL2CPP_TYPE_R4
    // 000 ProxyMeshBoneClothTriangleAngle          float IL2CPP_TYPE_R4
    // 000 FrictionMass                             float IL2CPP_TYPE_R4
    // 000 DepthMass                                float IL2CPP_TYPE_R4
    // 000 FrictionDampingRate                      float IL2CPP_TYPE_R4
    // 000 PositionAverageExponent                  float IL2CPP_TYPE_R4
    // 000 MaxRealVelocity                          float IL2CPP_TYPE_R4
    // 000 TetherCompressionStiffness               float IL2CPP_TYPE_R4
    // 000 TetherStretchStiffness                   float IL2CPP_TYPE_R4
    // 000 TetherStretchLimit                       float IL2CPP_TYPE_R4
    // 000 TetherStiffnessWidth                     float IL2CPP_TYPE_R4
    // 000 TetherCompressionVelocityAttenuation     float IL2CPP_TYPE_R4
    // 000 TetherStretchVelocityAttenuation         float IL2CPP_TYPE_R4
    // 000 DistanceVelocityAttenuation              float IL2CPP_TYPE_R4
    // 000 DistanceVerticalStiffness                float IL2CPP_TYPE_R4
    // 000 DistanceHorizontalStiffness              float IL2CPP_TYPE_R4
    // 000 TriangleBendingMaxAngle                  float IL2CPP_TYPE_R4
    // 000 VolumeMinAngle                           float IL2CPP_TYPE_R4
    // 000 MaxAngleLimit                            float IL2CPP_TYPE_R4
    // 000 AngleLimitIteration                      int IL2CPP_TYPE_I4
    // 000 AngleLimitAttenuation                    float IL2CPP_TYPE_R4
    // 000 MaxMovementSpeedLimit                    float IL2CPP_TYPE_R4
    // 000 MaxRotationSpeedLimit                    float IL2CPP_TYPE_R4
    // 000 MaxParticleSpeedLimit                    float IL2CPP_TYPE_R4
    // 000 ExpandedColliderCount                    int IL2CPP_TYPE_I4
    // 000 ColliderCollisionDynamicFrictionRatio    float IL2CPP_TYPE_R4
    // 000 ColliderCollisionStaticFrictionRatio     float IL2CPP_TYPE_R4
    // 000 CustomSkinningAngularAttenuation         float IL2CPP_TYPE_R4
    // 000 CustomSkinningDistanceReduction          float IL2CPP_TYPE_R4
    // 000 CustomSkinningDistancePow                float IL2CPP_TYPE_R4
    // 000 SelfCollisionSolverIteration             int IL2CPP_TYPE_I4
    // 000 SelfCollisionFixedMass                   float IL2CPP_TYPE_R4
    // 000 SelfCollisionFrictionMass                float IL2CPP_TYPE_R4
    // 000 SelfCollisionClothMass                   float IL2CPP_TYPE_R4
    // 000 SelfCollisionSCR                         float IL2CPP_TYPE_R4
    // 000 SelfCollisionPointTriangleAngleCos       float IL2CPP_TYPE_R4
    // 000 SelfCollisionIntersectDiv                int IL2CPP_TYPE_I4
    // 000 SelfCollisionThicknessMin                float IL2CPP_TYPE_R4
    // 000 SelfCollisionThicknessMax                float IL2CPP_TYPE_R4
    // 000 WindMaxTime                              float IL2CPP_TYPE_R4
    // 000 WindBaseSpeed                            float IL2CPP_TYPE_R4
    // 000 BoneSpringDistanceStiffness              float IL2CPP_TYPE_R4
    // 000 BoneSpringTetherCompressionLimit         float IL2CPP_TYPE_R4
    // 000 BoneSpringCollisionFriction              float IL2CPP_TYPE_R4
    public partial class System : DataModel
    {

        public static System? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new System() { Pointer= p0 };


            return value;
        }
    }
}
