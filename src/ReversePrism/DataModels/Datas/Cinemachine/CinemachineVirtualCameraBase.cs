using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_ExcludedPropertiesInInspector          ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 M_LockStageInInspector                   ModelEnumListType Stage[] Stage[] List<Stage> Pointer
    // 030 M_ValidatingStreamVersion                ModelPrimitiveType int int int Int32
    // 034 M_OnValidateCalled                       ModelPrimitiveType bool bool bool Bool
    // 038 M_StreamingVersion                       ModelPrimitiveType int int int Int32
    // 03C M_Priority                               ModelPrimitiveType int int int Int32
    // 040 M_ActivationId                           ModelPrimitiveType int int int Int32
    // 044 FollowTargetAttachment                   ModelPrimitiveType float float float Single
    // 048 LookAtTargetAttachment                   ModelPrimitiveType float float float Single
    // 04C M_StandbyUpdate                          ModelEnumType StandbyUpdateMode StandbyUpdateMode StandbyUpdateMode Int32
    // 050 MExtensions                              ModelClassListType List`1<CinemachineExtension> List`1<CinemachineExtension> List<CinemachineExtension> Pointer
    // 058 PreviousStateIsValid                     ModelPrimitiveType bool bool bool Bool
    // 059 M_WasStarted                             ModelPrimitiveType bool bool bool Bool
    // 05A MSlaveStatusUpdated                      ModelPrimitiveType bool bool bool Bool
    // 060 M_parentVcam                             ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    // 068 M_QueuePriority                          ModelPrimitiveType int int int Int32
    // 06C M_blendStartPosition                     ModelPrimitiveType float float float Single
    // 070 M_CachedFollowTarget                     ModelClassType Transform Transform Transform Pointer
    // 078 M_CachedFollowTargetVcam                 ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    // 080 M_CachedFollowTargetGroup                ModelClassType ICinemachineTargetGroup ICinemachineTargetGroup ICinemachineTargetGroup Pointer
    // 088 M_CachedLookAtTarget                     ModelClassType Transform Transform Transform Pointer
    // 090 M_CachedLookAtTargetVcam                 ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    // 098 M_CachedLookAtTargetGroup                ModelClassType ICinemachineTargetGroup ICinemachineTargetGroup ICinemachineTargetGroup Pointer
    // 0A0 FollowTargetChanged                      ModelPrimitiveType bool bool bool Bool
    // 0A1 LookAtTargetChanged                      ModelPrimitiveType bool bool bool Bool
    public partial class CinemachineVirtualCameraBase : DataModel
    {
        public List<string>?                            M_ExcludedPropertiesInInspector         { get; set; }
        public List<Stage>?                             M_LockStageInInspector                  { get; set; }
        public int                                      M_ValidatingStreamVersion               { get; set; }
        public bool                                     M_OnValidateCalled                      { get; set; }
        public int                                      M_StreamingVersion                      { get; set; }
        public int                                      M_Priority                              { get; set; }
        public int                                      M_ActivationId                          { get; set; }
        public float                                    FollowTargetAttachment                  { get; set; }
        public float                                    LookAtTargetAttachment                  { get; set; }
        public StandbyUpdateMode                        M_StandbyUpdate                         { get; set; }
        public List<CinemachineExtension>?              MExtensions                             { get; set; }
        public bool                                     PreviousStateIsValid                    { get; set; }
        public bool                                     M_WasStarted                            { get; set; }
        public bool                                     MSlaveStatusUpdated                     { get; set; }
        public CinemachineVirtualCameraBase?            M_parentVcam                            { get; set; }
        public int                                      M_QueuePriority                         { get; set; }
        public float                                    M_blendStartPosition                    { get; set; }
        public Transform?                               M_CachedFollowTarget                    { get; set; }
        public CinemachineVirtualCameraBase?            M_CachedFollowTargetVcam                { get; set; }
        public ICinemachineTargetGroup?                 M_CachedFollowTargetGroup               { get; set; }
        public Transform?                               M_CachedLookAtTarget                    { get; set; }
        public CinemachineVirtualCameraBase?            M_CachedLookAtTargetVcam                { get; set; }
        public ICinemachineTargetGroup?                 M_CachedLookAtTargetGroup               { get; set; }
        public bool                                     FollowTargetChanged                     { get; set; }
        public bool                                     LookAtTargetChanged                     { get; set; }

        public static CinemachineVirtualCameraBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineVirtualCameraBase() { Pointer= p0 };

            value.M_ExcludedPropertiesInInspector           = GetStringList(new IntPtr(p + 0x020)); // 0x20 M_ExcludedPropertiesInInspector ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_LockStageInInspector                    = GetEnumList<Stage>(new IntPtr(p + 0x028)); // 0x28 M_LockStageInInspector      ( ModelEnumListType Stage[] Stage[] List<Stage> Pointer )
            value.M_ValidatingStreamVersion                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_ValidatingStreamVersion   ( ModelPrimitiveType int int int Int32 )
            value.M_OnValidateCalled                        = GetBool(new IntPtr(p + 0x034)); // 0x34 M_OnValidateCalled          ( ModelPrimitiveType bool bool bool Bool )
            value.M_StreamingVersion                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_StreamingVersion          ( ModelPrimitiveType int int int Int32 )
            value.M_Priority                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_Priority                  ( ModelPrimitiveType int int int Int32 )
            value.M_ActivationId                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_ActivationId              ( ModelPrimitiveType int int int Int32 )
            value.FollowTargetAttachment                    = GetSingle(new IntPtr(p + 0x044)); // 0x44 FollowTargetAttachment      ( ModelPrimitiveType float float float Single )
            value.LookAtTargetAttachment                    = GetSingle(new IntPtr(p + 0x048)); // 0x48 LookAtTargetAttachment      ( ModelPrimitiveType float float float Single )
            value.M_StandbyUpdate                           = (StandbyUpdateMode)GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_StandbyUpdate             ( ModelEnumType StandbyUpdateMode StandbyUpdateMode StandbyUpdateMode Int32 )
            value.MExtensions                               = GetObjectList<CinemachineExtension>(new IntPtr(p + 0x050), ReversePrism.DataModels.CinemachineExtension.FromPointer); // 0x50 MExtensions                 ( ModelClassListType List`1<CinemachineExtension> List`1<CinemachineExtension> List<CinemachineExtension> Pointer )
            value.PreviousStateIsValid                      = GetBool(new IntPtr(p + 0x058)); // 0x58 PreviousStateIsValid        ( ModelPrimitiveType bool bool bool Bool )
            value.M_WasStarted                              = GetBool(new IntPtr(p + 0x059)); // 0x59 M_WasStarted                ( ModelPrimitiveType bool bool bool Bool )
            value.MSlaveStatusUpdated                       = GetBool(new IntPtr(p + 0x05A)); // 0x5A MSlaveStatusUpdated         ( ModelPrimitiveType bool bool bool Bool )
            value.M_parentVcam                              = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x60 M_parentVcam                ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )
            value.M_QueuePriority                           = GetInt32(new IntPtr(p + 0x068)); // 0x68 M_QueuePriority             ( ModelPrimitiveType int int int Int32 )
            value.M_blendStartPosition                      = GetSingle(new IntPtr(p + 0x06C)); // 0x6C M_blendStartPosition        ( ModelPrimitiveType float float float Single )
            value.M_CachedFollowTarget                      = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 M_CachedFollowTarget        ( ModelClassType Transform Transform Transform Pointer )
            value.M_CachedFollowTargetVcam                  = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x78 M_CachedFollowTargetVcam    ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )
            value.M_CachedFollowTargetGroup                 = GetObject<ICinemachineTargetGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ICinemachineTargetGroup.FromPointer); // 0x80 M_CachedFollowTargetGroup   ( ModelClassType ICinemachineTargetGroup ICinemachineTargetGroup ICinemachineTargetGroup Pointer )
            value.M_CachedLookAtTarget                      = GetObject<Transform>(new IntPtr(p + 0x088), ReversePrism.DataModels.Transform.FromPointer); // 0x88 M_CachedLookAtTarget        ( ModelClassType Transform Transform Transform Pointer )
            value.M_CachedLookAtTargetVcam                  = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x090), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x90 M_CachedLookAtTargetVcam    ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )
            value.M_CachedLookAtTargetGroup                 = GetObject<ICinemachineTargetGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.ICinemachineTargetGroup.FromPointer); // 0x98 M_CachedLookAtTargetGroup   ( ModelClassType ICinemachineTargetGroup ICinemachineTargetGroup ICinemachineTargetGroup Pointer )
            value.FollowTargetChanged                       = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 FollowTargetChanged         ( ModelPrimitiveType bool bool bool Bool )
            value.LookAtTargetChanged                       = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 LookAtTargetChanged         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
