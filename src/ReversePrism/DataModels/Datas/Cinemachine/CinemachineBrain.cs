using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_ShowDebugText                          ModelPrimitiveType bool bool bool Bool
    // 021 M_ShowCameraFrustum                      ModelPrimitiveType bool bool bool Bool
    // 022 M_IgnoreTimeScale                        ModelPrimitiveType bool bool bool Bool
    // 028 M_WorldUpOverride                        ModelClassType Transform Transform Transform Pointer
    // 030 M_UpdateMethod                           ModelEnumType UpdateMethod UpdateMethod UpdateMethod Int32
    // 034 M_BlendUpdateMethod                      ModelEnumType BrainUpdateMethod BrainUpdateMethod BrainUpdateMethod Int32
    // 038 M_DefaultBlend                           ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32
    // 048 M_CustomBlends                           ModelClassType CinemachineBlenderSettings CinemachineBlenderSettings CinemachineBlenderSettings Pointer
    // 050 M_OutputCamera                           ModelClassType Camera Camera Camera Pointer
    // 058 M_TargetOverride                         ModelClassType GameObject GameObject GameObject Pointer
    // 060 M_CameraCutEvent                         ModelClassType BrainEvent BrainEvent BrainEvent Pointer
    // 068 M_CameraActivatedEvent                   ModelClassType VcamActivatedEvent VcamActivatedEvent VcamActivatedEvent Pointer
    // 000 mSoloCamera                              ICinemachineCamera IL2CPP_TYPE_CLASS
    // 070 MPhysicsCoroutine                        ModelClassType Coroutine Coroutine Coroutine Pointer
    // 078 M_LastFrameUpdated                       ModelPrimitiveType int int int Int32
    // 080 MWaitForFixedUpdate                      ModelClassType WaitForFixedUpdate WaitForFixedUpdate WaitForFixedUpdate Pointer
    // 088 MFrameStack                              ModelClassListType List`1<BrainFrame> List`1<BrainFrame> List<BrainFrame> Pointer
    // 090 MNextFrameId                             ModelPrimitiveType int int int Int32
    // 098 MCurrentLiveCameras                      ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 008 mDefaultLinearAnimationCurve             AnimationCurve IL2CPP_TYPE_CLASS
    // 0A0 MActiveCameraPreviousFrame               ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 0A8 MActiveCameraPreviousFrameGameObject     ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 CurrentCameraState                       ModelEnumType CameraState CameraState CameraState Int32
    public partial class CinemachineBrain : DataModel
    {
        public bool                                     M_ShowDebugText                         { get; set; }
        public bool                                     M_ShowCameraFrustum                     { get; set; }
        public bool                                     M_IgnoreTimeScale                       { get; set; }
        public Transform?                               M_WorldUpOverride                       { get; set; }
        public UpdateMethod                             M_UpdateMethod                          { get; set; }
        public BrainUpdateMethod                        M_BlendUpdateMethod                     { get; set; }
        public CinemachineBlendDefinition               M_DefaultBlend                          { get; set; }
        public CinemachineBlenderSettings?              M_CustomBlends                          { get; set; }
        public Camera?                                  M_OutputCamera                          { get; set; }
        public GameObject?                              M_TargetOverride                        { get; set; }
        public BrainEvent?                              M_CameraCutEvent                        { get; set; }
        public VcamActivatedEvent?                      M_CameraActivatedEvent                  { get; set; }
        public Coroutine?                               MPhysicsCoroutine                       { get; set; }
        public int                                      M_LastFrameUpdated                      { get; set; }
        public WaitForFixedUpdate?                      MWaitForFixedUpdate                     { get; set; }
        public List<BrainFrame>?                        MFrameStack                             { get; set; }
        public int                                      MNextFrameId                            { get; set; }
        public CinemachineBlend?                        MCurrentLiveCameras                     { get; set; }
        public ICinemachineCamera?                      MActiveCameraPreviousFrame              { get; set; }
        public GameObject?                              MActiveCameraPreviousFrameGameObject    { get; set; }
        public CameraState                              CurrentCameraState                      { get; set; }

        public static CinemachineBrain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineBrain() { Pointer= p0 };

            value.M_ShowDebugText                           = GetBool(new IntPtr(p + 0x020)); // 0x20 M_ShowDebugText             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShowCameraFrustum                       = GetBool(new IntPtr(p + 0x021)); // 0x21 M_ShowCameraFrustum         ( ModelPrimitiveType bool bool bool Bool )
            value.M_IgnoreTimeScale                         = GetBool(new IntPtr(p + 0x022)); // 0x22 M_IgnoreTimeScale           ( ModelPrimitiveType bool bool bool Bool )
            value.M_WorldUpOverride                         = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 M_WorldUpOverride           ( ModelClassType Transform Transform Transform Pointer )
            value.M_UpdateMethod                            = (UpdateMethod)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_UpdateMethod              ( ModelEnumType UpdateMethod UpdateMethod UpdateMethod Int32 )
            value.M_BlendUpdateMethod                       = (BrainUpdateMethod)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_BlendUpdateMethod         ( ModelEnumType BrainUpdateMethod BrainUpdateMethod BrainUpdateMethod Int32 )
            value.M_DefaultBlend                            = (CinemachineBlendDefinition)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_DefaultBlend              ( ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32 )
            value.M_CustomBlends                            = GetObject<CinemachineBlenderSettings>(new IntPtr(p + 0x048), ReversePrism.DataModels.CinemachineBlenderSettings.FromPointer); // 0x48 M_CustomBlends              ( ModelClassType CinemachineBlenderSettings CinemachineBlenderSettings CinemachineBlenderSettings Pointer )
            value.M_OutputCamera                            = GetObject<Camera>(new IntPtr(p + 0x050), ReversePrism.DataModels.Camera.FromPointer); // 0x50 M_OutputCamera              ( ModelClassType Camera Camera Camera Pointer )
            value.M_TargetOverride                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 M_TargetOverride            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_CameraCutEvent                          = GetObject<BrainEvent>(new IntPtr(p + 0x060), ReversePrism.DataModels.BrainEvent.FromPointer); // 0x60 M_CameraCutEvent            ( ModelClassType BrainEvent BrainEvent BrainEvent Pointer )
            value.M_CameraActivatedEvent                    = GetObject<VcamActivatedEvent>(new IntPtr(p + 0x068), ReversePrism.DataModels.VcamActivatedEvent.FromPointer); // 0x68 M_CameraActivatedEvent      ( ModelClassType VcamActivatedEvent VcamActivatedEvent VcamActivatedEvent Pointer )
            value.MPhysicsCoroutine                         = GetObject<Coroutine>(new IntPtr(p + 0x070), ReversePrism.DataModels.Coroutine.FromPointer); // 0x70 MPhysicsCoroutine           ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_LastFrameUpdated                        = GetInt32(new IntPtr(p + 0x078)); // 0x78 M_LastFrameUpdated          ( ModelPrimitiveType int int int Int32 )
            value.MWaitForFixedUpdate                       = GetObject<WaitForFixedUpdate>(new IntPtr(p + 0x080), ReversePrism.DataModels.WaitForFixedUpdate.FromPointer); // 0x80 MWaitForFixedUpdate         ( ModelClassType WaitForFixedUpdate WaitForFixedUpdate WaitForFixedUpdate Pointer )
            value.MFrameStack                               = GetObjectList<BrainFrame>(new IntPtr(p + 0x088), ReversePrism.DataModels.BrainFrame.FromPointer); // 0x88 MFrameStack                 ( ModelClassListType List`1<BrainFrame> List`1<BrainFrame> List<BrainFrame> Pointer )
            value.MNextFrameId                              = GetInt32(new IntPtr(p + 0x090)); // 0x90 MNextFrameId                ( ModelPrimitiveType int int int Int32 )
            value.MCurrentLiveCameras                       = GetObject<CinemachineBlend>(new IntPtr(p + 0x098), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x98 MCurrentLiveCameras         ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.MActiveCameraPreviousFrame                = GetObject<ICinemachineCamera>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0xA0 MActiveCameraPreviousFrame  ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.MActiveCameraPreviousFrameGameObject      = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 MActiveCameraPreviousFrameGameObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentCameraState                        = (CameraState)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 CurrentCameraState          ( ModelEnumType CameraState CameraState CameraState Int32 )

            return value;
        }
    }
}
