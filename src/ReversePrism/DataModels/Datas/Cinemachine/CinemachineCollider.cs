using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_CollideAgainst                         ModelEnumType LayerMask LayerMask LayerMask Int32
    // 038 M_IgnoreTag                              ModelPrimitiveType string string string String
    // 040 M_TransparentLayers                      ModelEnumType LayerMask LayerMask LayerMask Int32
    // 044 M_MinimumDistanceFromTarget              ModelPrimitiveType float float float Single
    // 048 M_AvoidObstacles                         ModelPrimitiveType bool bool bool Bool
    // 04C M_DistanceLimit                          ModelPrimitiveType float float float Single
    // 050 M_MinimumOcclusionTime                   ModelPrimitiveType float float float Single
    // 054 M_CameraRadius                           ModelPrimitiveType float float float Single
    // 058 M_Strategy                               ModelEnumType ResolutionStrategy ResolutionStrategy ResolutionStrategy Int32
    // 05C M_MaximumEffort                          ModelPrimitiveType int int int Int32
    // 060 M_SmoothingTime                          ModelPrimitiveType float float float Single
    // 064 M_Damping                                ModelPrimitiveType float float float Single
    // 068 M_DampingWhenOccluded                    ModelPrimitiveType float float float Single
    // 06C M_OptimalTargetDistance                  ModelPrimitiveType float float float Single
    // 000 k_PrecisionSlush                         float IL2CPP_TYPE_R4
    // 070 M_CornerBuffer                           ModelEnumListType RaycastHit[] RaycastHit[] List<RaycastHit> Pointer
    // 000 k_AngleThreshold                         float IL2CPP_TYPE_R4
    // 000 s_ColliderBuffer                         Collider[] IL2CPP_TYPE_SZARRAY
    public partial class CinemachineCollider : DataModel
    {
        public LayerMask                                M_CollideAgainst                        { get; set; }
        public string                                   M_IgnoreTag                             { get; set; }
        public LayerMask                                M_TransparentLayers                     { get; set; }
        public float                                    M_MinimumDistanceFromTarget             { get; set; }
        public bool                                     M_AvoidObstacles                        { get; set; }
        public float                                    M_DistanceLimit                         { get; set; }
        public float                                    M_MinimumOcclusionTime                  { get; set; }
        public float                                    M_CameraRadius                          { get; set; }
        public ResolutionStrategy                       M_Strategy                              { get; set; }
        public int                                      M_MaximumEffort                         { get; set; }
        public float                                    M_SmoothingTime                         { get; set; }
        public float                                    M_Damping                               { get; set; }
        public float                                    M_DampingWhenOccluded                   { get; set; }
        public float                                    M_OptimalTargetDistance                 { get; set; }
        public List<RaycastHit>?                        M_CornerBuffer                          { get; set; }

        public static CinemachineCollider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineCollider() { Pointer= p0 };

            value.M_CollideAgainst                          = (LayerMask)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_CollideAgainst            ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_IgnoreTag                               = GetString(new IntPtr(p + 0x038)); // 0x38 M_IgnoreTag                 ( ModelPrimitiveType string string string String )
            value.M_TransparentLayers                       = (LayerMask)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_TransparentLayers         ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.M_MinimumDistanceFromTarget               = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_MinimumDistanceFromTarget ( ModelPrimitiveType float float float Single )
            value.M_AvoidObstacles                          = GetBool(new IntPtr(p + 0x048)); // 0x48 M_AvoidObstacles            ( ModelPrimitiveType bool bool bool Bool )
            value.M_DistanceLimit                           = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_DistanceLimit             ( ModelPrimitiveType float float float Single )
            value.M_MinimumOcclusionTime                    = GetSingle(new IntPtr(p + 0x050)); // 0x50 M_MinimumOcclusionTime      ( ModelPrimitiveType float float float Single )
            value.M_CameraRadius                            = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_CameraRadius              ( ModelPrimitiveType float float float Single )
            value.M_Strategy                                = (ResolutionStrategy)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_Strategy                  ( ModelEnumType ResolutionStrategy ResolutionStrategy ResolutionStrategy Int32 )
            value.M_MaximumEffort                           = GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_MaximumEffort             ( ModelPrimitiveType int int int Int32 )
            value.M_SmoothingTime                           = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_SmoothingTime             ( ModelPrimitiveType float float float Single )
            value.M_Damping                                 = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_Damping                   ( ModelPrimitiveType float float float Single )
            value.M_DampingWhenOccluded                     = GetSingle(new IntPtr(p + 0x068)); // 0x68 M_DampingWhenOccluded       ( ModelPrimitiveType float float float Single )
            value.M_OptimalTargetDistance                   = GetSingle(new IntPtr(p + 0x06C)); // 0x6C M_OptimalTargetDistance     ( ModelPrimitiveType float float float Single )
            value.M_CornerBuffer                            = GetEnumList<RaycastHit>(new IntPtr(p + 0x070)); // 0x70 M_CornerBuffer              ( ModelEnumListType RaycastHit[] RaycastHit[] List<RaycastHit> Pointer )

            return value;
        }
    }
}
